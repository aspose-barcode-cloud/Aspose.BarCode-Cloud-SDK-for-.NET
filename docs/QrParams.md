# Aspose.BarCode.Cloud.Sdk.Model.QrParams

Optional QR barcode generation parameters. Applies to QR, GS1QR, MicroQR, and RectMicroQR barcode types.

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**QrEncodeMode** | **QREncodeMode** | QR barcode encode mode. | [optional]
**QrErrorLevel** | **QRErrorLevel** | QR barcode error correction level. | [optional]
**QrVersion** | **QRVersion** | QR barcode version. Automatically selects the smallest version that fits the data. | [optional]
**QrECIEncoding** | **ECIEncodings** | ECI encoding for QR barcode data. | [optional]
**QrAspectRatio** | **float?** | QR barcode aspect ratio. Values: 0 to 1. | [optional]
**MicroQRVersion** | **MicroQRVersion** | MicroQR barcode version. Used when BarcodeType is MicroQR. | [optional]
**RectMicroQrVersion** | **RectMicroQRVersion** | RectMicroQR barcode version. Used when BarcodeType is RectMicroQR. | [optional]
