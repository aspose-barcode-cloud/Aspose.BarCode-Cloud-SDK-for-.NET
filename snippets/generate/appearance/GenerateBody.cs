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
            "QrCustom.jpeg"
        ));

        GenerateApi generateApi = new GenerateApi(MakeConfiguration());

        var generateParams = new GenerateParams
        {
            BarcodeType = EncodeBarcodeType.QR,
            EncodeData = new EncodeData { Data = "Aspose", DataType = EncodeDataType.StringData },
            BarcodeImageParams = new BarcodeImageParams
            {
                ForegroundColor = "#FF0000",
                BackgroundColor = "#FFFF00",
                ImageFormat = BarcodeImageFormat.Jpeg,
                RotationAngle = 90
            },
            QrParams = new QrParams
            {
                QrEncodeMode = QREncodeMode.Auto,
                QrErrorLevel = QRErrorLevel.LevelM,
                QrVersion = QRVersion.Auto,
                QrAspectRatio = 0.75f
            }
        };

        var generated = await generateApi.GenerateBodyAsync(generateParams);

        await using FileStream stream = File.Create(fileName);
        await generated.CopyToAsync(stream);

        Console.WriteLine($"File '{fileName}' generated.");
    }
}
