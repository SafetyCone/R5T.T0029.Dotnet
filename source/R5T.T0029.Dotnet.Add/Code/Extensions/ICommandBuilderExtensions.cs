using System;
using System.Collections.Generic;

using R5T.T0028.X001;


namespace R5T.T0029.Dotnet.Add
{
    public static class ICommandBuilderExtensions
    {
        public static ICommandBuilder Add(this ICommandBuilder commandBuilder)
        {
            return commandBuilder.AppendToken(DotnetAddCommandOptions.Add);
        }

        public static ICommandBuilder Reference(this ICommandBuilder commandBuilder)
        {
            return commandBuilder.AppendToken(DotnetAddCommandOptions.Reference);
        }

        public static ICommandBuilder Add(this ICommandBuilder commandBuilder,
            string projectToModifyFilePath,
            IList<string> projectReferencesToAdd)
        {
            return commandBuilder
                .Add()
                .AppendToken(projectToModifyFilePath)
                .Reference()
                .With(theCommandBuilder =>
                {
                    foreach (var projectReference in projectReferencesToAdd)
                    {
                        theCommandBuilder.AppendToken(projectReference);
                    }
                });
        }
    }
}
