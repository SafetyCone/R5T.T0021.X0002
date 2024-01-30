using System;


namespace R5T.T0021.X0002
{
    /// <summary>
    /// Obsolete - See R5T.Z0066.
    /// </summary>
    public static partial class DirectoryPaths
    {
        public static string NonWindowsDirectoryPath01 => @"/mnt/Directory01/";
        public static string NonWindowsDirectoryPath01_Unindicated => @"/mnt/Directory01";
        public static string NonWindowsDirectory02Path => @"/mnt/Directory01/Directory02/";
        public static string NonWindowsDirectory02PathUnindicated => @"/mnt/Directory01/Directory02";
        public static string NonWindowsDirectory03Path => @"/mnt/Directory01/Directory02/Directory03/";
        public static string NonWindowsDirectory03PathUnindicated => @"/mnt/Directory01/Directory02/Directory03";
        public static string NonWindowsDirectory04Path => @"/mnt/Directory01/Directory04/";
        public static string NonWindowsDirectory04PathUnindicated => @"/mnt/Directory01/Directory04";

        public static string NonWindowsDirectory01FromNonWindowsDirectory04PathUnresolved => @"/mnt/Directory04/../Directory01/";
    }
}