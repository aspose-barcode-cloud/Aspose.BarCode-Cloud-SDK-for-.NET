using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Model;


namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    /// <summary>
    ///     GenerateApi interface
    /// </summary>
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGenerateApi
    {
        /// <summary>
        /// Generate a barcode using a GET request with parameters in the route and query string.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="Aspose.BarCode.Cloud.Sdk.Api.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcodeType">Type of barcode to generate.</param>
        /// <param name="data">String that represents the data to encode.</param>
        /// <param name="dataType">Type of data to encode. Default value: StringData.</param>
        /// <param name="imageFormat">Barcode output image format. Default value: png.</param>
        /// <param name="textLocation">Specify the displayed text location. Set to CodeLocation.None to hide CodeText. Default value depends on BarcodeType: CodeLocation.Below for 1D barcodes and CodeLocation.None for 2D barcodes.</param>
        /// <param name="foregroundColor">Specify the display color for bars and content. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value starting with #. For example: AliceBlue or #FF000000. Default value: Black.</param>
        /// <param name="backgroundColor">Background color of the barcode image. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value starting with #. For example: AliceBlue or #FF000000. Default value: White.</param>
        /// <param name="units">Common units for all measurements. Default units: pixels.</param>
        /// <param name="resolution">Resolution of the barcode image. One value for both dimensions. Default value: 96 dpi. Decimal separator is a dot.</param>
        /// <param name="imageHeight">Height of the barcode image in the specified units. Default units: pixels. Decimal separator is a dot.</param>
        /// <param name="imageWidth">Width of the barcode image in the specified units. Default units: pixels. Decimal separator is a dot.</param>
        /// <param name="rotationAngle">Barcode image rotation angle, measured in degrees. For example, RotationAngle &#x3D; 0 or RotationAngle &#x3D; 360 means no rotation. If RotationAngle is not equal to 90, 180, 270, or 0, it may increase the difficulty for the scanner to read the image. Default value: 0.</param>
        /// <param name="qrEncodeMode">QR barcode encode mode.</param>
        /// <param name="qrErrorLevel">QR barcode error correction level.</param>
        /// <param name="qrVersion">QR barcode version. Automatically selects the smallest version that fits the data.</param>
        /// <param name="qrECIEncoding">ECI encoding for QR barcode data.</param>
        /// <param name="qrAspectRatio">QR barcode aspect ratio. Values: 0 to 1.</param>
        /// <param name="microQRVersion">MicroQR barcode version. Used when BarcodeType is MicroQR.</param>
        /// <param name="rectMicroQrVersion">RectMicroQR barcode version. Used when BarcodeType is RectMicroQR.</param>
        /// <param name="code128EncodeMode">Code128 barcode encode mode. Controls which Code 128 subset (A, B, C, or mix) is used.</param>
        /// <param name="pdf417EncodeMode">PDF417 barcode encode mode.</param>
        /// <param name="pdf417ErrorLevel">PDF417 barcode error correction level.</param>
        /// <param name="pdf417Truncate">Whether to use truncated PDF417 format (removes right-side stop pattern).</param>
        /// <param name="pdf417Columns">Number of columns in the PDF417 barcode. Values between 1 and 30. 0 for auto.</param>
        /// <param name="pdf417Rows">Number of rows in the PDF417 barcode. Values between 3 and 90. 0 for automatic.</param>
        /// <param name="pdf417AspectRatio">PDF417 barcode aspect ratio (height/width of the barcode module). Values are defined by the standard: 2 to 5 for MicroPdf417; 3 to 5 for Pdf417 and MacroPdf417.</param>
        /// <param name="pdf417ECIEncoding">ECI encoding for PDF417 barcode data.</param>
        /// <param name="pdf417IsReaderInitialization">Whether the barcode is used for reader initialization (programming).</param>
        /// <param name="pdf417MacroCharacters">Macro character to prepend (structured append).</param>
        /// <param name="pdf417IsLinked">Whether to use linked mode (for MicroPdf417).</param>
        /// <param name="pdf417IsCode128Emulation">Whether to use Code128 emulation for MicroPdf417.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        Task<System.IO.Stream> GenerateAsync(EncodeBarcodeType barcodeType, string data, EncodeDataType? dataType = default, BarcodeImageFormat? imageFormat = default, CodeLocation? textLocation = default, string foregroundColor = default, string backgroundColor = default, GraphicsUnit? units = default, float? resolution = default, float? imageHeight = default, float? imageWidth = default, int? rotationAngle = default, QREncodeMode? qrEncodeMode = default, QRErrorLevel? qrErrorLevel = default, QRVersion? qrVersion = default, ECIEncodings? qrECIEncoding = default, float? qrAspectRatio = default, MicroQRVersion? microQRVersion = default, RectMicroQRVersion? rectMicroQrVersion = default, Code128EncodeMode? code128EncodeMode = default, Pdf417EncodeMode? pdf417EncodeMode = default, Pdf417ErrorLevel? pdf417ErrorLevel = default, bool? pdf417Truncate = default, int? pdf417Columns = default, int? pdf417Rows = default, float? pdf417AspectRatio = default, ECIEncodings? pdf417ECIEncoding = default, bool? pdf417IsReaderInitialization = default, MacroCharacter? pdf417MacroCharacters = default, bool? pdf417IsLinked = default, bool? pdf417IsCode128Emulation = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a barcode using a POST request with parameters in the request body in JSON or XML format.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="Aspose.BarCode.Cloud.Sdk.Api.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateParams">Generation parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        Task<System.IO.Stream> GenerateBodyAsync(GenerateParams generateParams, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a barcode using a POST request with parameters in a multipart form.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="Aspose.BarCode.Cloud.Sdk.Api.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcodeType"></param>
        /// <param name="data">String that represents the data to encode.</param>
        /// <param name="dataType"></param>
        /// <param name="imageFormat"></param>
        /// <param name="textLocation"></param>
        /// <param name="foregroundColor">Specify the display color for bars and content. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value starting with #. For example: AliceBlue or #FF000000. Default value: Black.</param>
        /// <param name="backgroundColor">Background color of the barcode image. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value starting with #. For example: AliceBlue or #FF000000. Default value: White.</param>
        /// <param name="units"></param>
        /// <param name="resolution">Resolution of the barcode image. One value for both dimensions. Default value: 96 dpi. Decimal separator is a dot.</param>
        /// <param name="imageHeight">Height of the barcode image in the specified units. Default units: pixels. Decimal separator is a dot.</param>
        /// <param name="imageWidth">Width of the barcode image in the specified units. Default units: pixels. Decimal separator is a dot.</param>
        /// <param name="rotationAngle">Barcode image rotation angle, measured in degrees. For example, RotationAngle &#x3D; 0 or RotationAngle &#x3D; 360 means no rotation. If RotationAngle is not equal to 90, 180, 270, or 0, it may increase the difficulty for the scanner to read the image. Default value: 0.</param>
        /// <param name="qrEncodeMode"></param>
        /// <param name="qrErrorLevel"></param>
        /// <param name="qrVersion"></param>
        /// <param name="qrECIEncoding"></param>
        /// <param name="qrAspectRatio">QR barcode aspect ratio. Values: 0 to 1.</param>
        /// <param name="microQRVersion"></param>
        /// <param name="rectMicroQrVersion"></param>
        /// <param name="code128EncodeMode"></param>
        /// <param name="pdf417EncodeMode"></param>
        /// <param name="pdf417ErrorLevel"></param>
        /// <param name="pdf417Truncate">Whether to use truncated PDF417 format (removes right-side stop pattern).</param>
        /// <param name="pdf417Columns">Number of columns in the PDF417 barcode. Values between 1 and 30. 0 for auto.</param>
        /// <param name="pdf417Rows">Number of rows in the PDF417 barcode. Values between 3 and 90. 0 for automatic.</param>
        /// <param name="pdf417AspectRatio">PDF417 barcode aspect ratio (height/width of the barcode module). Values are defined by the standard: 2 to 5 for MicroPdf417; 3 to 5 for Pdf417 and MacroPdf417.</param>
        /// <param name="pdf417ECIEncoding"></param>
        /// <param name="pdf417IsReaderInitialization">Whether the barcode is used for reader initialization (programming).</param>
        /// <param name="pdf417MacroCharacters"></param>
        /// <param name="pdf417IsLinked">Whether to use linked mode (for MicroPdf417).</param>
        /// <param name="pdf417IsCode128Emulation">Whether to use Code128 emulation for MicroPdf417.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        Task<System.IO.Stream> GenerateMultipartAsync(EncodeBarcodeType barcodeType, string data, EncodeDataType? dataType = default, BarcodeImageFormat? imageFormat = default, CodeLocation? textLocation = default, string foregroundColor = default, string backgroundColor = default, GraphicsUnit? units = default, float? resolution = default, float? imageHeight = default, float? imageWidth = default, int? rotationAngle = default, QREncodeMode? qrEncodeMode = default, QRErrorLevel? qrErrorLevel = default, QRVersion? qrVersion = default, ECIEncodings? qrECIEncoding = default, float? qrAspectRatio = default, MicroQRVersion? microQRVersion = default, RectMicroQRVersion? rectMicroQrVersion = default, Code128EncodeMode? code128EncodeMode = default, Pdf417EncodeMode? pdf417EncodeMode = default, Pdf417ErrorLevel? pdf417ErrorLevel = default, bool? pdf417Truncate = default, int? pdf417Columns = default, int? pdf417Rows = default, float? pdf417AspectRatio = default, ECIEncodings? pdf417ECIEncoding = default, bool? pdf417IsReaderInitialization = default, MacroCharacter? pdf417MacroCharacters = default, bool? pdf417IsLinked = default, bool? pdf417IsCode128Emulation = default, System.Threading.CancellationToken cancellationToken = default);
    }
}
