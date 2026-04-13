# Snippet and example map

Use this reference when you want the closest existing pattern before writing new `.NET` SDK code or when updating docs, snippets, and examples.

## Small end-user examples

- `examples/GenerateQR/Program.cs`: minimal QR generation to a local file.
- `examples/ReadQR/Program.cs`: minimal QR recognition from local file bytes.
- `snippets/ManualFetchToken.cs`: manual OAuth client-credentials token fetch without the SDK.

## Generate patterns

- `snippets/generate/save/GenerateGet.cs`: simple `GenerateAsync` and save-to-file flow.
- `snippets/generate/save/GenerateBody.cs`: `GenerateBodyAsync` with `GenerateParams`.
- `snippets/generate/save/GenerateMultipart.cs`: multipart generation flow.
- `snippets/generate/set-text/*`: `EncodeData` and `EncodeDataType` examples.
- `snippets/generate/set-size/*`: width, height, resolution, and units examples.
- `snippets/generate/set-colorscheme/*`: foreground and background color examples.
- `snippets/generate/appearance/*`: richer `BarcodeImageParams` examples.
- `snippets/generate/svg/Combine.cs`: generate SVG output and combine results.

## Recognize and scan patterns

- `snippets/read/set-source/RecognizeGet.cs`: recognize from a public URL.
- `snippets/read/set-source/RecognizeMultipart.cs`: recognize from a local stream.
- `snippets/read/set-source/RecognizeBody.cs`: recognize from base64 bytes.
- `snippets/read/set-source/ScanGet.cs`: auto-scan from a public URL.
- `snippets/read/set-source/ScanMultipart.cs`: auto-scan from a local stream.
- `snippets/read/set-source/ScanBody.cs`: auto-scan from base64 bytes.
- `snippets/read/set-target-types/*`: choosing `DecodeBarcodeType` or `List<DecodeBarcodeType>`.
- `snippets/read/set-quality/*`: `RecognitionMode` examples.
- `snippets/read/set-image-kind/*`: `RecognitionImageKind` examples.

## Tests worth copying

- `Tests/GenerateAndThenRecognize.cs`: generate a barcode stream, then scan that same stream end to end.
- `Tests/GenerateTests.cs`: generate via GET and body variants.
- `Tests/RecognizeTests.cs`: recognize via base64 body, multipart, and URL.
- `Tests/ScanTests.cs`: scan via base64 body, multipart, and URL.
- `Tests/JwtAuthTests.cs`: pre-fetched JWT token auth path.
- `Tests/ApiExceptionTests.cs`: expected failures and exception behavior.
- `Tests/ConfigurationTests.cs`: configuration defaults and property behavior.
