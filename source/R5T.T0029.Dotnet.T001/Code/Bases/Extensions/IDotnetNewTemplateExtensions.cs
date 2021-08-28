using System;

using R5T.T0029.Dotnet.T001;


namespace System
{
    public static class IDotnetNewTemplateExtensions
    {
        public static string ClassLib(this IDotnetNewTemplate _)
        {
            return DotnetNewTemplates.ClassLib;
        }

        public static string Console(this IDotnetNewTemplate _)
        {
            return DotnetNewTemplates.Console;
        }

        public static string Sln(this IDotnetNewTemplate _)
        {
            return DotnetNewTemplates.Sln;
        }

        public static string Solution(this IDotnetNewTemplate _)
        {
            return DotnetNewTemplates.Solution;
        }
    }
}
