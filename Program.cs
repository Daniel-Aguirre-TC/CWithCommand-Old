using System;
using System.IO;

namespace dotNetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.Clear();
            System.Console.WriteLine( "Intro to C# with Command Line\n\nPlease Press Enter to continue.\n\nCreated by: Daniel Aguirre");
            program.ReadAndClear();
            program.GetInput();
            program.ReadAndClear();
        }

        public void ReadAndClear()
        {
            Console.ReadLine();
            Console.Clear();
        }

        public void GetInput()
        {
            System.Console.WriteLine("Please select one of the following:\n1) Command\n2) Github\n3) DotNot\n");
            string input = Console.ReadLine();
            switch(input){
                case "1":
                System.Console.WriteLine("You have selected Command.");
                ReadAndClear();
                ShowCommands();
                break;
                case "2":
                System.Console.WriteLine("You have selected Github.");
                ReadAndClear();
                ShowGit();
                break;
                case "3":
                System.Console.WriteLine("You have selected DotNot.");                
                ReadAndClear();
                ShowDotNet();
                break;
                default:
                System.Console.WriteLine("Invalid Selection.\nPlease Select a valid option.");
                ReadAndClear();
                GetInput();
                break;
            }
        }
        public void ShowCommands()
        {
            System.Console.WriteLine("Console Commands:\n----------------------\n");
            System.Console.WriteLine("mkdir <newDirectoryName> \n- Make a new directory with the provided name.\n");
            System.Console.WriteLine("cd <directoryNameMovingTo> \n- Move into the directory provided\n");
            System.Console.WriteLine("cd .. \n- Move into the parent directory of the one you're currently in.\n");
            System.Console.WriteLine("rmdir <directoryNameDeleting> \n- Delete the directory provided. Must be in the parent directory.\n");
        }
        public void ShowGit()
        {        
            Console.Clear();
            System.Console.WriteLine("Github Commands:\n----------------------\n");
            System.Console.WriteLine("git clone <CloneUrl> \n- Clone a local repo of the provided URL to your machine.\n");
            System.Console.WriteLine("git checkout <BranchToSwitchTo> \n- Switch to the branch provided.\n");
            System.Console.WriteLine("git add . \n- Stage all files in the current directory.\n");
            System.Console.WriteLine("git add <DirName> \n- Stage all files in the specified directory.\n");
            System.Console.WriteLine("git commit -m 'message' \n- Commit staged files so that they can be pushed.\n");
            System.Console.WriteLine("git push \n- Push all commited changes to the remote repo\n");
            System.Console.WriteLine("git branch \n- List all branches in your local repo\n");
            System.Console.WriteLine("git branch -a \n- Lists all branches even in the remote repo");
            System.Console.WriteLine("git merge --abort \n- Cancel a pending merge\n");
            System.Console.WriteLine("git remote set-url origin <url> \n- Reset the origin or remote repo\n");
        }

        public void ShowDotNet()
        {
            System.Console.WriteLine("DotNot Commands:\n----------------------\n");
            System.Console.WriteLine("dotnet new console \n- Create a new console project inside the current directory.\n");
            System.Console.WriteLine("dotnet build \n- Builds the project and dependencies to ensure you are up to date.\n");
            System.Console.WriteLine("dotnet run \n- Run your source code directly from the command prompt.\n");
            System.Console.WriteLine("dotnet sln \n- Sln allows you to add, remove, and list projects in your solution file.\n");
            System.Console.WriteLine("dotnet test \n- Launch test runner for specified project. Returns 0 if successful. Returns 1 if failed.\n");
            System.Console.WriteLine("dotnet clean \n- Cleans the output of the previous build.\n");
            
        }

    }
}
