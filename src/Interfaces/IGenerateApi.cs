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




























        /// <param name="barcodeImageParams">Grouped parameters of type BarcodeImageParams</param>
        /// <param name="qrParams">Grouped parameters of type QrParams</param>
        /// <param name="code128Params">Grouped parameters of type Code128Params</param>
        /// <param name="pdf417Params">Grouped parameters of type Pdf417Params</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        Task<System.IO.Stream> GenerateAsync(EncodeBarcodeType barcodeType, string data, EncodeDataType? dataType = default, BarcodeImageParams barcodeImageParams = default, QrParams qrParams = default, Code128Params code128Params = default, Pdf417Params pdf417Params = default, System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="barcodeType">See https://reference.aspose.com/barcode/net/aspose.barcode.generation/encodetypes/</param>
        /// <param name="data">String that represents the data to encode.</param>
        /// <param name="dataType">Type of data to encode. Default value: StringData.</param>




























        /// <param name="barcodeImageParams">Grouped parameters of type BarcodeImageParams</param>
        /// <param name="qrParams">Grouped parameters of type QrParams</param>
        /// <param name="code128Params">Grouped parameters of type Code128Params</param>
        /// <param name="pdf417Params">Grouped parameters of type Pdf417Params</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        Task<System.IO.Stream> GenerateMultipartAsync(EncodeBarcodeType barcodeType, string data, EncodeDataType? dataType = default, BarcodeImageParams barcodeImageParams = default, QrParams qrParams = default, Code128Params code128Params = default, Pdf417Params pdf417Params = default, System.Threading.CancellationToken cancellationToken = default);
    }
}
