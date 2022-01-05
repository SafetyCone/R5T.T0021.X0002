using System;

using R5T.T0119;

using InputOutputPair = R5T.T0120.InputOutputPair<string, string>;

using Instances = R5T.T0021.X0002.X002.Instances;


namespace System
{
    public static partial class IExpectedValueExtensions
    {
        public static InputOutputPair ParentDirectoryForWindowsFile01(this IExpectedValue _)
        {
            var output = new InputOutputPair
            {
                Input = Instances.FilePath.WindowsFilePath01(),
                Output = Instances.DirectoryPath.WindowsDirectoryPath01()
            };

            return output;
        }
    }
}