# Aspose.BarCode.Cloud.Sdk.Api.RecognizeApi

All URIs are relative to *<https://api.aspose.cloud/v4.0>*

Method | HTTP request | Description
------ | ------------ | -----------
[**Recognize**](RecognizeApi.md#recognize) | **GET** /barcode/recognize | Recognize a barcode from a file on an Internet server using a GET request with a query string parameter. For recognizing files from your hard drive, use &#x60;recognize-body&#x60; or &#x60;recognize-multipart&#x60; endpoints instead.
[**RecognizeBase64**](RecognizeApi.md#recognizebase64) | **POST** /barcode/recognize-body | Recognize a barcode from a file in the request body using a POST request with JSON or XML body parameters.
[**RecognizeMultipart**](RecognizeApi.md#recognizemultipart) | **POST** /barcode/recognize-multipart | Recognize a barcode from a file in the request body using a POST request with multipart form parameters.


## **Recognize**

```csharp
BarcodeResponseList Recognize (DecodeBarcodeType barcodeType, string fileUrl, RecognitionMode? recognitionMode = null, RecognitionImageKind? recognitionImageKind = null)
```

Recognize a barcode from a file on an Internet server using a GET request with a query string parameter. For recognizing files from your hard drive, use `recognize-body` or `recognize-multipart` endpoints instead.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **barcodeType** | **DecodeBarcodeType**| Type of barcode to recognize. |
 **fileUrl** | **string**| URL to the barcode image. |
 **recognitionMode** | **RecognitionMode?**| Recognition mode. | [optional]
 **recognitionImageKind** | **RecognitionImageKind?**| Image kind for recognition. | [optional]

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml


## **RecognizeBase64**

```csharp
BarcodeResponseList RecognizeBase64 (RecognizeBase64Request recognizeBase64Request)
```

Recognize a barcode from a file in the request body using a POST request with JSON or XML body parameters.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **recognizeBase64Request** | [**RecognizeBase64Request**](RecognizeBase64Request.md)| Barcode recognition request. |

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### HTTP request headers

- **Content-Type**: application/json, application/xml
- **Accept**: application/json, application/xml


## **RecognizeMultipart**

```csharp
BarcodeResponseList RecognizeMultipart (DecodeBarcodeType barcodeType, System.IO.Stream file, RecognitionMode? recognitionMode = null, RecognitionImageKind? recognitionImageKind = null)
```

Recognize a barcode from a file in the request body using a POST request with multipart form parameters.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **barcodeType** | **DecodeBarcodeType**|  |
 **file** | **System.IO.Stream****System.IO.Stream**| Barcode image file. |
 **recognitionMode** | **RecognitionMode?**|  | [optional]
 **recognitionImageKind** | **RecognitionImageKind?**|  | [optional]

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: application/json, application/xml

