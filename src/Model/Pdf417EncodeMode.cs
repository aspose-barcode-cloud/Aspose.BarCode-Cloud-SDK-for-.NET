
using System.Text.Json.Serialization;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     PDF417 barcode encode mode. Mirrors https://reference.aspose.com/barcode/net/aspose.barcode.generation/pdf417encodemode/
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Pdf417EncodeMode
    {
        /// <summary>
        ///     Enum value Auto
        /// </summary>
        Auto,

        /// <summary>
        ///     Enum value Binary
        /// </summary>
        Binary,

        /// <summary>
        ///     Enum value ECI
        /// </summary>
        ECI,

        /// <summary>
        ///     Enum value Extended
        /// </summary>
        Extended

    }
}
