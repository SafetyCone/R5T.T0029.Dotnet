using System;


namespace R5T.T0029.Dotnet.T001
{
    /// <summary>
    /// Empty class for use as an extensions methods base.
    /// </summary>
    public class DotnetNewTemplate : IDotnetNewTemplate
    {
        #region Static

        public static DotnetNewTemplate Instance { get; } = new();

        #endregion
    }
}
