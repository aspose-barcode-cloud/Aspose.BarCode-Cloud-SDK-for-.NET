
using System.Text.Json.Serialization;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     QR barcode encode mode. Subset of https://reference.aspose.com/barcode/net/aspose.barcode.generation/qrencodemode/ Obsolete members (Bytes, Utf8BOM, Utf16BEBOM, ECIEncoding, ExtendedCodetext) are omitted.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum QREncodeMode
    {
        /// <summary>
        ///     Enum value Auto
        /// </summary>
        Auto,

        /// <summary>
        ///     Enum value Extended
        /// </summary>
        Extended,

        /// <summary>
        ///     Enum value Binary
        /// </summary>
        Binary,

        /// <summary>
        ///     Enum value ECI
        /// </summary>
        ECI

    }
}
