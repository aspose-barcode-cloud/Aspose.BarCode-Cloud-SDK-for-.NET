using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Model;

internal static class Program
{
    public static async Task Main()
    {
        var configuration = new Configuration
        {
            JwtToken = Environment.GetEnvironmentVariable("TEST_CONFIGURATION_ACCESS_TOKEN")
        };
        var batch = new BatchGenerateRequest
        {
            ArchiveFormat = BatchArchiveFormat.Zip,
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
        using Stream data = await new GenerateApi(configuration).GenerateBatchAsync(batch);
        using FileStream archive = File.Create("barcodes.zip");
        await data.CopyToAsync(archive);
    }
}
