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
            System.Console.WriteLine( "Intro to C# with Command Line");
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
            System.Console.WriteLine("Console Commands:\n");
            System.Console.WriteLine("cd <directoryNameMovingTo>");
            System.Console.WriteLine("cd ..");
            System.Console.WriteLine("rmdir");
        }
        public void ShowGit()
        {        
            Console.Clear();
            System.Console.WriteLine("Github Commands:\n");
            System.Console.WriteLine("git checkout <BranchToSwitchTo>");
            System.Console.WriteLine("git clone <CloneUrl> ");
            System.Console.WriteLine("git add .");
            System.Console.WriteLine("git commit -m message");
            System.Console.WriteLine("git push");
            System.Console.WriteLine("git branch");
            System.Console.WriteLine("git branch -a");
            System.Console.WriteLine("git merge --abort");
            System.Console.WriteLine("git remote set-url origin <url>");
        }

        public void ShowDotNet()
        {
            System.Console.WriteLine("DotNot Commands:");
            System.Console.WriteLine("dotnet new");
            System.Console.WriteLine("dotnet new console");
            System.Console.WriteLine("dotnet build");
            System.Console.WriteLine("dotnet run");
            System.Console.WriteLine("dotnet sln");
            System.Console.WriteLine("dotnet clean");
        }

    }
}
