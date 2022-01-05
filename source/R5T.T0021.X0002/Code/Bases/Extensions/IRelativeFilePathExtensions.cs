using System;

using R5T.T0021;
using R5T.T0021.X0002;


namespace System
{
    public static class IRelativeFilePathExtensions
    {
        #region Windows

        public static string WindowsFile01ToWindowsFile02Path(this IRelativeFilePath _)
        {
            return RelativeFilePaths.WindowsFile01ToWindowsFile02Path;
        }

        public static string WindowsFile01ToWindowsFile03Path(this IRelativeFilePath _)
        {
            return RelativeFilePaths.WindowsFile01ToWindowsFile03Path;
        }

        public static string WindowsFile01ToWindowsFile04Path(this IRelativeFilePath _)
        {
            return RelativeFilePaths.WindowsFile01ToWindowsFile04Path;
        }

        public static string WindowsFile01ToWindowsFile05Path(this IRelativeFilePath _)
        {
            return RelativeFilePaths.WindowsFile01ToWindowsFile05Path;
        }

        public static string WindowsFile01ToWindowsFile06Path(this IRelativeFilePath _)
        {
            return RelativeFilePaths.WindowsFile01ToWindowsFile06Path;
        }

        public static string WindowsFile04ToWindowsFile01Path(this IRelativeFilePath _)
        {
            return RelativeFilePaths.WindowsFile04ToWindowsFile01Path;
        }

        public static string WindowsFile01ToWindowsDirectory01Path(this IRelativeFilePath _)
        {
            return RelativeFilePaths.WindowsFile01ToWindowsDirectory01Path;
        }

        public static string WindowsFile01ToWindowsDirectory02Path(this IRelativeFilePath _)
        {
            return RelativeFilePaths.WindowsFile01ToWindowsDirectory02Path;
        }

        public static string WindowsFile01ToWindowsDirectory03Path(this IRelativeFilePath _)
        {
            return RelativeFilePaths.WindowsFile01ToWindowsDirectory03Path;
        }

        #endregion
    }
}
