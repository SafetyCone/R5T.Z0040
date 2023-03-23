using System;


namespace R5T.Z0040
{
    public class IDotnetMajorVersions : IIDotnetMajorVersions
    {
        #region Infrastructure

        public static IIDotnetMajorVersions Instance { get; } = new IDotnetMajorVersions();


        private IDotnetMajorVersions()
        {
        }

        #endregion
    }
}
