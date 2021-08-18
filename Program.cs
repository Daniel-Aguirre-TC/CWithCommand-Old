using System;
using System.IO;

namespace dotNetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            System.Console.WriteLine( "Intro to C# with Command Line");

            System.Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            program.GetInput();
            Console.ReadLine();
        }

        public void GetInput()
        {
            System.Console.WriteLine("Please select one of the following:\n1) Command\n2) Github\n3) DotNot\n");
            string input = Console.ReadLine();
            switch(input){
                case "1":
                System.Console.WriteLine("You have selected Command.");
                break;
                case "2":
                System.Console.WriteLine("You have selected Github.");
                break;
                case "3":
                System.Console.WriteLine("You have selected DotNot.");
                break;
                default:
                System.Console.WriteLine("Invalid Selection.\nPlease Select a valid option.");
                System.Console.ReadLine();
                System.Console.Clear();
                GetInput();
                break;
            }
        }
    }
}
