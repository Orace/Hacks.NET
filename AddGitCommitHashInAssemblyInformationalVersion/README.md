# AddGitCommitHashInAssemblyInformationalVersion
How to add the current git commit hash in AssemblyInformationalVersion

## Steps

 - Edit the .csproj
 - Find `<Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />`
 - Below, add `<Import Project=".\RELATIVE_FOLDER_TO\AddGitHash.csproj" />`
