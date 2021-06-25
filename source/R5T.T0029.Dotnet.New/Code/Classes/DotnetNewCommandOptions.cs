using System;


namespace R5T.T0029.Dotnet.New
{
    public static class DotnetNewCommandOptions
    {
        public static string New => "new";

        public static string DryRun => "--dry-run";
        public static string NameLong => "--name";
        public static string NameShort => "-n";
        public static string Name => NameLong;
        public static string OutputLong => "--output";
        public static string OutputShort => "-o";
        public static string Output => OutputLong;
    }

    /* As of 20210601, with dotnet --version => 2.2.100

    dotnet new --help
    Usage: new [options]

    Options:
        -h, --help          Displays help for this command.
        -l, --list          Lists templates containing the specified name. If no name is specified, lists all templates.
        -n, --name          The name for the output being created. If no name is specified, the name of the current directory is used.
        -o, --output        Location to place the generated output.
        -i, --install       Installs a source or a template pack.
        -u, --uninstall     Uninstalls a source or a template pack.
        --nuget-source      Specifies a NuGet source to use during install.
        --type              Filters templates based on available types. Predefined values are "project", "item" or "other".
        --dry-run           Displays a summary of what would happen if the given command line were run if it would result in a template creation.
        --force             Forces content to be generated even if it would change existing files.
        -lang, --language   Filters templates based on language and specifies the language of the template to create.

    */
}
