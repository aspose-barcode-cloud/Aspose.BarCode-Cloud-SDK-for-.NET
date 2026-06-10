
using System.Text.Json.Serialization;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Subset of https://reference.aspose.com/drawing/net/system.drawing/graphicsunit/
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GraphicsUnit
    {
        /// <summary>
        ///     Enum value Pixel
        /// </summary>
        Pixel,

        /// <summary>
        ///     Enum value Point
        /// </summary>
        Point,

        /// <summary>
        ///     Enum value Inch
        /// </summary>
        Inch,

        /// <summary>
        ///     Enum value Millimeter
        /// </summary>
        Millimeter

    }
}
