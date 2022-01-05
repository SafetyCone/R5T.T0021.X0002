using System;


namespace R5T.T0021.X0002
{
    public static class RelativeDirectoryPaths
    {
        // Windows.
        public static string WindowsDirectory01ToWindowsDirectory02Path => @"Directory02\";
        public static string WindowsDirectory02ToWindowsDirectory04Path => @"..\Directory04\";

        public static string WindowsDirectory04ToWindowsFile01Path => @"..\File01.txt";


        // Non-Windows.
    }
}
