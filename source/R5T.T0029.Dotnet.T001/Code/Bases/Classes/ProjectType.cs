using System;


namespace R5T.T0029.Dotnet.T001
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ProjectType : IProjectType
    {
        #region Static

        public static ProjectType Instance { get; } = new();

        #endregion
    }
}