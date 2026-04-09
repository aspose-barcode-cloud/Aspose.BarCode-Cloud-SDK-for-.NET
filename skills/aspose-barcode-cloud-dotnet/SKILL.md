---
name: aspose-barcode-cloud-dotnet
description: Write or update C#/.NET code that uses the Aspose.BarCode Cloud SDK (`Aspose.BarCode.Cloud.Sdk.*` namespaces; NuGet package `Aspose.BarCode-Cloud`) to generate, recognize, or scan barcodes through Aspose's cloud REST API. Use this skill whenever the user wants barcode work in C#/.NET, touches files under `submodules/dotnet`, or mentions `GenerateApi`, `RecognizeApi`, `ScanApi`, `Configuration`, `GenerateParams`, `RecognizeBase64Request`, or `ScanBase64Request`. The SDK has several easy-to-miss idioms - `Stream` return values, `JwtToken` switching auth mode, GET methods requiring a public `fileUrl`, `RecognizeBase64Async`/`ScanBase64Async` naming, and the `(clientSecret, clientId)` convenience-constructor order - so consult this skill instead of guessing.
---

# Aspose.BarCode Cloud SDK for .NET

The .NET SDK is a thin generated client over the Aspose BarCode Cloud REST API. Most tasks boil down to choosing the right API class (`GenerateApi`, `RecognizeApi`, `ScanApi`), choosing the right transport variant (GET, body/base64, or multipart), and setting up `Configuration` correctly.

The NuGet package name and code namespaces differ. Install `Aspose.BarCode-Cloud`, then import namespaces under `Aspose.BarCode.Cloud.Sdk.*`.

## Quick start

Use these namespaces in most C# examples:

```csharp
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Model;
```

Prefer constructing APIs from a `Configuration` instance:

```csharp
var config = new Configuration
{
    ClientId = clientId,
    ClientSecret = clientSecret
};

var generateApi = new GenerateApi(config);
var recognizeApi = new RecognizeApi(config);
var scanApi = new ScanApi(config);
```

If the task is repo maintenance inside `submodules/dotnet`, read `references/repo-workflow.md`. If the task needs style-matching examples or snippet locations, read `references/snippet-map.md`.

## Authentication

Use one of these two patterns:

1. Let the SDK fetch JWT tokens for you.

```csharp
var config = new Configuration
{
    ClientId = clientId,
    ClientSecret = clientSecret
};
```

2. Inject a pre-fetched bearer token.

```csharp
var config = new Configuration
{
    JwtToken = token
};
```

Setting `Configuration.JwtToken` changes `AuthType` from JWT to external bearer-token mode. Do not also expect `ClientId` and `ClientSecret` to be used after that.

Prefer `new GenerateApi(config)` and the equivalent `RecognizeApi`/`ScanApi` constructors. Convenience constructors exist, but their parameter order is `new GenerateApi(clientSecret, clientId)` and the same pattern applies to the other API classes. That order is easy to reverse, so avoid it unless there is a strong reason.

Inside this repo, `TestsBase` populates `Configuration` from `Tests/Configuration.json` or `TEST_CONFIGURATION_*` environment variables. Examples use `TEST_CONFIGURATION_JWT_TOKEN`; many snippets still use `TEST_CONFIGURATION_ACCESS_TOKEN`. Treat `Configuration.JwtToken` as the stable API surface and mirror the surrounding file when editing existing examples.

## Choose the right API shape

Pick the operation first:

- `GenerateApi`: create a barcode image.
- `RecognizeApi`: decode a known or limited set of barcode types and optionally tune recognition.
- `ScanApi`: auto-detect any barcode types with the smallest API surface.

Then pick the transport variant based on what the user has:

- Public internet URL to an image: use `RecognizeAsync` or `ScanAsync`. The `fileUrl` must be a public URL, not a local path.
- Local file or stream: use `RecognizeMultipartAsync` or `ScanMultipartAsync`.
- Raw bytes already in memory: base64-encode them yourself and use `RecognizeBase64Async` or `ScanBase64Async`.
- Small text plus simple query parameters for barcode generation: use `GenerateAsync`.
- Structured generate payload or larger data: use `GenerateBodyAsync`.
- Multipart form generation: use `GenerateMultipartAsync` when the caller explicitly needs multipart.

