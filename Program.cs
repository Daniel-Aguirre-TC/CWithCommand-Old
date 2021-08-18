using System;
using System.IO;

namespace dotNetConsole
{
    class Program
    {
            bool programActive = true;
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.Clear();
            System.Console.WriteLine( "Intro to C# with Command Line\n\nPlease Press any key to continue.\n\nCreated by: Daniel Aguirre");
            Console.ReadKey();
            do{
            Console.Clear();
            // Ask user which commands to display, then show commands upon completion.
                program.GetInput();
            // wait for Console.ReadKey() then will Console.Clear()
                program.ReadAndClear();
            // Offer new command list, if user inputs no then will end program.
                program.OfferNewCommandList();
            }            
            while (program.programActive);
            

        }

        public void OfferNewCommandList()
        {
            System.Console.WriteLine("Would you like to view a new list of commands?\n\nPlease enter y/n");
            string input = Console.ReadLine();           
            Console.Clear();
            switch(input)
            {
                //if yes get input
                case "y":
                // just breaking so that we will go straight back to our while loop.
                break;
                // if no thank for using and break without calling new method. This should be the end of the program.
                case "n":
                System.Console.WriteLine("Thank you for using this Console Application!\n\nAny/All Feedback Welcome!\n\nCreated by: Daniel Aguirre\n\nPress any key to end.");
                System.Console.ReadKey();
                programActive = false;
                break;
                // if answer does not match, try again.
                default:
                System.Console.WriteLine("Invalid Selection. Please Try Again.");
                ReadAndClear();
                OfferNewCommandList();
                break;
            }
        }

        public void ReadAndClear()
        {
            Console.ReadKey();
            Console.Clear();
        }

        public void GetInput()
        {
            System.Console.WriteLine("Please select one of the following:\n\n1) Command\n2) Github\n3) DotNet\n");
            string input = Console.ReadLine();
            switch(input){
                case "1":
                System.Console.WriteLine("\nYou have selected Command.");
                ReadAndClear();
                ShowCommands();
                break;
                case "2":
                System.Console.WriteLine("\nYou have selected Github.");
                ReadAndClear();
                ShowGit();
                break;
                case "3":
                System.Console.WriteLine("\nYou have selected DotNet.");                
                ReadAndClear();
                ShowDotNet();
                break;
                default:
                System.Console.WriteLine("\nInvalid Selection.\nPlease Select a valid option.");
                ReadAndClear();
                GetInput();
                break;
            }
        }
        public void ShowCommands()
        {
            System.Console.WriteLine("Console Commands:\n----------------------\n");
            System.Console.WriteLine("code . \n- Open the current directory in Visual Code\n");
            System.Console.WriteLine("rename <fileName> <newFileName>\n- Rename a file.\n");
            System.Console.WriteLine("del <fileName> \n- Delete the file provided.\n");
            System.Console.WriteLine("cls \n- Clear the screen.\n");
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
            System.Console.WriteLine("git checkout <BranchToSwitchTo> \n- Switch to the branch provided. If you do not stage any changes made before switching branches, then your changes will switch with you. To prevent this you should stage changes before checkout to a new branch.\n");
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
            System.Console.WriteLine("DotNet Commands:\n----------------------\n");
            System.Console.WriteLine("dotnet new \n- add a new solution file to the current directory.\n");
            System.Console.WriteLine("dotnet new console \n- Create a new console project inside the current directory.\n");
            System.Console.WriteLine("dotnet build \n- Builds the project and dependencies to ensure you are up to date.\n");
            System.Console.WriteLine("dotnet run \n- Run your source code directly from the command prompt.\n");
            System.Console.WriteLine("dotnet sln \n- Sln allows you to add, remove, and list projects in your solution file.\n");
            System.Console.WriteLine("dotnet test \n- Launch test runner for specified project. Returns 0 if successful. Returns 1 if failed.\n");
            System.Console.WriteLine("dotnet clean \n- Cleans the output of the previous build.\n");            
        }

    }
}
