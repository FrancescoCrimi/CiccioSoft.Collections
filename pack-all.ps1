# pack-all.ps1

# Directory di output per i pacchetti
$outputDir = "nupkgs"

# Elenco hardcoded dei progetti da pacchettizzare
$projects = @(
    "CiccioSoft.Collections.Core\CiccioSoft.Collections.Core.csproj",
    "CiccioSoft.Collections.Binding\CiccioSoft.Collections.Binding.csproj",
    "CiccioSoft.Collections.Observable\CiccioSoft.Collections.Observable.csproj",
    "CiccioSoft.Collections.Ciccio\CiccioSoft.Collections.Ciccio.csproj",
    "CiccioSoft.Collections\CiccioSoft.Collections.csproj"
)

# Crea la directory di output se non esiste
if (-not (Test-Path $outputDir)) {
    New-Item -ItemType Directory -Path $outputDir | Out-Null
}

foreach ($proj in $projects) {
    if (Test-Path $proj) {
        Write-Host "Packing $proj in modalità Release..."
        dotnet pack $proj -c Release -o $outputDir /p:ContinuousIntegrationBuild=true
    } else {
        Write-Warning "File non trovato: $proj"
    }
}