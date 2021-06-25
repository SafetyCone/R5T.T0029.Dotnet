using System;

using R5T.T0028.X001;


namespace R5T.T0029.Dotnet.New
{
    public static class ICommandBuilderExtensions
    {
        public static ICommandBuilder New(this ICommandBuilder commandBuilder)
        {
            return commandBuilder.AppendToken(DotnetNewCommandOptions.New);
        }

        public static ICommandBuilder DryRunIf(this ICommandBuilder commandBuilder, bool dryRun = DryRun.DefaultValue)
        {
            return commandBuilder.AppendTokenIf(dryRun, DotnetNewCommandOptions.DryRun);
        }

        public static ICommandBuilder New(this ICommandBuilder commandBuilder,
            string templateName, string solutionName, string solutionDirectoryPath, bool dryRun = DryRun.DefaultValue)
        {
            return commandBuilder.New()
                .AppendToken(templateName)
                .AppendNameValuePair(DotnetNewCommandOptions.Name, solutionName)
                .AppendNameValuePair(DotnetNewCommandOptions.Output, solutionDirectoryPath)
                .DryRunIf(dryRun)
                ;
        }
    }
}
