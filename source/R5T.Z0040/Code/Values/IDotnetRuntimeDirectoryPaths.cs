using System;

using R5T.T0131;
using R5T.T0180;
using R5T.T0180.Extensions;


namespace R5T.Z0040
{
    [ValuesMarker]
    public partial interface IDotnetRuntimeDirectoryPaths : IValuesMarker
    {
        public IDirectoryPath NetCoreApp_RuntimesDirectoryPath => @"C:\Program Files\dotnet\shared\Microsoft.NETCore.App\".ToDirectoryPath();
        public IDirectoryPath AspNetCoreApp_RuntimesDirectoryPath => @"C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App\".ToDirectoryPath();
        public IDirectoryPath WindowsDesktopApp_RuntimesDirectoryPath => @"C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App\".ToDirectoryPath();
    }
}
