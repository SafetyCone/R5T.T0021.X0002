using System;

using R5T.T0021;
using R5T.T0021.X0002;


namespace System
{
    public static class IDirectoryPathExtensions
    {
        #region Windows

        public static string WindowsDirectoryPath01_Unindicated(this IDirectoryPath _)
        {
            return DirectoryPaths.WindowsDirectoryPath01_Unindicated;
        }

        public static string WindowsDirectoryPath01(this IDirectoryPath _)
        {
            return DirectoryPaths.WindowsDirectoryPath01;
        }

        public static string WindowsDirectoryPath02_Unindicated(this IDirectoryPath _)
        {
            return DirectoryPaths.WindowsDirectoryPath02_Unindicated;
        }

        public static string WindowsDirectoryPath02(this IDirectoryPath _)
        {
            return DirectoryPaths.WindowsDirectoryPath02;
        }

        public static string WindowsDirectoryPath03_Unindicated(this IDirectoryPath _)
        {
            return DirectoryPaths.WindowsDirectoryPath03_Unindicated;
        }

        public static string WindowsDirectoryPath03(this IDirectoryPath _)
        {
            return DirectoryPaths.WindowsDirectoryPath03;
        }

        public static string WindowsDirectoryPath04_Unindicated(this IDirectoryPath _)
        {
            return DirectoryPaths.WindowsDirectoryPath04_Unindicated;
        }

        public static string WindowsDirectoryPath04(this IDirectoryPath _)
        {
            return DirectoryPaths.WindowsDirectoryPath04;
        }

        public static string WindowsRootDirectoryPathUnindicated(this IDirectoryPath _)
        {
            return DirectoryPaths.WindowsRootDirectoryPathUnindicated;
        }

        public static string WindowsRootDirectoryPath(this IDirectoryPath _)
        {
            return DirectoryPaths.WindowsRootDirectoryPath;
        }

        public static string WindowsDirectory01FromWindowsDirectory04PathUnresolved(this IDirectoryPath _)
        {
            return DirectoryPaths.WindowsDirectory01FromWindowsDirectory04PathUnresolved;
        }

        #endregion

        #region Non-Windows

        public static string NonWindowsDirectoryPath01_Unindicated(this IDirectoryPath _)
        {
            return DirectoryPaths.NonWindowsDirectoryPath01_Unindicated;
        }

        public static string NonWindowsDirectoryPath01(this IDirectoryPath _)
        {
            return DirectoryPaths.NonWindowsDirectoryPath01;
        }

        public static string NonWindowsDirectory02PathUnindicated(this IDirectoryPath _)
        {
            return DirectoryPaths.NonWindowsDirectory02PathUnindicated;
        }

        public static string NonWindowsDirectory02Path(this IDirectoryPath _)
        {
            return DirectoryPaths.NonWindowsDirectory02Path;
        }

        public static string NonWindowsDirectory03PathUnindicated(this IDirectoryPath _)
        {
            return DirectoryPaths.NonWindowsDirectory03PathUnindicated;
        }

        public static string NonWindowsDirectory03Path(this IDirectoryPath _)
        {
            return DirectoryPaths.NonWindowsDirectory03Path;
        }

        public static string NonWindowsDirectory04PathUnindicated(this IDirectoryPath _)
        {
            return DirectoryPaths.NonWindowsDirectory04PathUnindicated;
        }

        public static string NonWindowsDirectory04Path(this IDirectoryPath _)
        {
            return DirectoryPaths.NonWindowsDirectory04Path;
        }

        public static string NonWindowsDirectory01FromNonWindowsDirectory04PathUnresolved(this IDirectoryPath _)
        {
            return DirectoryPaths.NonWindowsDirectory01FromNonWindowsDirectory04PathUnresolved;
        }

        #endregion
    }
}