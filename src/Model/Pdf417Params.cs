
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Optional PDF417 barcode generation parameters. Applies to Pdf417, MacroPdf417, MicroPdf417, and GS1MicroPdf417 barcode types.
    /// </summary>
    public class Pdf417Params : IToString
    {
        /// <summary>
        ///     Gets or sets Pdf417EncodeMode
        /// </summary>
        public Pdf417EncodeMode? Pdf417EncodeMode { get; set; }

        /// <summary>
        ///     Gets or sets Pdf417ErrorLevel
        /// </summary>
        public Pdf417ErrorLevel? Pdf417ErrorLevel { get; set; }

        /// <summary>
        ///     Gets or sets Pdf417ECIEncoding
        /// </summary>
        public ECIEncodings? Pdf417ECIEncoding { get; set; }

        /// <summary>
        ///     Gets or sets Pdf417MacroCharacters
        /// </summary>
        public MacroCharacter? Pdf417MacroCharacters { get; set; }

        /// <summary>
        ///     Whether to use truncated PDF417 format (removes right-side stop pattern).
        /// </summary>
        public bool? Pdf417Truncate { get; set; }

        /// <summary>
        ///     Number of columns in the PDF417 barcode. Values between 1 and 30. 0 for auto.
        /// </summary>
        public int? Pdf417Columns { get; set; }

        /// <summary>
        ///     Number of rows in the PDF417 barcode. Values between 3 and 90. 0 for automatic.
        /// </summary>
        public int? Pdf417Rows { get; set; }

        /// <summary>
        ///     PDF417 barcode aspect ratio (height/width of the barcode module). Values are defined by the standard: 2 to 5 for MicroPdf417; 3 to 5 for Pdf417 and MacroPdf417.
        /// </summary>
        public float? Pdf417AspectRatio { get; set; }

        /// <summary>
        ///     Whether the barcode is used for reader initialization (programming).
        /// </summary>
        public bool? Pdf417IsReaderInitialization { get; set; }

        /// <summary>
        ///     Whether to use linked mode (for MicroPdf417).
        /// </summary>
        public bool? Pdf417IsLinked { get; set; }

        /// <summary>
        ///     Whether to use Code128 emulation for MicroPdf417.
        /// </summary>
        public bool? Pdf417IsCode128Emulation { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return _srcString ?? SerializationHelper.Serialize(this);
        }

        private string _srcString;
        /// <summary>
        ///   Set the string presentation of the object
        /// </summary>
        public void SetSrcString(string value)
        {
            _srcString = value;
        }
    }
}
