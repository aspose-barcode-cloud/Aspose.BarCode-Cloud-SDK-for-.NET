# Dotnet submodule workflow

Use this reference when the task edits SDK source, tests, snippets, package metadata, or generated files inside `submodules/dotnet`.

## Layout

- `src/Api`: public API clients, `Configuration`, and `ApiException`.
- `src/Interfaces`: public interfaces used by tests and examples.
- `src/Model`: request and response models plus enums.
- `src/Internal`: auth handlers, request pipeline, serialization, and debug logging.
- `Tests`: NUnit coverage for configuration, auth, generate, recognize, scan, and error cases.
- `snippets`: documentation snippets that are compiled and executed against the packed NuGet package.
- `examples`: small standalone sample apps such as `GenerateQR` and `ReadQR`.
- `scripts`: packaging, formatting, and snippet-runner helpers.
- `Aspose.BarCode.Cloud.Sdk.sln`: main solution entry point.

## Validation

On Windows, run repo scripts and Make targets through WSL.

From `submodules/dotnet`:

- `make build`
- `make test`
- `make lint`
- `make format`

`make test` does more than unit tests:

- runs `nuget`, which calls `./scripts/pack-nuget.bash` and `./scripts/test-nuget.bash`
- runs `dotnet test -v normal --framework=net$(LATEST_SDK_VERSION)`
- runs `./scripts/run_snippets.sh`

`run_snippets.sh` creates a temporary project, consumes the locally packed `.nupkg`, and executes every snippet. Treat snippet failures as package-consumer regressions, not just sample breakage.

## Test configuration

- Minimal JSON shape lives in `Tests/Configuration.template.json`.
- Tests load `Tests/Configuration.json` first, then fall back to `TEST_CONFIGURATION_*` environment variables.
- `TestsBase` only maps string-valued `Configuration` properties from the environment. Useful names include `TEST_CONFIGURATION_CLIENT_ID`, `TEST_CONFIGURATION_CLIENT_SECRET`, `TEST_CONFIGURATION_JWT_TOKEN`, `TEST_CONFIGURATION_API_BASE_URL`, `TEST_CONFIGURATION_TOKEN_URL`, and `TEST_CONFIGURATION_API_VERSION`.

## Regenerated code workflow

If you change generated SDK code in this mono-repo:

1. Make the desired SDK edit in `submodules/dotnet` so the target behavior is clear.
2. Mirror the change in the matching template under `codegen/Templates` when the file is generated.
3. Stage the dotnet submodule changes.
4. From the repo root, run `make dotnet`.
5. Ensure `submodules/dotnet` has no new unstaged diffs after regeneration.
6. If regeneration reintroduces old code, keep fixing templates until the generated output matches the intended SDK change.

## Useful anchors

- `src/Aspose.BarCode.Cloud.Sdk.csproj`: package metadata, package id, and target framework (`netstandard2.0`).
- `Tests/TestsBase.cs`: how repo tests construct `Configuration`.
- `snippets/Snippets.csproj`: snippet target framework and package reference.
