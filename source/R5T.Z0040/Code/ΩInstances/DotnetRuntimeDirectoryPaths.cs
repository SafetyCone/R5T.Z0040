using System;


namespace R5T.Z0040
{
    public class DotnetRuntimeDirectoryPaths : IDotnetRuntimeDirectoryPaths
    {
        #region Infrastructure

        public static IDotnetRuntimeDirectoryPaths Instance { get; } = new DotnetRuntimeDirectoryPaths();


        private DotnetRuntimeDirectoryPaths()
        {
        }

        #endregion
    }
}
