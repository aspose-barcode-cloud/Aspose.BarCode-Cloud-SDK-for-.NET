
using System.Text.Json.Serialization;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     PDF417 macro character mode. Mirrors https://reference.aspose.com/barcode/net/aspose.barcode.generation/macrocharacter/
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MacroCharacter
    {
        /// <summary>
        ///     Enum value None
        /// </summary>
        None,

        /// <summary>
        ///     Enum value Macro05
        /// </summary>
        Macro05,

        /// <summary>
        ///     Enum value Macro06
        /// </summary>
        Macro06

    }
}
