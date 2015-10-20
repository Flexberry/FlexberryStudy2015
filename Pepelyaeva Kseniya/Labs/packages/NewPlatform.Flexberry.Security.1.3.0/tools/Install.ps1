Param($installPath, $toolsPath, $package, $project)

<#
   В связи с тем, что NuGet-пакет NewPlatform.Flexberry.Security собирается под .NET 3.5,
   который не поддерживает Embedded Interop Types, а использует только PIA, то нужно 
   убедиться, что VS не установила флаг EmbedInteropTypes для ссылки на PIA (которую нельзя
   удалять из проекта, т.к. PIA нужна в папке с билдом, даже если не используется напрямую).

   https://nuget.codeplex.com/workitem/2653
   https://msdn.microsoft.com/en-us/library/ff182188.aspx
#>
$interopAssemblies = "Microsoft.Interop.Security.AzRoles", "Interop.ActiveDs";
ForEach ($assemblyName in $interopAssemblies) {
    $reference = $project.Object.References.Item($assemblyName);
    if ($reference) {
       $reference.EmbedInteropTypes = $False;
    }
}