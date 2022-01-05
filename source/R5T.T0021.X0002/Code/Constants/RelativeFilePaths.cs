using System;


namespace R5T.T0021.X0002
{
    public static class RelativeFilePaths
    {
        // Windows
        public const string WindowsFile01ToWindowsFile02Path = @"..\File02.txt";
        public const string WindowsFile01ToWindowsFile03Path = @"..\Directory02\File03.txt";
        public const string WindowsFile01ToWindowsFile04Path = @"..\Directory02\Directory03\File04.txt";
        public const string WindowsFile01ToWindowsFile05Path = @"..\Directory04\File05.txt";
        public const string WindowsFile01ToWindowsFile06Path = @"..\..\File06.txt";

        public const string WindowsFile04ToWindowsFile01Path = @"..\..\..\File01.txt";

        public const string WindowsFile01ToWindowsDirectory01Path = @"..\";
        public const string WindowsFile01ToWindowsDirectory02Path = @"..\Directory02\";
        public const string WindowsFile01ToWindowsDirectory03Path = @"..\Directory02\Directory03\";


        // Non-Windows

    }
}
