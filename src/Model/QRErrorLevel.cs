
using System.Text.Json.Serialization;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     QR barcode error correction level. Mirrors https://reference.aspose.com/barcode/net/aspose.barcode.generation/qrerrorlevel/
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum QRErrorLevel
    {
        /// <summary>
        ///     Enum value LevelL
        /// </summary>
        LevelL,

        /// <summary>
        ///     Enum value LevelM
        /// </summary>
        LevelM,

        /// <summary>
        ///     Enum value LevelQ
        /// </summary>
        LevelQ,

        /// <summary>
        ///     Enum value LevelH
        /// </summary>
        LevelH

    }
}
