using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Model;


namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    /// <summary>
    ///     RecognizeApi interface
    /// </summary>
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRecognizeApi
    {
        /// <summary>
        /// Recognize a barcode from a file on an Internet server using a GET request with a query string parameter. For recognizing files from your hard drive, use &#x60;recognize-body&#x60; or &#x60;recognize-multipart&#x60; endpoints instead.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="Aspose.BarCode.Cloud.Sdk.Api.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcodeType">Type of barcode to recognize.</param>
        /// <param name="fileUrl">URL to the barcode image.</param>
        /// <param name="recognitionMode">Recognition mode.</param>
        /// <param name="recognitionImageKind">Image kind for recognition.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BarcodeResponseList</returns>
        Task<BarcodeResponseList> RecognizeAsync(DecodeBarcodeType barcodeType, string fileUrl, RecognitionMode? recognitionMode = default, RecognitionImageKind? recognitionImageKind = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recognize a barcode from a file in the request body using a POST request with JSON or XML body parameters.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="Aspose.BarCode.Cloud.Sdk.Api.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recognizeBase64Request">Barcode recognition request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BarcodeResponseList</returns>
        Task<BarcodeResponseList> RecognizeBase64Async(RecognizeBase64Request recognizeBase64Request, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recognize a barcode from a file in the request body using a POST request with multipart form parameters.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="Aspose.BarCode.Cloud.Sdk.Api.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcodeType">See https://reference.aspose.com/barcode/net/aspose.barcode.barcoderecognition/decodetype/</param>
        /// <param name="file">Barcode image file.</param>
        /// <param name="recognitionMode">Recognition mode.</param>
        /// <param name="recognitionImageKind">Image kind for recognition.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BarcodeResponseList</returns>
        Task<BarcodeResponseList> RecognizeMultipartAsync(DecodeBarcodeType barcodeType, System.IO.Stream file, RecognitionMode? recognitionMode = default, RecognitionImageKind? recognitionImageKind = default, System.Threading.CancellationToken cancellationToken = default);
    }
}