Key method names:

- `GenerateAsync`
- `GenerateBodyAsync`
- `GenerateMultipartAsync`
- `RecognizeAsync`
- `RecognizeBase64Async`
- `RecognizeMultipartAsync`
- `ScanAsync`
- `ScanBase64Async`
- `ScanMultipartAsync`

## Non-obvious SDK rules

1. `GenerateAsync`, `GenerateBodyAsync`, and `GenerateMultipartAsync` return `Stream`, not `byte[]` or a file path. Save the stream or pass it onward, and dispose it with `using` or `await using`.
2. `RecognizeBase64Async` and `ScanBase64Async` expect a base64 string in the request model. The SDK does not call `Convert.ToBase64String` for you.
3. `RecognizeBase64Request.BarcodeTypes` accepts multiple `DecodeBarcodeType` values. `RecognizeAsync` and `RecognizeMultipartAsync` take a single `DecodeBarcodeType`.
4. `ScanApi` does not take a barcode type or recognition-quality knobs. Use it when the caller wants auto-detection.
5. GET-based recognize and scan methods only work with remote files reachable by URL. For local files on disk, do not pass a local path to `fileUrl`; use multipart or base64.
6. `BarcodeResponseList` may contain multiple results. Iterate `response.Barcodes` and read `BarcodeValue`, `Type`, `Region`, and `Checksum`.
7. API failures throw `Aspose.BarCode.Cloud.Sdk.Api.ApiException` with an `ErrorCode` HTTP status. Turn on `Configuration.DebugMode = true` when request or response logging would help.
8. The repo has a tested end-to-end pattern where a generated `Stream` is passed directly into `ScanMultipartAsync` without saving to disk first. Reuse that pattern when it fits.

## Common patterns

Generate and save a QR code:

```csharp
var config = new Configuration { ClientId = clientId, ClientSecret = clientSecret };
var api = new GenerateApi(config);

await using Stream generated = await api.GenerateAsync(
    EncodeBarcodeType.QR,
    "hello from .NET",
    imageFormat: BarcodeImageFormat.Png,
    textLocation: CodeLocation.None);

await using FileStream file = File.Create("qr.png");
await generated.CopyToAsync(file);
```

Recognize specific barcode types from bytes already in memory:

```csharp
var bytes = await File.ReadAllBytesAsync("many-types.png");
var request = new RecognizeBase64Request
{
    BarcodeTypes = new List<DecodeBarcodeType>
    {
        DecodeBarcodeType.QR,
        DecodeBarcodeType.Code128
    },
    FileBase64 = Convert.ToBase64String(bytes)
};

BarcodeResponseList result = await new RecognizeApi(config).RecognizeBase64Async(request);
```

Auto-scan a local stream without specifying the barcode type:

```csharp
await using Stream image = File.OpenRead("unknown.png");
BarcodeResponseList result = await new ScanApi(config).ScanMultipartAsync(image);
```

## Working in this repo

Read `references/repo-workflow.md` when the task changes SDK source, tests, snippets, package metadata, or generated code in `submodules/dotnet`.

Read `references/snippet-map.md` when the task needs example code, README-aligned snippets, or the closest existing pattern for a generate, recognize, or scan scenario.

## Final checklist

1. Use the right package and namespace pair: NuGet `Aspose.BarCode-Cloud`, namespaces `Aspose.BarCode.Cloud.Sdk.*`.
2. Prefer `Configuration`-based construction and avoid swapping `clientSecret` and `clientId`.
3. Choose GET only for public URLs, multipart for local streams, and base64 or body variants for bytes or structured payloads.
4. Base64-encode body payloads yourself before calling `RecognizeBase64Async` or `ScanBase64Async`.
5. Dispose generated or opened streams.
6. Iterate `response.Barcodes` instead of assuming a single result.
7. When changing the repo, validate with the submodule workflow in `references/repo-workflow.md`.
