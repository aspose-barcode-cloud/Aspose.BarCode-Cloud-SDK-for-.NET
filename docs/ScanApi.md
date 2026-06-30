# Aspose.BarCode.Cloud.Sdk.Api.ScanApi

All URIs are relative to *<https://api.aspose.cloud/v4.0>*

Method | HTTP request | Description
------ | ------------ | -----------
[**Scan**](ScanApi.md#scan) | **GET** /barcode/scan | Scan a barcode from a file on an Internet server using a GET request with a query string parameter. For scanning files from your hard drive, use &#x60;scan-body&#x60; or &#x60;scan-multipart&#x60; endpoints instead.
[**ScanBase64**](ScanApi.md#scanbase64) | **POST** /barcode/scan-body | Scan a barcode from a file in the request body using a POST request with a JSON or XML body parameter.
[**ScanMultipart**](ScanApi.md#scanmultipart) | **POST** /barcode/scan-multipart | Scan a barcode from a file in the request body using a POST request with a multipart form parameter.


## **Scan**

```csharp
BarcodeResponseList Scan (string fileUrl)
```

Scan a barcode from a file on an Internet server using a GET request with a query string parameter. For scanning files from your hard drive, use `scan-body` or `scan-multipart` endpoints instead.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **fileUrl** | **string**| URL to the barcode image. |

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml


## **ScanBase64**

```csharp
BarcodeResponseList ScanBase64 (ScanBase64Request scanBase64Request)
```

Scan a barcode from a file in the request body using a POST request with a JSON or XML body parameter.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **scanBase64Request** | [**ScanBase64Request**](ScanBase64Request.md)| Barcode scan request. |

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### HTTP request headers

- **Content-Type**: application/json, application/xml
- **Accept**: application/json, application/xml


## **ScanMultipart**

```csharp
BarcodeResponseList ScanMultipart (System.IO.Stream file)
```

Scan a barcode from a file in the request body using a POST request with a multipart form parameter.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **file** | **System.IO.Stream****System.IO.Stream**| Barcode image file. |

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: application/json, application/xml

