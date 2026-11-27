using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    /// <summary>
    ///     Offline tests: requests go to a local listener that accepts connections and never answers,
    ///     so a call can only finish early if its CancellationToken reaches HttpClient.SendAsync.
    /// </summary>
    [TestFixture]
    public class CancellationTests
    {
        private static readonly TimeSpan MaxWait = TimeSpan.FromSeconds(10);

        private TcpListener _listener;
        private string _baseUrl;

        [SetUp]
        public void StartSilentServer()
        {
            _listener = new TcpListener(IPAddress.Loopback, 0);
            _listener.Start();
            _baseUrl = $"http://127.0.0.1:{((IPEndPoint)_listener.LocalEndpoint).Port}";
        }

        [TearDown]
        public void StopSilentServer()
        {
            _listener.Stop();
        }

        [Test]
        public async Task CancelledTokenThrowsOperationCanceledException()
        {
            GenerateApi api = new GenerateApi(new Configuration { ApiBaseUrl = _baseUrl, JwtToken = "token" });
            using CancellationTokenSource cts = new CancellationTokenSource();
            cts.Cancel();

            await AssertCancelledAsync(() => api.GenerateBodyAsync(MakeGenerateParams(), cts.Token));
        }

        [Test]
        public async Task CancellingInFlightRequestThrowsOperationCanceledException()
        {
            ScanApi api = new ScanApi(new Configuration { ApiBaseUrl = _baseUrl, JwtToken = "token" });
            using CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(200));

            await AssertCancelledAsync(() => api.ScanAsync("https://example.com/qr.png", cts.Token));
        }

        [Test]
        public async Task CancelledTokenStopsJwtTokenRequest()
        {
            Configuration configuration = new Configuration
            {
                ApiBaseUrl = _baseUrl,
                TokenUrl = _baseUrl + "/connect/token",
                ClientId = "client id",
                ClientSecret = "client secret"
            };
            GenerateApi api = new GenerateApi(configuration);
            using CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(200));

            await AssertCancelledAsync(() => api.GenerateBodyAsync(MakeGenerateParams(), cts.Token));
        }

        private static async Task AssertCancelledAsync(Func<Task> call)
        {
            Task callTask = call();
            Task finished = await Task.WhenAny(callTask, Task.Delay(MaxWait));

            Assert.AreSame(callTask, finished, $"The request was not cancelled within {MaxWait}");
            Assert.CatchAsync<OperationCanceledException>(async () => await callTask);
        }

        private static GenerateParams MakeGenerateParams()
        {
            return new GenerateParams
            {
                BarcodeType = EncodeBarcodeType.QR,
                EncodeData = new EncodeData { Data = "Cancellation test" }
            };
        }
    }
}
