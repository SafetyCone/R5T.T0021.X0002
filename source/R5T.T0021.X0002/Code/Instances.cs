using System;


namespace R5T.T0021.X0002
{
    public static class Instances
    {
        public static IDirectoryName DirectoryName { get; } = T0021.DirectoryName.Instance;
        public static IFileName FileName { get; } = T0021.FileName.Instance;
        public static IFilePath FilePath { get; } = T0021.FilePath.Instance;
        public static IRootPath RootPath { get; } = T0021.RootPath.Instance;
    }
}
