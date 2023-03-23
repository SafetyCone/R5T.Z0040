using System;

using R5T.T0131;
using R5T.T0175;
using R5T.T0175.Extensions;


namespace R5T.Z0040
{
    [ValuesMarker]
    public partial interface IDotnetRuntimeDirectoryPaths : IValuesMarker
    {
        public DirectoryPath NetCoreApp_RuntimesDirectoryPath => @"C:\Program Files\dotnet\shared\Microsoft.NETCore.App\".ToDirectoryPath();
        public DirectoryPath AspNetCoreApp_RuntimesDirectoryPath => @"C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App\".ToDirectoryPath();
        public DirectoryPath WindowsDesktopApp_RuntimesDirectoryPath => @"C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App\".ToDirectoryPath();
    }
}
