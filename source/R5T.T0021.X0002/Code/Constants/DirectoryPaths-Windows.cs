using System;


namespace R5T.T0021.X0002
{
    public static partial class DirectoryPaths
    {
        public static string WindowsDirectoryPath01 => @"C:\Directory01\";
        public static string WindowsDirectoryPath01_Unindicated => @"C:\Directory01";
        public static string WindowsDirectoryPath02 => @"C:\Directory01\Directory02\";
        public static string WindowsDirectoryPath02_Unindicated => @"C:\Directory01\Directory02";
        public static string WindowsDirectoryPath03 => @"C:\Directory01\Directory02\Directory03\";
        public static string WindowsDirectoryPath03_Unindicated => @"C:\Directory01\Directory02\Directory03";
        public static string WindowsDirectoryPath04 => @"C:\Directory01\Directory04";
        public static string WindowsDirectoryPath04_Unindicated => @"C:\Directory01\Directory04";

        public static string WindowsRootDirectoryPathUnindicated => @"C:"; // Also the same as the Windows volume path.
        public static string WindowsRootDirectoryPath => @"C:\";

        public static string WindowsDirectory01FromWindowsDirectory04PathUnresolved => @"C:\Directory04\..\Directory01\";
    }
}