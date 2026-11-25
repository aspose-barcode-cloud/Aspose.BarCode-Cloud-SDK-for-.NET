using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    public class BatchGenerateTests : TestsBase
    {
        [TestCase(BatchArchiveFormat.Zip)]
        [TestCase(BatchArchiveFormat.Tar)]
        [TestCase(BatchArchiveFormat.TarGzip)]
        public async Task GeneratesBinaryArchive(BatchArchiveFormat format)
        {
            var batch = new BatchGenerateRequest
            {
                ArchiveFormat = format,
                Items = new List<BatchGenerateItem>
                {
                    new BatchGenerateItem
                    {
                        FileName = "qr.png",
                        Generation = new GenerateParams
                        {
                            BarcodeType = EncodeBarcodeType.QR,
                            EncodeData = new EncodeData { Data = "Batch example" }
                        }
                    }
                }
            };
            using Stream response = await new GenerateApi(TestConfiguration).GenerateBatchAsync(batch);
            using var data = new MemoryStream();
            await response.CopyToAsync(data);
            byte[] bytes = data.ToArray();
            Assert.Greater(bytes.Length, 0);
            if (format == BatchArchiveFormat.Zip)
            {
                data.Position = 0;
                using var zip = new ZipArchive(data, ZipArchiveMode.Read);
                Assert.AreEqual(1, zip.Entries.Count);
                Assert.AreEqual("qr.png", zip.Entries[0].FullName);
                Assert.Greater(zip.Entries[0].Length, 0);
            }
            else if (format == BatchArchiveFormat.TarGzip)
                CollectionAssert.AreEqual(new byte[] { 0x1f, 0x8b }, new[] { bytes[0], bytes[1] });
            else
                StringAssert.Contains("ustar", System.Text.Encoding.ASCII.GetString(bytes, 257, 5));
        }
    }
}
