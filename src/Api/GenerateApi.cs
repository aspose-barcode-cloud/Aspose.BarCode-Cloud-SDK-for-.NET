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
        /// <param name="barcodeImageParams">Grouped parameters of type BarcodeImageParams (optional)</param>
        /// <param name="qrParams">Grouped parameters of type QrParams (optional)</param>
        /// <param name="code128Params">Grouped parameters of type Code128Params (optional)</param>
        /// <param name="pdf417Params">Grouped parameters of type Pdf417Params (optional)</param>
        /// <param name="cancellationToken"></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="System.IO.Stream" />
        /// </returns>
        public async Task<System.IO.Stream> GenerateAsync(EncodeBarcodeType barcodeType, string data, EncodeDataType? dataType = default, BarcodeImageParams barcodeImageParams = default, QrParams qrParams = default, Code128Params code128Params = default, Pdf417Params pdf417Params = default, System.Threading.CancellationToken cancellationToken = default)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageFormat", barcodeImageParams?.ImageFormat);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "textLocation", barcodeImageParams?.TextLocation);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "foregroundColor", barcodeImageParams?.ForegroundColor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "backgroundColor", barcodeImageParams?.BackgroundColor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "units", barcodeImageParams?.Units);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolution", barcodeImageParams?.Resolution);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageHeight", barcodeImageParams?.ImageHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageWidth", barcodeImageParams?.ImageWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotationAngle", barcodeImageParams?.RotationAngle);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "qrEncodeMode", qrParams?.QrEncodeMode);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "qrErrorLevel", qrParams?.QrErrorLevel);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "qrVersion", qrParams?.QrVersion);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "qrECIEncoding", qrParams?.QrECIEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "qrAspectRatio", qrParams?.QrAspectRatio);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "microQRVersion", qrParams?.MicroQRVersion);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectMicroQrVersion", qrParams?.RectMicroQrVersion);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "code128EncodeMode", code128Params?.Code128EncodeMode);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417EncodeMode", pdf417Params?.Pdf417EncodeMode);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417ErrorLevel", pdf417Params?.Pdf417ErrorLevel);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417Truncate", pdf417Params?.Pdf417Truncate);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417Columns", pdf417Params?.Pdf417Columns);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417Rows", pdf417Params?.Pdf417Rows);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417AspectRatio", pdf417Params?.Pdf417AspectRatio);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417ECIEncoding", pdf417Params?.Pdf417ECIEncoding);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417IsReaderInitialization", pdf417Params?.Pdf417IsReaderInitialization);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417MacroCharacters", pdf417Params?.Pdf417MacroCharacters);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417IsLinked", pdf417Params?.Pdf417IsLinked);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pdf417IsCode128Emulation", pdf417Params?.Pdf417IsCode128Emulation);
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
        /// <param name="barcodeType">See https://reference.aspose.com/barcode/net/aspose.barcode.generation/encodetypes/</param>
        /// <param name="data">String that represents the data to encode.</param>
        /// <param name="dataType">Type of data to encode. Default value: StringData. (optional)</param>
        /// <param name="barcodeImageParams">Grouped parameters of type BarcodeImageParams (optional)</param>
        /// <param name="qrParams">Grouped parameters of type QrParams (optional)</param>
        /// <param name="code128Params">Grouped parameters of type Code128Params (optional)</param>
        /// <param name="pdf417Params">Grouped parameters of type Pdf417Params (optional)</param>
        /// <param name="cancellationToken"></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="System.IO.Stream" />
        /// </returns>
        public async Task<System.IO.Stream> GenerateMultipartAsync(EncodeBarcodeType barcodeType, string data, EncodeDataType? dataType = default, BarcodeImageParams barcodeImageParams = default, QrParams qrParams = default, Code128Params code128Params = default, Pdf417Params pdf417Params = default, System.Threading.CancellationToken cancellationToken = default)
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
            if (barcodeImageParams?.ImageFormat != null)
            {
                multipartContent.Add(new StringContent($"{barcodeImageParams?.ImageFormat}"), "imageFormat");
            }
            if (barcodeImageParams?.TextLocation != null)
            {
                multipartContent.Add(new StringContent($"{barcodeImageParams?.TextLocation}"), "textLocation");
            }
            if (barcodeImageParams?.ForegroundColor != null)
            {
                multipartContent.Add(new StringContent($"{barcodeImageParams?.ForegroundColor}"), "foregroundColor");
            }
            if (barcodeImageParams?.BackgroundColor != null)
            {
                multipartContent.Add(new StringContent($"{barcodeImageParams?.BackgroundColor}"), "backgroundColor");
            }
            if (barcodeImageParams?.Units != null)
            {
                multipartContent.Add(new StringContent($"{barcodeImageParams?.Units}"), "units");
            }
            if (barcodeImageParams?.Resolution != null)
            {
                multipartContent.Add(new StringContent($"{barcodeImageParams?.Resolution}"), "resolution");
            }
            if (barcodeImageParams?.ImageHeight != null)
            {
                multipartContent.Add(new StringContent($"{barcodeImageParams?.ImageHeight}"), "imageHeight");
            }
            if (barcodeImageParams?.ImageWidth != null)
            {
                multipartContent.Add(new StringContent($"{barcodeImageParams?.ImageWidth}"), "imageWidth");
            }
            if (barcodeImageParams?.RotationAngle != null)
            {
                multipartContent.Add(new StringContent($"{barcodeImageParams?.RotationAngle}"), "rotationAngle");
            }
            if (qrParams?.QrEncodeMode != null)
            {
                multipartContent.Add(new StringContent($"{qrParams?.QrEncodeMode}"), "qrEncodeMode");
            }
            if (qrParams?.QrErrorLevel != null)
            {
                multipartContent.Add(new StringContent($"{qrParams?.QrErrorLevel}"), "qrErrorLevel");
            }
            if (qrParams?.QrVersion != null)
            {
                multipartContent.Add(new StringContent($"{qrParams?.QrVersion}"), "qrVersion");
            }
            if (qrParams?.QrECIEncoding != null)
            {
                multipartContent.Add(new StringContent($"{qrParams?.QrECIEncoding}"), "qrECIEncoding");
            }
            if (qrParams?.QrAspectRatio != null)
            {
                multipartContent.Add(new StringContent($"{qrParams?.QrAspectRatio}"), "qrAspectRatio");
            }
            if (qrParams?.MicroQRVersion != null)
            {
                multipartContent.Add(new StringContent($"{qrParams?.MicroQRVersion}"), "microQRVersion");
            }
            if (qrParams?.RectMicroQrVersion != null)
            {
                multipartContent.Add(new StringContent($"{qrParams?.RectMicroQrVersion}"), "rectMicroQrVersion");
            }
            if (code128Params?.Code128EncodeMode != null)
            {
                multipartContent.Add(new StringContent($"{code128Params?.Code128EncodeMode}"), "code128EncodeMode");
            }
            if (pdf417Params?.Pdf417EncodeMode != null)
            {
                multipartContent.Add(new StringContent($"{pdf417Params?.Pdf417EncodeMode}"), "pdf417EncodeMode");
            }
            if (pdf417Params?.Pdf417ErrorLevel != null)
            {
                multipartContent.Add(new StringContent($"{pdf417Params?.Pdf417ErrorLevel}"), "pdf417ErrorLevel");
            }
            if (pdf417Params?.Pdf417Truncate != null)
            {
                multipartContent.Add(new StringContent($"{pdf417Params?.Pdf417Truncate}"), "pdf417Truncate");
            }
            if (pdf417Params?.Pdf417Columns != null)
            {
                multipartContent.Add(new StringContent($"{pdf417Params?.Pdf417Columns}"), "pdf417Columns");
            }
            if (pdf417Params?.Pdf417Rows != null)
            {
                multipartContent.Add(new StringContent($"{pdf417Params?.Pdf417Rows}"), "pdf417Rows");
            }
            if (pdf417Params?.Pdf417AspectRatio != null)
            {
                multipartContent.Add(new StringContent($"{pdf417Params?.Pdf417AspectRatio}"), "pdf417AspectRatio");
            }
            if (pdf417Params?.Pdf417ECIEncoding != null)
            {
                multipartContent.Add(new StringContent($"{pdf417Params?.Pdf417ECIEncoding}"), "pdf417ECIEncoding");
            }
            if (pdf417Params?.Pdf417IsReaderInitialization != null)
            {
                multipartContent.Add(new StringContent($"{pdf417Params?.Pdf417IsReaderInitialization}"), "pdf417IsReaderInitialization");
            }
            if (pdf417Params?.Pdf417MacroCharacters != null)
            {
                multipartContent.Add(new StringContent($"{pdf417Params?.Pdf417MacroCharacters}"), "pdf417MacroCharacters");
            }
            if (pdf417Params?.Pdf417IsLinked != null)
            {
                multipartContent.Add(new StringContent($"{pdf417Params?.Pdf417IsLinked}"), "pdf417IsLinked");
            }
            if (pdf417Params?.Pdf417IsCode128Emulation != null)
            {
                multipartContent.Add(new StringContent($"{pdf417Params?.Pdf417IsCode128Emulation}"), "pdf417IsCode128Emulation");
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
