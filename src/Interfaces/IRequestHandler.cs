using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    internal interface IRequestHandler
    {
        void Preparing();

        void BeforeSend(WebRequest request, Stream streamToSend);

        void ProcessResponse(HttpWebResponse response, Stream resultStream);

        Task PreparingAsync(CancellationToken cancellationToken);
        Task BeforeSendAsync(HttpRequestMessage request);
        Task ProcessResponseAsync(HttpResponseMessage response, CancellationToken cancellationToken);
    }
}
