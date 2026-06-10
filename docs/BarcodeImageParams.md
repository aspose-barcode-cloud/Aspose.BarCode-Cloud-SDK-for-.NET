# Aspose.BarCode.Cloud.Sdk.Model.BarcodeImageParams

Optional barcode image parameters.

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**ImageFormat** | **BarcodeImageFormat** |  | [optional]
**TextLocation** | **CodeLocation** |  | [optional]
**ForegroundColor** | **string** | Specify the display color for bars and content. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value starting with #. For example: AliceBlue or #FF000000. Default value: Black. | [optional] [default to "Black"]
**BackgroundColor** | **string** | Background color of the barcode image. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value starting with #. For example: AliceBlue or #FF000000. Default value: White. | [optional] [default to "White"]
**Units** | **GraphicsUnit** |  | [optional]
**Resolution** | **float?** | Resolution of the barcode image. One value for both dimensions. Default value: 96 dpi. Decimal separator is a dot. | [optional]
**ImageHeight** | **float?** | Height of the barcode image in the specified units. Default units: pixels. Decimal separator is a dot. | [optional]
**ImageWidth** | **float?** | Width of the barcode image in the specified units. Default units: pixels. Decimal separator is a dot. | [optional]
**RotationAngle** | **int?** | Barcode image rotation angle, measured in degrees. For example, RotationAngle &#x3D; 0 or RotationAngle &#x3D; 360 means no rotation. If RotationAngle is not equal to 90, 180, 270, or 0, it may increase the difficulty for the scanner to read the image. Default value: 0. | [optional]
