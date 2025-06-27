# set-package-version.ps1

# Versioni hardcoded
$newPackageVersion = "8.0.0-alpha.3"
$newVersion = "8.0.0"

# Elenco hardcoded dei progetti CiccioSoft.Collections
$projects = @(
    "CiccioSoft.Collections.Core\CiccioSoft.Collections.Core.csproj",
    "CiccioSoft.Collections.Binding\CiccioSoft.Collections.Binding.csproj",
    "CiccioSoft.Collections.Observable\CiccioSoft.Collections.Observable.csproj",
    "CiccioSoft.Collections.Ciccio\CiccioSoft.Collections.Ciccio.csproj",
    "CiccioSoft.Collections\CiccioSoft.Collections.csproj"
)

foreach ($proj in $projects) {
    if (Test-Path $proj) {
        Write-Host "Aggiorno $proj a Version $newVersion e PackageVersion $newPackageVersion"
        (Get-Content $proj) `
            -replace '<Version>.*?</Version>', "<Version>$newVersion</Version>" `
            -replace '<PackageVersion>.*?</PackageVersion>', "<PackageVersion>$newPackageVersion</PackageVersion>" `
            | Set-Content $proj
    } else {
        Write-Warning "File non trovato: $proj"
    }
}