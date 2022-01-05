using System;
using System.Collections.Generic;

using R5T.Magyar;

using R5T.T0028.X001; /// <see cref="R5T.T0028.X001.Documentation"/>


namespace R5T.T0029.Dotnet.X001
{
    public static class ICommandBuilderExtensions
    {
        public static ICommandBuilder Add(this ICommandBuilder commandBuilder)
        {
            return commandBuilder.AppendToken(DotnetSlnCommandOptions.Add);
        }

        public static ICommandBuilder Sln(this ICommandBuilder commandBuilder)
        {
            return commandBuilder.AppendToken(DotnetSlnCommandOptions.Sln);
        }

        public static ICommandBuilder List(this ICommandBuilder commandBuilder)
        {
            return commandBuilder.AppendToken(DotnetSlnCommandOptions.List);
        }

        public static ICommandBuilder AddProjectToSolutionBase(this ICommandBuilder commandBuilder,
            string solutionFilePathToModify)
        {
            return commandBuilder
                .Sln()
                .AppendFilePathToken(solutionFilePathToModify)
                .Add()
                ;
        }

        public static ICommandBuilder AddProjectsToSolution(this ICommandBuilder commandBuilder,
            string solutionFilePathToModify,
            IEnumerable<string> projectReferenceFilePathsToAdd)
        {
            var output = commandBuilder.AddProjectToSolutionBase(solutionFilePathToModify)
                .AppendFilePathTokens(projectReferenceFilePathsToAdd)
                ;

            return output;
        }

        public static ICommandBuilder AddProjectToSolution(this ICommandBuilder commandBuilder,
            string solutionFilePathToModify,
            string projectReferenceFilePathToAdd)
        {
            return commandBuilder.AddProjectsToSolution(
                solutionFilePathToModify,
                EnumerableHelper.From(projectReferenceFilePathToAdd));
        }

        public static ICommandBuilder AddProjectToSolutionBase(this ICommandBuilder commandBuilder,
            string solutionFilePathToModify,
            string solutionFolder)
        {
            return commandBuilder.AddProjectToSolutionBase(solutionFilePathToModify)
                .AppendNameQuotedValuePair("--solution-folder", solutionFolder)
                ;
        }

        public static ICommandBuilder AddProjectsToSolution(this ICommandBuilder commandBuilder,
            string solutionFilePathToModify,
            IEnumerable<string> projectReferenceFilePathsToAdd,
            string solutionFolder)
        {
            var output = commandBuilder.AddProjectToSolutionBase(
                solutionFilePathToModify,
                solutionFolder)
                .AppendFilePathTokens(projectReferenceFilePathsToAdd)
                ;

            return output;
        }

        public static ICommandBuilder AddProjectToSolution(this ICommandBuilder commandBuilder,
            string solutionFilePathToModify,
            string projectReferenceFilePathToAdd,
            string solutionFolder)
        {
            return commandBuilder.AddProjectsToSolution(
                solutionFilePathToModify,
                EnumerableHelper.From(projectReferenceFilePathToAdd),
                solutionFolder);
        }

        public static ICommandBuilder Reference(this ICommandBuilder commandBuilder)
        {
            return commandBuilder.AppendToken(DotnetSlnCommandOptions.Reference);
        }

        public static ICommandBuilder Remove(this ICommandBuilder commandBuilder)
        {
            return commandBuilder.AppendToken(DotnetSlnCommandOptions.Remove);
        }

        public static ICommandBuilder RemoveProjectFromProject(this ICommandBuilder commandBuilder,
            string projectFilePathToModify,
            string projectReferenceFilePathToRemove)
        {
            return commandBuilder
                .Remove()
                .AppendFilePathToken(projectFilePathToModify)
                .Reference()
                .AppendFilePathToken(projectReferenceFilePathToRemove)
                ;
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

        public static ICommandBuilder ListSolutionProjectReferenceRelativePaths(this ICommandBuilder commandBuilder,
            string solutionFilePath)
        {
            return commandBuilder
                .Sln()
                .AppendFilePathToken(solutionFilePath)
                .List()
                ;
        }

        public static ICommandBuilder ListProjectProjectReferenceRelativePaths(this ICommandBuilder commandBuilder,
            string solutionFilePath)
        {
            return commandBuilder
                .List()
                .AppendFilePathToken(solutionFilePath)
                .Reference()
                ;
        }
    }
}
