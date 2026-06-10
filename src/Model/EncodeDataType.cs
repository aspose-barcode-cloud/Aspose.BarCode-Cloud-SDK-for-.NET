
using System.Text.Json.Serialization;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Types of data that can be encoded into a barcode.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EncodeDataType
    {
        /// <summary>
        ///     Enum value StringData
        /// </summary>
        StringData,

        /// <summary>
        ///     Enum value Base64Bytes
        /// </summary>
        Base64Bytes,

        /// <summary>
        ///     Enum value HexBytes
        /// </summary>
        HexBytes

    }
}
