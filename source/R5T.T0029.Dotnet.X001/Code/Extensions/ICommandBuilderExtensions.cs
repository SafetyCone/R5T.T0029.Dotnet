using System;

using R5T.T0028.X001; /// <see cref="R5T.T0028.X001.Documentation"/>


namespace R5T.T0029.Dotnet.X001
{
    public static class ICommandBuilderExtensions
    {
        public static ICommandBuilder Sln(this ICommandBuilder commandBuilder)
        {
            return commandBuilder.AppendToken(DotnetSlnCommandOptions.Sln);
        }

        public static ICommandBuilder Add(this ICommandBuilder commandBuilder)
        {
            return commandBuilder.AppendToken(DotnetSlnCommandOptions.Add);
        }

        public static ICommandBuilder AddProjectToSolution(this ICommandBuilder commandBuilder,
            string solutionFilePathToModify,
            string projectReferenceFilePathToAdd)
        {
            return commandBuilder
                .Sln()
                .AppendFilePathToken(solutionFilePathToModify)
                .Add()
                .AppendFilePathToken(projectReferenceFilePathToAdd);
        }

        public static ICommandBuilder Remove(this ICommandBuilder commandBuilder)
        {
            return commandBuilder.AppendToken(DotnetSlnCommandOptions.Remove);
        }

        public static ICommandBuilder RemoveProjectFromSolution(this ICommandBuilder commandBuilder,
            string solutionFilePathToModify,
            string projectReferenceFilePathToRemove)
        {
            return commandBuilder
                .Sln()
                .AppendFilePathToken(solutionFilePathToModify)
                .Remove()
                .AppendFilePathToken(projectReferenceFilePathToRemove);
        }
    }
}
