#!/bin/bash

# Versioni hardcoded
new_package_version="8.0.0-beta.3"
new_version="8.0.0"

# Elenco hardcoded dei progetti CiccioSoft.Collections
projects=(
  "CiccioSoft/CiccioSoft.Collections/CiccioSoft.Collections.csproj"
  "CiccioSoft/CiccioSoft.Collections.Binding/CiccioSoft.Collections.Binding.csproj"
  "CiccioSoft/CiccioSoft.Collections.Observable/CiccioSoft.Collections.Observable.csproj"
  "CiccioSoft/CiccioSoft.Collections.Ciccio/CiccioSoft.Collections.Ciccio.csproj"
)

for proj in "${projects[@]}"; do
  if [[ -f "$proj" ]]; then
    echo "Aggiorno $proj a Version $new_version e PackageVersion $new_package_version"
    # Sostituisce <Version> e <PackageVersion> con i nuovi valori
    sed -i \
      -e "s|<Version>.*</Version>|<Version>$new_version</Version>|g" \
      -e "s|<PackageVersion>.*</PackageVersion>|<PackageVersion>$new_package_version</PackageVersion>|g" \
      "$proj"
  else
    echo "File non trovato: $proj"
  fi
done