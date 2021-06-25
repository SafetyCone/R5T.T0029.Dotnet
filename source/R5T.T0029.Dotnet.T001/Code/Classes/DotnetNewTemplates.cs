using System;


namespace R5T.T0029.Dotnet.T001
{
    /// <summary>
    /// Default dotnet new command templates.
    /// Naming space for custom templates is provided.
    /// </summary>
    public class DotnetNewTemplates
    {
        // These would usually be in a different project.
        public static string ClassLib => "classlib";
        public static string Console => "Console";
        public static string Sln => "sln";
        public static string Solution => Sln;
    }
}
