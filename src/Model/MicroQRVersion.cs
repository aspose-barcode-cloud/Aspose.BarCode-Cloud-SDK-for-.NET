
using System.Text.Json.Serialization;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     MicroQR barcode version. Mirrors https://reference.aspose.com/barcode/net/aspose.barcode.generation/microqrversion/
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MicroQRVersion
    {
        /// <summary>
        ///     Enum value Auto
        /// </summary>
        Auto,

        /// <summary>
        ///     Enum value M1
        /// </summary>
        M1,

        /// <summary>
        ///     Enum value M2
        /// </summary>
        M2,

        /// <summary>
        ///     Enum value M3
        /// </summary>
        M3,

        /// <summary>
        ///     Enum value M4
        /// </summary>
        M4

    }
}
