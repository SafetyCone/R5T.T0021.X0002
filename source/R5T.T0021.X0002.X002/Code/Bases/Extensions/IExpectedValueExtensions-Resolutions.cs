using System;

using R5T.T0119;

using InputOutputPair = R5T.T0120.InputOutputPair<string, string>;

using Instances = R5T.T0021.X0002.X002.Instances;


namespace System
{
    public static partial class IExpectedValueExtensions
    {
        #region Windows

        public static InputOutputPair ResolutionForUnresolvedWindowsFilePath(this IExpectedValue _)
        {
            var output = new InputOutputPair
            {
                Input = Instances.FilePath.WindowsFile01FromWindowsDirectory02PathUnresolved(),
                Output = Instances.FilePath.WindowsFilePath01(),
            };

            return output;
        }

        public static InputOutputPair ResolutionForUnresolvedWindowsDirectoryPath(this IExpectedValue _)
        {
            var output = new InputOutputPair
            {
                Input = Instances.DirectoryPath.WindowsDirectory01FromWindowsDirectory04PathUnresolved(),
                Output = Instances.DirectoryPath.WindowsDirectoryPath01(),
            };

            return output;
        }

        #endregion

        #region Non-Windows

        public static InputOutputPair ResolutionForUnresolvedNonWindowsFilePath(this IExpectedValue _)
        {
            var output = new InputOutputPair
            {
                Input = Instances.FilePath.NonWindowsFile01FromNonWindowsDirectory02PathUnresolved(),
                Output = Instances.FilePath.NonWindowsFile01Path(),
            };

            return output;
        }

        public static InputOutputPair ResolutionForUnresolvedNonWindowsDirectoryPath(this IExpectedValue _)
        {
            var output = new InputOutputPair
            {
                Input = Instances.DirectoryPath.NonWindowsDirectory01FromNonWindowsDirectory04PathUnresolved(),
                Output = Instances.DirectoryPath.NonWindowsDirectoryPath01(),
            };

            return output;
        }

        #endregion
    }
}