#!/bin/bash
set -euo pipefail

SCRIPT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )"

tmp_readme="$(mktemp README.md.XXXXXX)"
trap 'rm -f "$tmp_readme"' EXIT

python3 "${SCRIPT_DIR}/insert-examples.py" "README.template" "$tmp_readme"
mv "$tmp_readme" "README.md"
rm -f "README.template"
trap - EXIT
