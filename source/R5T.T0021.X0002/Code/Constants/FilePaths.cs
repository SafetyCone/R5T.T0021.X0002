using System;


namespace R5T.T0021.X0002
{
    /// <summary>
    /// Obsolete - See R5T.Z0066.
    /// </summary>
    public static class FilePaths
    {
        // Windows.
        public static string WindowsFilePath01 => @"C:\Directory01\File01.txt";
        public static string WindowsFilePath02 => @"C:\Directory01\File02.txt";
        public static string WindowsFilePath03 => @"C:\Directory01\Directory02\File03.txt";
        public static string WindowsFilePath04 => @"C:\Directory01\Directory02\Directory03\File04.txt";
        public static string WindowsFilePath05 => @"C:\Directory01\Directory04\File05.txt";
        public static string WindowsFilePath06 => @"C:\File06.txt";

        public static string WindowsFile01FromRootRelativePath => @"Directory01/File01.txt";

        public static string WindowsFile01DirectoryIndicatedPath => @"C:\Directory01\File01.txt\";

        public static string WindowsFile01FromWindowsDirectory02PathUnresolved => @"C:\Directory02\..\Directory01\File01.txt";


        // Non-Windows.
        public static string NonWindowsFile01Path => @"/mnt/Directory01/File01.txt";

        public static string NonWindowsFile01FromNonWindowsDirectory02PathUnresolved => @"/mnt/Directory02/../Directory01/File01.txt";

        // Mixed.
        public static string MixedWindowsDominantFile01Path => @"C:\Directory01/File01.txt";

        public static string MixedNonWindowsDominantFile01Path => @"/mnt\Directory01\File01.txt";
    }
}
