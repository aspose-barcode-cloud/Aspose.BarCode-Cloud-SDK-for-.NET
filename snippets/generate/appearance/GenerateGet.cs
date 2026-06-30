using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Model;

using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace GenerateSnippets;

internal static class Program
{
    private static Configuration MakeConfiguration()
    {
        var config = new Configuration();

        string? envToken = Environment.GetEnvironmentVariable("TEST_CONFIGURATION_ACCESS_TOKEN");
        if (string.IsNullOrEmpty(envToken))
        {
            config.ClientId = "Client Id from https://dashboard.aspose.cloud/applications";
            config.ClientSecret = "Client Secret from https://dashboard.aspose.cloud/applications";
        }
        else
        {
            config.JwtToken = envToken;
        }

        return config;
    }

    public static async Task Main(string[] args)
    {
        string fileName = Path.GetFullPath(Path.Join("Tests", "test_data",
            "qr.png"
        ));

        GenerateApi generateApi = new GenerateApi(MakeConfiguration());

        var generated = await generateApi.GenerateAsync(barcodeType: EncodeBarcodeType.QR,
            data: "Aspose.BarCode.Cloud",
            barcodeImageParams: new BarcodeImageParams
            {
                ImageFormat = BarcodeImageFormat.Png,
                ForegroundColor = "Black",
                BackgroundColor = "White",
                TextLocation = CodeLocation.Below,
                Resolution = 300,
                ImageHeight = 200,
                ImageWidth = 200
            },
            qrParams: new QrParams
            {
                QrEncodeMode = QREncodeMode.Auto,
                QrErrorLevel = QRErrorLevel.LevelM,
                QrVersion = QRVersion.Auto,
                QrAspectRatio = 0.75f
            });

        await using FileStream stream = File.Create(fileName);
        await generated.CopyToAsync(stream);

        Console.WriteLine($"File '{fileName}' generated.");
    }
}
