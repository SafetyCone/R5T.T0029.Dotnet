using System;

using R5T.T0029.Dotnet.T001;


namespace System
{
    public static class IProjectTypeExtensions
    {
        public static string ClassLib(this IProjectType _)
        {
            return DotnetNewTemplates.ClassLib;
        }

        public static string Console(this IProjectType _)
        {
            return DotnetNewTemplates.Console;
        }
    }
}
