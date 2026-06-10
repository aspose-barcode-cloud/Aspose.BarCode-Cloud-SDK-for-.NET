
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Optional barcode image parameters.
    /// </summary>
    public class BarcodeImageParams : IToString
    {
        /// <summary>
        ///     Gets or sets ImageFormat
        /// </summary>
        public BarcodeImageFormat? ImageFormat { get; set; }

        /// <summary>
        ///     Gets or sets TextLocation
        /// </summary>
        public CodeLocation? TextLocation { get; set; }

        /// <summary>
        ///     Gets or sets Units
        /// </summary>
        public GraphicsUnit? Units { get; set; }

        /// <summary>
        ///     Specify the display color for bars and content. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value starting with #. For example: AliceBlue or #FF000000. Default value: Black.
        /// </summary>
        public string ForegroundColor { get; set; }

        /// <summary>
        ///     Background color of the barcode image. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value starting with #. For example: AliceBlue or #FF000000. Default value: White.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        ///     Resolution of the barcode image. One value for both dimensions. Default value: 96 dpi. Decimal separator is a dot.
        /// </summary>
        public float? Resolution { get; set; }

        /// <summary>
        ///     Height of the barcode image in the specified units. Default units: pixels. Decimal separator is a dot.
        /// </summary>
        public float? ImageHeight { get; set; }

        /// <summary>
        ///     Width of the barcode image in the specified units. Default units: pixels. Decimal separator is a dot.
        /// </summary>
        public float? ImageWidth { get; set; }

        /// <summary>
        ///     Barcode image rotation angle, measured in degrees. For example, RotationAngle = 0 or RotationAngle = 360 means no rotation. If RotationAngle is not equal to 90, 180, 270, or 0, it may increase the difficulty for the scanner to read the image. Default value: 0.
        /// </summary>
        public int? RotationAngle { get; set; }

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
