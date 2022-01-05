using System;

using R5T.T0021;
using R5T.T0021.X0002;


namespace System
{
    public static class IRootPathExtensions
    {
        public static string MKXDrive(this IRootPath _)
        {
            return RootPaths.MKXDrive;
        }

        public static string WindowsCDrive(this IRootPath _)
        {
            return RootPaths.WindowsCDrive;
        }

        public static string NonWindowsMnt(this IRootPath _)
        {
            return RootPaths.NonWindowsMnt;
        }
    }
}
