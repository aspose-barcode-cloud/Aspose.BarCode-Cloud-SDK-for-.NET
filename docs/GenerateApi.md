# Aspose.BarCode.Cloud.Sdk.Api.GenerateApi

All URIs are relative to *<https://api.aspose.cloud/v4.0>*

Method | HTTP request | Description
------ | ------------ | -----------
[**Generate**](GenerateApi.md#generate) | **GET** /barcode/generate/{barcodeType} | Generate a barcode using a GET request with parameters in the route and query string.
[**GenerateBody**](GenerateApi.md#generatebody) | **POST** /barcode/generate-body | Generate a barcode using a POST request with parameters in the request body in JSON or XML format.
[**GenerateMultipart**](GenerateApi.md#generatemultipart) | **POST** /barcode/generate-multipart | Generate a barcode using a POST request with parameters in a multipart form.


## **Generate**

```csharp
System.IO.Stream Generate (EncodeBarcodeType barcodeType, string data, EncodeDataType? dataType = null, BarcodeImageFormat? imageFormat = null, CodeLocation? textLocation = null, string foregroundColor = null, string backgroundColor = null, GraphicsUnit? units = null, float? resolution = null, float? imageHeight = null, float? imageWidth = null, int? rotationAngle = null, QREncodeMode? qrEncodeMode = null, QRErrorLevel? qrErrorLevel = null, QRVersion? qrVersion = null, ECIEncodings? qrECIEncoding = null, float? qrAspectRatio = null, MicroQRVersion? microQRVersion = null, RectMicroQRVersion? rectMicroQrVersion = null, Code128EncodeMode? code128EncodeMode = null, Pdf417EncodeMode? pdf417EncodeMode = null, Pdf417ErrorLevel? pdf417ErrorLevel = null, bool? pdf417Truncate = null, int? pdf417Columns = null, int? pdf417Rows = null, float? pdf417AspectRatio = null, ECIEncodings? pdf417ECIEncoding = null, bool? pdf417IsReaderInitialization = null, MacroCharacter? pdf417MacroCharacters = null, bool? pdf417IsLinked = null, bool? pdf417IsCode128Emulation = null)
```

Generate a barcode using a GET request with parameters in the route and query string.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **barcodeType** | **EncodeBarcodeType**| Type of barcode to generate. |
 **data** | **string**| String that represents the data to encode. |
 **dataType** | **EncodeDataType?**| Type of data to encode. Default value: StringData. | [optional]
 **imageFormat** | **BarcodeImageFormat?**| Barcode output image format. Default value: png. | [optional]
 **textLocation** | **CodeLocation?**| Specify the displayed text location. Set to CodeLocation.None to hide CodeText. Default value depends on BarcodeType: CodeLocation.Below for 1D barcodes and CodeLocation.None for 2D barcodes. | [optional]
 **foregroundColor** | **string**| Specify the display color for bars and content. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value starting with #. For example: AliceBlue or #FF000000. Default value: Black. | [optional] [default to &quot;Black&quot;]
 **backgroundColor** | **string**| Background color of the barcode image. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value starting with #. For example: AliceBlue or #FF000000. Default value: White. | [optional] [default to &quot;White&quot;]
 **units** | **GraphicsUnit?**| Common units for all measurements. Default units: pixels. | [optional]
 **resolution** | **float?**| Resolution of the barcode image. One value for both dimensions. Default value: 96 dpi. Decimal separator is a dot. | [optional]
 **imageHeight** | **float?**| Height of the barcode image in the specified units. Default units: pixels. Decimal separator is a dot. | [optional]
 **imageWidth** | **float?**| Width of the barcode image in the specified units. Default units: pixels. Decimal separator is a dot. | [optional]
 **rotationAngle** | **int?**| Barcode image rotation angle, measured in degrees. For example, RotationAngle &#x3D; 0 or RotationAngle &#x3D; 360 means no rotation. If RotationAngle is not equal to 90, 180, 270, or 0, it may increase the difficulty for the scanner to read the image. Default value: 0. | [optional]
 **qrEncodeMode** | **QREncodeMode?**| QR barcode encode mode. | [optional]
 **qrErrorLevel** | **QRErrorLevel?**| QR barcode error correction level. | [optional]
 **qrVersion** | **QRVersion?**| QR barcode version. Automatically selects the smallest version that fits the data. | [optional]
 **qrECIEncoding** | **ECIEncodings?**| ECI encoding for QR barcode data. | [optional]
 **qrAspectRatio** | **float?**| QR barcode aspect ratio. Values: 0 to 1. | [optional]
 **microQRVersion** | **MicroQRVersion?**| MicroQR barcode version. Used when BarcodeType is MicroQR. | [optional]
 **rectMicroQrVersion** | **RectMicroQRVersion?**| RectMicroQR barcode version. Used when BarcodeType is RectMicroQR. | [optional]
 **code128EncodeMode** | **Code128EncodeMode?**| Code128 barcode encode mode. Controls which Code 128 subset (A, B, C, or mix) is used. | [optional]
 **pdf417EncodeMode** | **Pdf417EncodeMode?**| PDF417 barcode encode mode. | [optional]
 **pdf417ErrorLevel** | **Pdf417ErrorLevel?**| PDF417 barcode error correction level. | [optional]
 **pdf417Truncate** | **bool?**| Whether to use truncated PDF417 format (removes right-side stop pattern). | [optional]
 **pdf417Columns** | **int?**| Number of columns in the PDF417 barcode. Values between 1 and 30. 0 for auto. | [optional]
 **pdf417Rows** | **int?**| Number of rows in the PDF417 barcode. Values between 3 and 90. 0 for automatic. | [optional]
 **pdf417AspectRatio** | **float?**| PDF417 barcode aspect ratio (height/width of the barcode module). Values are defined by the standard: 2 to 5 for MicroPdf417; 3 to 5 for Pdf417 and MacroPdf417. | [optional]
 **pdf417ECIEncoding** | **ECIEncodings?**| ECI encoding for PDF417 barcode data. | [optional]
 **pdf417IsReaderInitialization** | **bool?**| Whether the barcode is used for reader initialization (programming). | [optional]
 **pdf417MacroCharacters** | **MacroCharacter?**| Macro character to prepend (structured append). | [optional]
 **pdf417IsLinked** | **bool?**| Whether to use linked mode (for MicroPdf417). | [optional]
 **pdf417IsCode128Emulation** | **bool?**| Whether to use Code128 emulation for MicroPdf417. | [optional]

### Return type

System.IO.Stream

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/png, image/bmp, image/gif, image/jpeg, image/svg+xml, image/tiff, application/json, application/xml


## **GenerateBody**

```csharp
System.IO.Stream GenerateBody (GenerateParams generateParams)
```

Generate a barcode using a POST request with parameters in the request body in JSON or XML format.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **generateParams** | [**GenerateParams**](GenerateParams.md)| Generation parameters. |

### Return type

System.IO.Stream

### HTTP request headers

- **Content-Type**: application/json, application/xml
- **Accept**: image/png, image/bmp, image/gif, image/jpeg, image/svg+xml, image/tiff, application/json, application/xml


## **GenerateMultipart**

```csharp
System.IO.Stream GenerateMultipart (EncodeBarcodeType barcodeType, string data, EncodeDataType? dataType = null, BarcodeImageFormat? imageFormat = null, CodeLocation? textLocation = null, string foregroundColor = null, string backgroundColor = null, GraphicsUnit? units = null, float? resolution = null, float? imageHeight = null, float? imageWidth = null, int? rotationAngle = null, QREncodeMode? qrEncodeMode = null, QRErrorLevel? qrErrorLevel = null, QRVersion? qrVersion = null, ECIEncodings? qrECIEncoding = null, float? qrAspectRatio = null, MicroQRVersion? microQRVersion = null, RectMicroQRVersion? rectMicroQrVersion = null, Code128EncodeMode? code128EncodeMode = null, Pdf417EncodeMode? pdf417EncodeMode = null, Pdf417ErrorLevel? pdf417ErrorLevel = null, bool? pdf417Truncate = null, int? pdf417Columns = null, int? pdf417Rows = null, float? pdf417AspectRatio = null, ECIEncodings? pdf417ECIEncoding = null, bool? pdf417IsReaderInitialization = null, MacroCharacter? pdf417MacroCharacters = null, bool? pdf417IsLinked = null, bool? pdf417IsCode128Emulation = null)
```

Generate a barcode using a POST request with parameters in a multipart form.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **barcodeType** | **EncodeBarcodeType**|  |
 **data** | **string**| String that represents the data to encode. |
 **dataType** | **EncodeDataType?**|  | [optional]
 **imageFormat** | **BarcodeImageFormat?**|  | [optional]
 **textLocation** | **CodeLocation?**|  | [optional]
 **foregroundColor** | **string**| Specify the display color for bars and content. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value starting with #. For example: AliceBlue or #FF000000. Default value: Black. | [optional] [default to &quot;Black&quot;]
 **backgroundColor** | **string**| Background color of the barcode image. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value starting with #. For example: AliceBlue or #FF000000. Default value: White. | [optional] [default to &quot;White&quot;]
 **units** | **GraphicsUnit?**|  | [optional]
 **resolution** | **float?**| Resolution of the barcode image. One value for both dimensions. Default value: 96 dpi. Decimal separator is a dot. | [optional]
 **imageHeight** | **float?**| Height of the barcode image in the specified units. Default units: pixels. Decimal separator is a dot. | [optional]
 **imageWidth** | **float?**| Width of the barcode image in the specified units. Default units: pixels. Decimal separator is a dot. | [optional]
 **rotationAngle** | **int?**| Barcode image rotation angle, measured in degrees. For example, RotationAngle &#x3D; 0 or RotationAngle &#x3D; 360 means no rotation. If RotationAngle is not equal to 90, 180, 270, or 0, it may increase the difficulty for the scanner to read the image. Default value: 0. | [optional]
 **qrEncodeMode** | **QREncodeMode?**|  | [optional]
 **qrErrorLevel** | **QRErrorLevel?**|  | [optional]
 **qrVersion** | **QRVersion?**|  | [optional]
 **qrECIEncoding** | **ECIEncodings?**|  | [optional]
 **qrAspectRatio** | **float?**| QR barcode aspect ratio. Values: 0 to 1. | [optional]
 **microQRVersion** | **MicroQRVersion?**|  | [optional]
 **rectMicroQrVersion** | **RectMicroQRVersion?**|  | [optional]
 **code128EncodeMode** | **Code128EncodeMode?**|  | [optional]
 **pdf417EncodeMode** | **Pdf417EncodeMode?**|  | [optional]
 **pdf417ErrorLevel** | **Pdf417ErrorLevel?**|  | [optional]
 **pdf417Truncate** | **bool?**| Whether to use truncated PDF417 format (removes right-side stop pattern). | [optional]
 **pdf417Columns** | **int?**| Number of columns in the PDF417 barcode. Values between 1 and 30. 0 for auto. | [optional]
 **pdf417Rows** | **int?**| Number of rows in the PDF417 barcode. Values between 3 and 90. 0 for automatic. | [optional]
 **pdf417AspectRatio** | **float?**| PDF417 barcode aspect ratio (height/width of the barcode module). Values are defined by the standard: 2 to 5 for MicroPdf417; 3 to 5 for Pdf417 and MacroPdf417. | [optional]
 **pdf417ECIEncoding** | **ECIEncodings?**|  | [optional]
 **pdf417IsReaderInitialization** | **bool?**| Whether the barcode is used for reader initialization (programming). | [optional]
 **pdf417MacroCharacters** | **MacroCharacter?**|  | [optional]
 **pdf417IsLinked** | **bool?**| Whether to use linked mode (for MicroPdf417). | [optional]
 **pdf417IsCode128Emulation** | **bool?**| Whether to use Code128 emulation for MicroPdf417. | [optional]

### Return type

System.IO.Stream

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: image/png, image/bmp, image/gif, image/jpeg, image/svg+xml, image/tiff, application/json, application/xml

