using System;


namespace R5T.T0029.Dotnet.T001
{
    public static class IDotnetNewTemplateExtensions
    {
#pragma warning disable IDE0060 // Remove unused parameter

        public static string ClassLib(this IDotnetNewTemplate dotnetNewTemplate)
        {
            return DotnetNewTemplates.ClassLib;
        }

        public static string Console(this IDotnetNewTemplate dotnetNewTemplate)
        {
            return DotnetNewTemplates.Console;
        }

        public static string Sln(this IDotnetNewTemplate dotnetNewTemplate)
        {
            return DotnetNewTemplates.Sln;
        }

        public static string Solution(this IDotnetNewTemplate dotnetNewTemplate)
        {
            return DotnetNewTemplates.Solution;
        }

#pragma warning restore IDE0060 // Remove unused parameter
    }
}
