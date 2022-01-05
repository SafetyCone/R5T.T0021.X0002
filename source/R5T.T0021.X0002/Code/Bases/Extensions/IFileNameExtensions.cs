using System;

using R5T.T0021;
using R5T.T0021.X0002;


namespace System
{
    public static class IFileNameExtensions
    {
        public static string File01Name(this IFileName _)
        {
            return FileNames.File01Name;
        }

        public static string File02Name(this IFileName _)
        {
            return FileNames.File02Name;
        }

        public static string File03Name(this IFileName _)
        {
            return FileNames.File03Name;
        }

        public static string File04Name(this IFileName _)
        {
            return FileNames.File04Name;
        }

        public static string File05Name(this IFileName _)
        {
            return FileNames.File05Name;
        }

        public static string File06Name(this IFileName _)
        {
            return FileNames.File06Name;
        }

        public static string File01WithoutExtension(this IFileName _)
        {
            return FileNames.File01WithoutExtension;
        }
    }
}
