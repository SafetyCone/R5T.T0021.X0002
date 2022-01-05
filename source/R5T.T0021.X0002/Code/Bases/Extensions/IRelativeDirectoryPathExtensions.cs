using System;

using R5T.T0021;
using R5T.T0021.X0002;


namespace System
{
    public static class IRelativeDirectoryPathExtensions
    {
        #region Windows

        public static string WindowsDirectory01ToWindowsDirectory02Path(this IRelativeDirectoryPath _)
        {
            return RelativeDirectoryPaths.WindowsDirectory01ToWindowsDirectory02Path;
        }

        public static string WindowsDirectory02ToWindowsDirectory04Path(this IRelativeDirectoryPath _)
        {
            return RelativeDirectoryPaths.WindowsDirectory02ToWindowsDirectory04Path;
        }

        public static string WindowsDirectory04ToWindowsFile01Path(this IRelativeDirectoryPath _)
        {
            return RelativeDirectoryPaths.WindowsDirectory04ToWindowsFile01Path;
        }

        #endregion
    }
}
