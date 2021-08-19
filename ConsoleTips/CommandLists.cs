using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTips
{
    class CommandLists
    {
        internal static List<Command> consoleList = new List<Command>(){
            new Command("code .", "Open the current directory in Visual Code."),
            new Command("cd <directoryNameMovingTo>", "Move into the directory provided"),
            new Command("cd ..", "Move into the parent directory of the one you're currently in."),
            new Command("rename <fileName> <newFileName>", "Rename a specified file."),
            new Command("del <fileName>", "Delete the file provided."),
            new Command("cls", "Clear the screen."),
            new Command("mkdir <newDirectoryName>", "Make a new directory with the provided name."),
            new Command("rmdir <directoryNameDeleting>", "Delete the directory provided. Must be in the parent directory.")
        };
        internal static List<Command> githubList = new List<Command>()
        {
            new Command("git clone <CloneUrl>","Clone a local repo of the provided URL to your machine."),
            new Command("git checkout <BranchToSwitchTo>","Switch to the branch provided. If you do not stage any changes made before switching branches, then your changes will switch with you. To prevent this you should stage changes before checkout to a new branch.\n"),
            new Command("git add .","Stage all files in the current directory."),
            new Command("git add <DirName>","Stage all files in the specified directory."),
            new Command("git commit -m 'message'","Commit staged files so that they can be pushed."),
            new Command("git push","Push all commited changes to the remote repo"),
            new Command("git branch","List all branches in your local repo"),
            new Command("git branch -a","Lists all branches even in the remote repo"),
            new Command("git merge --abort","Cancel a pending merge"),
            new Command("git remote set-url origin <url>","Reset the origin or remote repo")
        };
        internal static List<Command> dotnetList = new List<Command>()
        {
            new Command("dotnet new","add a new solution file to the current directory."),
            new Command("dotnet new console","Create a new console project inside the current directory."),
            new Command("dotnet build","Builds the project and dependencies to ensure you are up to date."),
            new Command("dotnet run","Run your source code directly from the command prompt."),
            new Command("dotnet sln","Sln allows you to add, remove, and list projects in your solution file."),
            new Command("dotnet test","Launch test runner for specified project. Returns 0 if successful. Returns 1 if failed."),
            new Command("dotnet clean","Cleans the output of the previous build.")
        };

    }
}
