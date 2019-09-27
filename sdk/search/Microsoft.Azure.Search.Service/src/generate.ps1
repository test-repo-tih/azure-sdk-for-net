# ---------------------------------------------------------------------------------- 
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
# ---------------------------------------------------------------------------------- 

<#

.SYNOPSIS
    Powershell script that generates the C# SDK code for Microsoft.Azure.Search.Service from a Swagger spec

.DESCRIPTION
    This script:
    - fetches the config file from user/branch provided
    - Generates code based off the config file provided

.PARAMETER SpecsRepoFork
    The Rest Spec repo fork which contains the config file; the default is Azure.

.PARAMETER SpecsRepoBranch
    The Branch which contains the config file; the default is master.

#>

Param(
    [string] $SpecsRepoFork = "Azure",
    [string] $SpecsRepoBranch = "master"
)

"$PSScriptRoot\..\..\Install-BuildTools.ps1"

$generateFolder = "$PSScriptRoot\Generated"
$sharedGenerateFolder = "$PSScriptRoot\..\..\Microsoft.Azure.Search.Common\src\Generated"

Start-AutoRestCodeGeneration -ResourceProvider "search/data-plane/Microsoft.Azure.Search.Service" -AutoRestVersion "latest" -SpecsRepoFork $SpecsRepoFork -SpecsRepoBranch $SpecsRepoBranch

Write-Output "Deleting extra files and cleaning up..."

# Move any extra files generated for types that are shared between SearchServiceClient and SearchIndexClient to Common.
if (Test-Path -Path $sharedGenerateFolder)
{
    Remove-Item -Recurse -Force $sharedGenerateFolder
}

New-Item -ItemType Directory $sharedGenerateFolder
Move-Item "$generateFolder\Models\SearchRequestOptions.cs" $sharedGenerateFolder

# Delete files generated by AutoRest for enums that we want to be "extensible". x-ms-external is not respected for such types.
# TODO: Remove these deletion commands when we can get AutoRest's "extensible enum" feature to work properly.
Remove-Item -Force "$generateFolder\Models\AnalyzerName.cs"
Remove-Item -Force "$generateFolder\Models\TokenizerName.cs"
Remove-Item -Force "$generateFolder\Models\TokenFilterName.cs"
Remove-Item -Force "$generateFolder\Models\CharFilterName.cs"
Remove-Item -Force "$generateFolder\Models\RegexFlags.cs"
Remove-Item -Force "$generateFolder\Models\DataType.cs"
Remove-Item -Force "$generateFolder\Models\DataSourceType.cs"

# NOTE: THE FOLLOWING LINE SHOULD NOT BE REMOVED
# This is because NamedEntityRecognitionSkillLanguage is an obsolete type and we have customization in place
# to indicate as such. This can only be removed if the SDK version decides to get rid of the type altogether.
Remove-Item -Force "$generateFolder\Models\NamedEntityRecognitionSkillLanguage.cs"

Write-Output "Finished cleanup."
