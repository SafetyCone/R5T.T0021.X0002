using System;

using R5T.T0119;

using InputOutputPair = R5T.T0120.InputOutputPair<string, bool>;

using Instances = R5T.T0021.X0002.X002.Instances;


namespace System
{
    public static partial class IExpectedValueExtensions
    {
        #region Directory and File

        public static InputOutputPair IsDirectoryIndicatedForDirectoryIndicatedPath(this IExpectedValue _)
        {
            var output = new InputOutputPair
            {
                Input = Instances.DirectoryPath.WindowsDirectoryPath01(),
                Output = true,
            };

            return output;
        }

        public static InputOutputPair IsDirectoryIndicatedForDirectoryIndicatedPath_Windows(this IExpectedValue _)
        {
            var output = new InputOutputPair
            {
                Input = Instances.DirectoryPath.WindowsDirectoryPath02(),
                Output = true,
            };

            return output;
        }

        public static InputOutputPair IsDirectoryIndicatedForDirectoryIndicatedPath_NonWindows(this IExpectedValue _)
        {
            var output = new InputOutputPair
            {
                Input = Instances.DirectoryPath.NonWindowsDirectoryPath01(),
                Output = true,
            };

            return output;
        }


        public static InputOutputPair IsNotDirectoryIndicatedForNonDirectoryIndicatedPath(this IExpectedValue _)
        {
            var output = new InputOutputPair
            {
                Input = Instances.DirectoryPath.WindowsDirectoryPath01_Unindicated(),
                Output = false,
            };

            return output;
        }

        public static InputOutputPair IsNotDirectoryIndicatedForNonDirectoryIndicatedPath_Windows(this IExpectedValue _)
        {
            var output = new InputOutputPair
            {
                Input = Instances.DirectoryPath.WindowsDirectoryPath02_Unindicated(),
                Output = false,
            };

            return output;
        }

        public static InputOutputPair IsNotDirectoryIndicatedForNonDirectoryIndicatedPath_NonWindows(this IExpectedValue _)
        {
            var output = new InputOutputPair
            {
                Input = Instances.DirectoryPath.NonWindowsDirectoryPath01_Unindicated(),
                Output = false,
            };

            return output;
        }

        #endregion

        #region Resolved and Unresolved

        public static InputOutputPair ResolvedPathIsResolved(this IExpectedValue _)
        {
            var output = new InputOutputPair
            {
                Input = Instances.Path.ResolvedPath(),
                Output = true,
            };

            return output;
        }

        public static InputOutputPair ResolvedPathIsNotUnresolved(this IExpectedValue _)
        {
            var output = new InputOutputPair
            {
                Input = Instances.Path.ResolvedPath(),
                Output = false,
            };

            return output;
        }

        public static InputOutputPair UnresolvedPathIsUnresolved(this IExpectedValue _)
        {
            var output = new InputOutputPair
            {
                Input = Instances.Path.UnresolvedPath(),
                Output = true,
            };

            return output;
        }

        public static InputOutputPair UnresolvedPathIsNotResolved(this IExpectedValue _)
        {
            var output = new InputOutputPair
            {
                Input = Instances.Path.UnresolvedPath(),
                Output = false,
            };

            return output;
        }

        #endregion
    }
}