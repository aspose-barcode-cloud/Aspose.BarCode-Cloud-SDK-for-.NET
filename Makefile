LATEST_SDK_VERSION=$(shell dotnet --list-sdks | awk -F. '{print $$1 "." $$2}' | sort -n | tail -n 1)

.PHONY: all
all: test

.PHONY: init
init:
	dotnet tool install --global dotnet-format

.PHONY: format
format:
	dotnet restore ./Aspose.BarCode.Cloud.Sdk.sln
	dotnet format ./Aspose.BarCode.Cloud.Sdk.sln --no-restore
	dotnet format --include ./snippets/ --include ./NetFrameworkTests/
	# Trim white space in comments
	find . -iname "*.cs" -exec sed -i -e 's_[[:space:]]*$$__' {} \;


.PHONY: format-doc
format-doc:
	# Remove trailing white space
	find . -iname "*.md" -exec sed -i -e 's_[[:space:]]*$$__' {} \;
	# Trim trailing empty line
	sed -i -e '$${/^$$/d;}' README.md

.PHONY: test
test: nuget
	dotnet test -v normal --framework=net$(LATEST_SDK_VERSION)
	./scripts/run_snippets.sh

# Line coverage of the SDK library (coverlet names the report after the framework
# because the test project multi-targets); the gate (COVERAGE_THRESHOLD, default 80) is the
# shared scripts/coverage.py, which also writes coverage/coverage-{badge,summary}.json.
.PHONY: cover
cover:
	rm -rf ./coverage
	dotnet test Tests/Aspose.BarCode.Cloud.Sdk.Tests.csproj \
		--framework=net$(LATEST_SDK_VERSION) \
		/p:CollectCoverage=true \
		/p:CoverletOutputFormat=cobertura \
		/p:CoverletOutput=$(CURDIR)/coverage/ \
		'/p:Include=[Aspose.BarCode.Cloud.Sdk]*' \
		'/p:Exclude=[Aspose.BarCode.Cloud.Sdk.Tests]*' \
		'/p:ExcludeByFile=**/obj/**/*.cs'
	python3 scripts/coverage.py cobertura coverage/coverage.net$(LATEST_SDK_VERSION).cobertura.xml

.PHONY: build
build:
	dotnet build -v normal --framework=net$(LATEST_SDK_VERSION)

.PHONY: insert-examples
insert-examples:
	./scripts/insert-examples.bash

.PHONY: after-gen
after-gen: insert-examples format format-doc
	./scripts/annotate-obsolete.bash

.PHONY: update
update:
	echo "Not implemented"

.PHONY: lint
lint:
	dotnet build --warnaserror Aspose.BarCode.Cloud.Sdk.sln --framework=net$(LATEST_SDK_VERSION)

.PHONY: clean
clean:
	find . -depth -type d \( -name obj -o -name bin -o -name TestResults \) -exec rm -rf "{}" \; || true

.PHONY: nuget
nuget:
	./scripts/pack-nuget.bash
	./scripts/test-nuget.bash
