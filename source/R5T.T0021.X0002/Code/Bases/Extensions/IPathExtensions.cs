using System;

using R5T.T0021;
using R5T.T0021.X0002;


namespace System
{
    public static class IPathExtensions
    {
        public static string EmptyPath(this IPath _)
        {
            return Paths.EmptyPath;
        }

        public static string NullPath(this IPath _)
        {
            return Paths.NullPath;
        }

        public static string ResolvedPath(this IPath _)
        {
            return Instances.FilePath.WindowsFilePath01();
        }

        public static string UnresolvedPath(this IPath _)
        {
            return Instances.FilePath.WindowsFile01FromWindowsDirectory02PathUnresolved();
        }
    }
}
