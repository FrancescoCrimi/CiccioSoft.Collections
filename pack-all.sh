#!/bin/bash

# pack-all.sh

# Directory di output per i pacchetti
output_dir="nupkgs"

# Elenco hardcoded dei progetti da pacchettizzare
projects=(
  "CiccioSoft/CiccioSoft.Collections/CiccioSoft.Collections.csproj"
  "CiccioSoft/CiccioSoft.Collections.Binding/CiccioSoft.Collections.Binding.csproj"
  "CiccioSoft/CiccioSoft.Collections.Observable/CiccioSoft.Collections.Observable.csproj"
  "CiccioSoft/CiccioSoft.Collections.Ciccio/CiccioSoft.Collections.Ciccio.csproj"
  "CiccioSoft/CiccioSoft.Collections.Core/CiccioSoft.Collections.Core.csproj"
)

# Crea la directory di output se non esiste
if [ ! -d "$output_dir" ]; then
  mkdir "$output_dir"
fi

for proj in "${projects[@]}"; do
  if [ -f "$proj" ]; then
    echo "Packing $proj in modalità Release..."
    dotnet pack "$proj" -c Release -o "$output_dir" /p:ContinuousIntegrationBuild=true
  else
    echo "File non trovato: $proj"
  fi
done