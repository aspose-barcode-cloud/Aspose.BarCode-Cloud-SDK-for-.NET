
using System.Text.Json.Serialization;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Archive format for batch barcode generation.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BatchArchiveFormat
    {
        /// <summary>
        ///     Enum value Zip
        /// </summary>
        Zip,

        /// <summary>
        ///     Enum value Tar
        /// </summary>
        Tar,

        /// <summary>
        ///     Enum value TarGzip
        /// </summary>
        TarGzip

    }
}
