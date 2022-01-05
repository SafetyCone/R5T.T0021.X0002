using System;

using R5T.T0021;
using R5T.T0021.X0002;

using Instances = R5T.T0021.X0002.Instances;


namespace System
{
    public static class IFilePathExtensions
    {
        #region Windows

        public static string WindowsFilePath01(this IFilePath _)
        {
            return FilePaths.WindowsFilePath01;
        }

        public static string WindowsFilePath02(this IFilePath _)
        {
            return FilePaths.WindowsFilePath02;
        }

        public static string WindowsFilePath03(this IFilePath _)
        {
            return FilePaths.WindowsFilePath03;
        }

        public static string WindowsFilePath04(this IFilePath _)
        {
            return FilePaths.WindowsFilePath04;
        }

        public static string WindowsFilePath05(this IFilePath _)
        {
            return FilePaths.WindowsFilePath05;
        }

        public static string WindowsFilePath06(this IFilePath _)
        {
            return FilePaths.WindowsFilePath06;
        }

        public static string WindowsFile01FromRootRelativePath(this IFilePath _)
        {
            return FilePaths.WindowsFile01FromRootRelativePath;
        }

        public static string WindowsFile01DirectoryIndicatedPath(this IFilePath _)
        {
            return FilePaths.WindowsFile01DirectoryIndicatedPath;
        }

        public static string WindowsFile01FromWindowsDirectory02PathUnresolved(this IFilePath _)
        {
            return FilePaths.WindowsFile01FromWindowsDirectory02PathUnresolved;
        }

        #endregion

        #region Non-Windows

        public static string NonWindowsFile01Path(this IFilePath _)
        {
            return FilePaths.NonWindowsFile01Path;
        }

        public static string NonWindowsFile01FromNonWindowsDirectory02PathUnresolved(this IFilePath _)
        {
            return FilePaths.NonWindowsFile01FromNonWindowsDirectory02PathUnresolved;
        }

        public static string MixedWindowsDominantFile01Path(this IFilePath _)
        {
            return FilePaths.MixedWindowsDominantFile01Path;
        }

        public static string MixedNonWindowsDominantFile01Path(this IFilePath _)
        {
            return FilePaths.MixedNonWindowsDominantFile01Path;
        }

        #endregion

        #region Parts

        public static string[] WindowsFile04PathParts(this IFilePath _)
        {
            var output = new string[]
            {
                Instances.RootPath.WindowsCDrive(),
                Instances.DirectoryName.Directory01(),
                Instances.DirectoryName.Directory02(),
                Instances.DirectoryName.Directory03(),
                Instances.FileName.File04Name()
            };

            return output;
        }

        public static string[] NonWindowsFile01PathParts(this IFilePath _)
        {
            var output = new string[]
            {
                Instances.RootPath.NonWindowsMnt(),
                Instances.DirectoryName.Directory01(),
                Instances.FileName.File01Name(),
            };

            return output;
        }

        #endregion
    }
}
