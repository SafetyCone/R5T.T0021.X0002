using System;

using R5T.T0021;


namespace R5T.T0021.X0002.X002
{
    public static class Instances
    {
        public static IDirectoryPath DirectoryPath { get; } = T0021.DirectoryPath.Instance;
        public static IFilePath FilePath { get; } = T0021.FilePath.Instance;
        public static IPath Path { get; } = T0021.Path.Instance;
    }
}
