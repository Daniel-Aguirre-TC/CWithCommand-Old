using System;
using System.IO;
using System.Collections.Generic;

namespace dotNetConsole
{
    class Program
    {
        bool programActive = true;
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.Clear();
            System.Console.WriteLine( "Intro to C# with Command Line\n\nIf you wish to end the application the enter E at any time.\n\nPlease Press any key to continue.\n\nCreated by: Daniel Aguirre");
            program.ReadAndClear();          
            while (program.programActive)
            {
                Console.Clear();
                // Ask user which commands to display, then show commands upon completion.
                program.GetInput();
                // wait for Console.ReadKey() then will Console.Clear()
                program.ReadAndClear();
                // Offer new command list, if user inputs no then will end program.
                program.OfferNewCommandList();
            };           
        }
        public void OfferNewCommandList()
        {
            if (programActive)
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
                EndApplication();
                break;
                case "e":
                EndApplication();
                break;
                // if answer does not match, try again.
                default:
                System.Console.WriteLine("Invalid Selection. Please Try Again.");
                ReadAndClear();
                OfferNewCommandList();
                break;
            }

        }   
    }
        public void EndApplication()
        {
            Console.Clear();
            System.Console.WriteLine("Thank you for using this Console Application!\n\nAny/All Feedback Welcome!\n\nCreated by: Daniel Aguirre\n\nPress any key to end.");
            System.Console.ReadKey();
            // setting programActive to false so that while loop will cancel.
            programActive = false;
            Console.Clear();
        }

        public void ReadAndClear()
        {
            if (programActive)
            {
            ConsoleKeyInfo input = Console.ReadKey();
            if(input.KeyChar == 'e')
            {
                EndApplication();
            }
            else Console.Clear();
            }
        }
        public void GetInput()
        {
            System.Console.WriteLine("Please select one of the following:\n\n1) Command\n2) Github\n3) DotNet\n");
            ConsoleKeyInfo input = Console.ReadKey();
            switch(input.KeyChar){
                case 'e':
                EndApplication();
                break;
                case '1':
                System.Console.WriteLine("\nYou have selected Command.");
                ReadAndClear();
                if (programActive)
                {
                System.Console.WriteLine("Console Commands:\n----------------------\n");
                CommandLists.DisplayCommands(CommandLists.consoleList);
                }
                break;
                case '2':
                System.Console.WriteLine("\nYou have selected Github.");
                ReadAndClear();
                if (programActive)
                {
                System.Console.WriteLine("Github Commands:\n----------------------\n");
                CommandLists.DisplayCommands(CommandLists.githubList);
                }
                break;
                case '3':
                System.Console.WriteLine("\nYou have selected DotNet.");                
                ReadAndClear();
                if (programActive)
                {
                System.Console.WriteLine("DotNet Commands:\n----------------------\n");
                CommandLists.DisplayCommands(CommandLists.dotnetList);
                }
                break;
                default:
                System.Console.WriteLine("\nInvalid Selection.\nPlease Select a valid option.");
                ReadAndClear();
                GetInput();
                break;
            }
        }       
    }
    class Command
    {
        public string name;
        public string desc;
        public Command(string Name, string Desc)
        {
            name = Name;
            desc = Desc;
        }
    }
    public static class CommandLists
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
        internal static void DisplayCommands(List<Command> commandsList)
        {
            foreach(Command cmd in commandsList)
            {                                
            System.Console.WriteLine(cmd.name +"\n- " + cmd.desc + "\n");
            }
        }
    }
}
