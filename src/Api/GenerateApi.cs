// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GenerateApi.cs">
//   Copyright (c) 2026 Aspose.BarCode for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;
using Aspose.BarCode.Cloud.Sdk.Internal.RequestHandlers;
using Aspose.BarCode.Cloud.Sdk.Model;


namespace Aspose.BarCode.Cloud.Sdk.Api
{
    /// <summary>
    ///     GenerateApi
    /// </summary>
    public class GenerateApi : IGenerateApi
    {
        private readonly ApiInvoker _apiInvoker;
        private readonly Configuration _configuration;


        /// <summary>
        ///     Initializes a new instance of the <see cref="GenerateApi" /> class.
        /// </summary>
        /// <param name="configuration">Configuration settings</param>
        public GenerateApi(Configuration configuration)
        {
            _configuration = configuration;

            List<IRequestHandler> requestHandlers = new List<IRequestHandler>();
            switch (_configuration.AuthType)
            {
                case AuthType.JWT:
                    requestHandlers.Add(new JwtRequestHandler(_configuration));
                    break;
                case AuthType.ExternalAuth:
                    requestHandlers.Add(new ExternalAuthorizationRequestHandler(_configuration));
                    break;
                default:
                    throw new System.ArgumentOutOfRangeException($"Unknown AuthType={_configuration.AuthType}.");
            }

            requestHandlers.Add(new DebugLogRequestHandler(_configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            _apiInvoker = new ApiInvoker(configuration, requestHandlers);
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="GenerateApi" /> class.
        /// </summary>
        /// <param name="clientSecret">
        ///     The Client Secret.
        /// </param>
        /// <param name="clientId">
        ///     The Client Id.
        /// </param>
        public GenerateApi(string clientSecret, string clientId)
            : this(new Configuration { ClientSecret = clientSecret, ClientId = clientId })
        {
        }
        /// <summary>
        /// Generate a barcode using a GET request with parameters in the route and query string.
        /// </summary>
        /// <param name="barcodeType">Type of barcode to generate.</param>
        /// <param name="data">String that represents the data to encode.</param>
        /// <param name="dataType">Type of data to encode. Default value: StringData. (optional)</param>
        /// <param name="imageFormat">Barcode output image format. Default value: png. (optional)</param>
        /// <param name="textLocation">Specify the displayed text location. Set to CodeLocation.None to hide CodeText. Default value depends on BarcodeType: CodeLocation.Below for 1D barcodes and CodeLocation.None for 2D barcodes. (optional)</param>
        /// <param name="foregroundColor">Specify the display color for bars and content. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value starting with #. For example: AliceBlue or #FF000000. Default value: Black. (optional, default to &quot;Black&quot;)</param>
        /// <param name="backgroundColor">Background color of the barcode image. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value starting with #. For example: AliceBlue or #FF000000. Default value: White. (optional, default to &quot;White&quot;)</param>
        /// <param name="units">Common units for all measurements. Default units: pixels. (optional)</param>
        /// <param name="resolution">Resolution of the barcode image. One value for both dimensions. Default value: 96 dpi. Decimal separator is a dot. (optional)</param>
        /// <param name="imageHeight">Height of the barcode image in the specified units. Default units: pixels. Decimal separator is a dot. (optional)</param>
        /// <param name="imageWidth">Width of the barcode image in the specified units. Default units: pixels. Decimal separator is a dot. (optional)</param>
        /// <param name="rotationAngle">Barcode image rotation angle, measured in degrees. For example, RotationAngle &#x3D; 0 or RotationAngle &#x3D; 360 means no rotation. If RotationAngle is not equal to 90, 180, 270, or 0, it may increase the difficulty for the scanner to read the image. Default value: 0. (optional)</param>
        /// <param name="qrEncodeMode">QR barcode encode mode. (optional)</param>
        /// <param name="qrErrorLevel">QR barcode error correction level. (optional)</param>
        /// <param name="qrVersion">QR barcode version. Automatically selects the smallest version that fits the data. (optional)</param>
        /// <param name="qrECIEncoding">ECI encoding for QR barcode data. (optional)</param>
        /// <param name="qrAspectRatio">QR barcode aspect ratio. Values: 0 to 1. (optional)</param>
        /// <param name="microQRVersion">MicroQR barcode version. Used when BarcodeType is MicroQR. (optional)</param>
        /// <param name="rectMicroQrVersion">RectMicroQR barcode version. Used when BarcodeType is RectMicroQR. (optional)</param>
        /// <param name="code128EncodeMode">Code128 barcode encode mode. Controls which Code 128 subset (A, B, C, or mix) is used. (optional)</param>
        /// <param name="pdf417EncodeMode">PDF417 barcode encode mode. (optional)</param>
        /// <param name="pdf417ErrorLevel">PDF417 barcode error correction level. (optional)</param>
        /// <param name="pdf417Truncate">Whether to use truncated PDF417 format (removes right-side stop pattern). (optional)</param>
        /// <param name="pdf417Columns">Number of columns in the PDF417 barcode. Values between 1 and 30. 0 for auto. (optional)</param>
        /// <param name="pdf417Rows">Number of rows in the PDF417 barcode. Values between 3 and 90. 0 for automatic. (optional)</param>
        /// <param name="pdf417AspectRatio">PDF417 barcode aspect ratio (height/width of the barcode module). Values are defined by the standard: 2 to 5 for MicroPdf417; 3 to 5 for Pdf417 and MacroPdf417. (optional)</param>
        /// <param name="pdf417ECIEncoding">ECI encoding for PDF417 barcode data. (optional)</param>
        /// <param name="pdf417IsReaderInitialization">Whether the barcode is used for reader initialization (programming). (optional)</param>
        /// <param name="pdf417MacroCharacters">Macro character to prepend (structured append). (optional)</param>
        /// <param name="pdf417IsLinked">Whether to use linked mode (for MicroPdf417). (optional)</param>
        /// <param name="pdf417IsCode128Emulation">Whether to use Code128 emulation for MicroPdf417. (optional)</param>
        /// <param name="cancellationToken"></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="System.IO.Stream" />
        /// </returns>
        public async Task<System.IO.Stream> GenerateAsync(EncodeBarcodeType barcodeType, string data, EncodeDataType? dataType = default, BarcodeImageFormat? imageFormat = default, CodeLocation? textLocation = default, string foregroundColor = default, string backgroundColor = default, GraphicsUnit? units = default, float? resolution = default, float? imageHeight = default, float? imageWidth = default, int? rotationAngle = default, QREncodeMode? qrEncodeMode = default, QRErrorLevel? qrErrorLevel = default, QRVersion? qrVersion = default, ECIEncodings? qrECIEncoding = default, float? qrAspectRatio = default, MicroQRVersion? microQRVersion = default, RectMicroQRVersion? rectMicroQrVersion = default, Code128EncodeMode? code128EncodeMode = default, Pdf417EncodeMode? pdf417EncodeMode = default, Pdf417ErrorLevel? pdf417ErrorLevel = default, bool? pdf417Truncate = default, int? pdf417Columns = default, int? pdf417Rows = default, float? pdf417AspectRatio = default, ECIEncodings? pdf417ECIEncoding = default, bool? pdf417IsReaderInitialization = default, MacroCharacter? pdf417MacroCharacters = default, bool? pdf417IsLinked = default, bool? pdf417IsCode128Emulation = default, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'data' is set
            if (data == null)
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling Generate");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/generate/{barcodeType}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "barcodeType", barcodeType);
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "dataType", dataType);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "data", data);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageFormat", imageFormat);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "textLocation", textLocation);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "foregroundColor", foregroundColor);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "backgroundColor", backgroundColor);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "units", units);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolution", resolution);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageHeight", imageHeight);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageWidth", imageWidth);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotationAngle", rotationAngle);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "qrEncodeMode", qrEncodeMode);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "qrErrorLevel", qrErrorLevel);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "qrVersion", qrVersion);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "qrECIEncoding", qrECIEncoding);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "qrAspectRatio", qrAspectRatio);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "microQRVersion", microQRVersion);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectMicroQrVersion", rectMicroQrVersion);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "code128EncodeMode", code128EncodeMode);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417EncodeMode", pdf417EncodeMode);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417ErrorLevel", pdf417ErrorLevel);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417Truncate", pdf417Truncate);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417Columns", pdf417Columns);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417Rows", pdf417Rows);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417AspectRatio", pdf417AspectRatio);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417ECIEncoding", pdf417ECIEncoding);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417IsReaderInitialization", pdf417IsReaderInitialization);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417MacroCharacters", pdf417MacroCharacters);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417IsLinked", pdf417IsLinked);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417IsCode128Emulation", pdf417IsCode128Emulation);
#pragma warning restore CS0618 // Type or member is obsolete


            return await _apiInvoker.InvokeBinaryApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
        }
        /// <summary>
        /// Generate a barcode using a POST request with parameters in the request body in JSON or XML format.
        /// </summary>
        /// <param name="generateParams">Generation parameters.</param>
        /// <param name="cancellationToken"></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="System.IO.Stream" />
        /// </returns>
        public async Task<System.IO.Stream> GenerateBodyAsync(GenerateParams generateParams, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'generateParams' is set
            if (generateParams == null)
            {
                throw new ApiException(400, "Missing required parameter 'generateParams' when calling GenerateBody");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/generate-body";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            string postBody = SerializationHelper.Serialize(generateParams); // http body (model) parameter

            return await _apiInvoker.InvokeBinaryApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
        }
        /// <summary>
        /// Generate a barcode using a POST request with parameters in a multipart form.
        /// </summary>
        /// <param name="barcodeType"></param>
        /// <param name="data">String that represents the data to encode.</param>
        /// <param name="dataType"> (optional)</param>
        /// <param name="imageFormat"> (optional)</param>
        /// <param name="textLocation"> (optional)</param>
        /// <param name="foregroundColor">Specify the display color for bars and content. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value starting with #. For example: AliceBlue or #FF000000. Default value: Black. (optional, default to &quot;Black&quot;)</param>
        /// <param name="backgroundColor">Background color of the barcode image. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value starting with #. For example: AliceBlue or #FF000000. Default value: White. (optional, default to &quot;White&quot;)</param>
        /// <param name="units"> (optional)</param>
        /// <param name="resolution">Resolution of the barcode image. One value for both dimensions. Default value: 96 dpi. Decimal separator is a dot. (optional)</param>
        /// <param name="imageHeight">Height of the barcode image in the specified units. Default units: pixels. Decimal separator is a dot. (optional)</param>
        /// <param name="imageWidth">Width of the barcode image in the specified units. Default units: pixels. Decimal separator is a dot. (optional)</param>
        /// <param name="rotationAngle">Barcode image rotation angle, measured in degrees. For example, RotationAngle &#x3D; 0 or RotationAngle &#x3D; 360 means no rotation. If RotationAngle is not equal to 90, 180, 270, or 0, it may increase the difficulty for the scanner to read the image. Default value: 0. (optional)</param>
        /// <param name="qrEncodeMode"> (optional)</param>
        /// <param name="qrErrorLevel"> (optional)</param>
        /// <param name="qrVersion"> (optional)</param>
        /// <param name="qrECIEncoding"> (optional)</param>
        /// <param name="qrAspectRatio">QR barcode aspect ratio. Values: 0 to 1. (optional)</param>
        /// <param name="microQRVersion"> (optional)</param>
        /// <param name="rectMicroQrVersion"> (optional)</param>
        /// <param name="code128EncodeMode"> (optional)</param>
        /// <param name="pdf417EncodeMode"> (optional)</param>
        /// <param name="pdf417ErrorLevel"> (optional)</param>
        /// <param name="pdf417Truncate">Whether to use truncated PDF417 format (removes right-side stop pattern). (optional)</param>
        /// <param name="pdf417Columns">Number of columns in the PDF417 barcode. Values between 1 and 30. 0 for auto. (optional)</param>
        /// <param name="pdf417Rows">Number of rows in the PDF417 barcode. Values between 3 and 90. 0 for automatic. (optional)</param>
        /// <param name="pdf417AspectRatio">PDF417 barcode aspect ratio (height/width of the barcode module). Values are defined by the standard: 2 to 5 for MicroPdf417; 3 to 5 for Pdf417 and MacroPdf417. (optional)</param>
        /// <param name="pdf417ECIEncoding"> (optional)</param>
        /// <param name="pdf417IsReaderInitialization">Whether the barcode is used for reader initialization (programming). (optional)</param>
        /// <param name="pdf417MacroCharacters"> (optional)</param>
        /// <param name="pdf417IsLinked">Whether to use linked mode (for MicroPdf417). (optional)</param>
        /// <param name="pdf417IsCode128Emulation">Whether to use Code128 emulation for MicroPdf417. (optional)</param>
        /// <param name="cancellationToken"></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="System.IO.Stream" />
        /// </returns>
        public async Task<System.IO.Stream> GenerateMultipartAsync(EncodeBarcodeType barcodeType, string data, EncodeDataType? dataType = default, BarcodeImageFormat? imageFormat = default, CodeLocation? textLocation = default, string foregroundColor = default, string backgroundColor = default, GraphicsUnit? units = default, float? resolution = default, float? imageHeight = default, float? imageWidth = default, int? rotationAngle = default, QREncodeMode? qrEncodeMode = default, QRErrorLevel? qrErrorLevel = default, QRVersion? qrVersion = default, ECIEncodings? qrECIEncoding = default, float? qrAspectRatio = default, MicroQRVersion? microQRVersion = default, RectMicroQRVersion? rectMicroQrVersion = default, Code128EncodeMode? code128EncodeMode = default, Pdf417EncodeMode? pdf417EncodeMode = default, Pdf417ErrorLevel? pdf417ErrorLevel = default, bool? pdf417Truncate = default, int? pdf417Columns = default, int? pdf417Rows = default, float? pdf417AspectRatio = default, ECIEncodings? pdf417ECIEncoding = default, bool? pdf417IsReaderInitialization = default, MacroCharacter? pdf417MacroCharacters = default, bool? pdf417IsLinked = default, bool? pdf417IsCode128Emulation = default, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'data' is set
            if (data == null)
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling GenerateMultipart");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/generate-multipart";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            MultipartFormDataContent multipartContent = new MultipartFormDataContent();

            multipartContent.Add(new StringContent($"{barcodeType}"), "barcodeType");


            if (dataType != null)
            {
                multipartContent.Add(new StringContent($"{dataType}"), "dataType");
            }

            if (data != null)
            {
                multipartContent.Add(new StringContent($"{data}"), "data");
            }

            if (imageFormat != null)
            {
                multipartContent.Add(new StringContent($"{imageFormat}"), "imageFormat");
            }

            if (textLocation != null)
            {
                multipartContent.Add(new StringContent($"{textLocation}"), "textLocation");
            }

            if (foregroundColor != null)
            {
                multipartContent.Add(new StringContent($"{foregroundColor}"), "foregroundColor");
            }

            if (backgroundColor != null)
            {
                multipartContent.Add(new StringContent($"{backgroundColor}"), "backgroundColor");
            }

            if (units != null)
            {
                multipartContent.Add(new StringContent($"{units}"), "units");
            }

            if (resolution != null)
            {
                multipartContent.Add(new StringContent($"{resolution}"), "resolution");
            }

            if (imageHeight != null)
            {
                multipartContent.Add(new StringContent($"{imageHeight}"), "imageHeight");
            }

            if (imageWidth != null)
            {
                multipartContent.Add(new StringContent($"{imageWidth}"), "imageWidth");
            }

            if (rotationAngle != null)
            {
                multipartContent.Add(new StringContent($"{rotationAngle}"), "rotationAngle");
            }

            if (qrEncodeMode != null)
            {
                multipartContent.Add(new StringContent($"{qrEncodeMode}"), "qrEncodeMode");
            }

            if (qrErrorLevel != null)
            {
                multipartContent.Add(new StringContent($"{qrErrorLevel}"), "qrErrorLevel");
            }

            if (qrVersion != null)
            {
                multipartContent.Add(new StringContent($"{qrVersion}"), "qrVersion");
            }

            if (qrECIEncoding != null)
            {
                multipartContent.Add(new StringContent($"{qrECIEncoding}"), "qrECIEncoding");
            }

            if (qrAspectRatio != null)
            {
                multipartContent.Add(new StringContent($"{qrAspectRatio}"), "qrAspectRatio");
            }

            if (microQRVersion != null)
            {
                multipartContent.Add(new StringContent($"{microQRVersion}"), "microQRVersion");
            }

            if (rectMicroQrVersion != null)
            {
                multipartContent.Add(new StringContent($"{rectMicroQrVersion}"), "rectMicroQrVersion");
            }

            if (code128EncodeMode != null)
            {
                multipartContent.Add(new StringContent($"{code128EncodeMode}"), "code128EncodeMode");
            }

            if (pdf417EncodeMode != null)
            {
                multipartContent.Add(new StringContent($"{pdf417EncodeMode}"), "pdf417EncodeMode");
            }

            if (pdf417ErrorLevel != null)
            {
                multipartContent.Add(new StringContent($"{pdf417ErrorLevel}"), "pdf417ErrorLevel");
            }

            if (pdf417Truncate != null)
            {
                multipartContent.Add(new StringContent($"{pdf417Truncate}"), "pdf417Truncate");
            }

            if (pdf417Columns != null)
            {
                multipartContent.Add(new StringContent($"{pdf417Columns}"), "pdf417Columns");
            }

            if (pdf417Rows != null)
            {
                multipartContent.Add(new StringContent($"{pdf417Rows}"), "pdf417Rows");
            }

            if (pdf417AspectRatio != null)
            {
                multipartContent.Add(new StringContent($"{pdf417AspectRatio}"), "pdf417AspectRatio");
            }

            if (pdf417ECIEncoding != null)
            {
                multipartContent.Add(new StringContent($"{pdf417ECIEncoding}"), "pdf417ECIEncoding");
            }

            if (pdf417IsReaderInitialization != null)
            {
                multipartContent.Add(new StringContent($"{pdf417IsReaderInitialization}"), "pdf417IsReaderInitialization");
            }

            if (pdf417MacroCharacters != null)
            {
                multipartContent.Add(new StringContent($"{pdf417MacroCharacters}"), "pdf417MacroCharacters");
            }

            if (pdf417IsLinked != null)
            {
                multipartContent.Add(new StringContent($"{pdf417IsLinked}"), "pdf417IsLinked");
            }

            if (pdf417IsCode128Emulation != null)
            {
                multipartContent.Add(new StringContent($"{pdf417IsCode128Emulation}"), "pdf417IsCode128Emulation");
            }


            return await _apiInvoker.InvokeBinaryApiAsync(
                resourcePath,
                "POST",
                null,
                null,
                multipartContent);
        }
    }
}
