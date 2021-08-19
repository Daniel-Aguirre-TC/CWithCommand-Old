using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTips
{
    public static class ConsoleHandler
    {
        // tipsSection will be used to handle the base optionsList.
        public enum TipsSection { console, github, dotnet, cs }
        public static bool programActive = true;
        public static void OfferNewCommandList()
        {
            if (programActive)
            {
                System.Console.WriteLine("Would you like to view a new list of commands?\n\nPlease enter y/n");
                ConsoleKeyInfo input = Console.ReadKey();
                Console.Clear();
                switch (input.KeyChar)
                {
                    //if yes get input
                    case 'y':
                        // if yes break, this will return back through the while loop to keep program active.
                        break;
                    case 'n':
                        // if no then EndApplication() will set programActive to false before ending the while loop that keeps the program active.
                        EndApplication();
                        break;
                    // e will end the application as well.
                    case 'e':
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
        public static void EndApplication()
        {
            Console.Clear();
            System.Console.WriteLine("Thank you for using this Console Application!\n\nAny/All Feedback Welcome!\n\nCreated by: Daniel Aguirre\n\nPress any key to end.");
            System.Console.ReadKey();
            // setting programActive to false so that while loop will cancel.
            programActive = false;
            Console.Clear();
        }
        public static void ReadAndClear()
        {
            if (programActive)
            {
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.KeyChar == 'e')
                {
                    EndApplication();
                }
                else Console.Clear();
            }
        }
        public static void GetInput()
        {
            // temporarily assign selectedSection to console so it can compile 
            TipsSection selectedSection = TipsSection.console;
            System.Console.WriteLine("Please select one of the following:\n\n1) Console\n2) Github\n3) DotNet\n");
            ConsoleKeyInfo input = Console.ReadKey();
            switch (input.KeyChar)
            {
                case 'e':
                    EndApplication();
                    break;
                case '1':
                    selectedSection = TipsSection.console;                    
                    break;
                case '2':
                    selectedSection = TipsSection.github;
                    break;
                case '3':
                    selectedSection = TipsSection.dotnet;
                    break;
                default:
                    System.Console.WriteLine("\nInvalid Selection.\nPlease Select a valid option.");
                    ReadAndClear();
                    GetInput();
                    break;
            }
            WriteSelection(selectedSection);
            ReadAndClear();
            if (programActive)
            {
                System.Console.WriteLine($"{selectedSection} Commands:\n----------------------\n");
                DisplaySelected(selectedSection);
            }
        }
        public static void DisplaySelected(TipsSection selection)
        {
            List<Command> commandsList = null;
            switch (selection)
            {
                case TipsSection.console:
                    commandsList = CommandLists.consoleList;
                    break;
                case TipsSection.github:
                    commandsList = CommandLists.githubList;
                    break;
                case TipsSection.dotnet:
                    commandsList = CommandLists.dotnetList;
                    break;
                case TipsSection.cs:
                    // Go To CS page?
                    break;
                default:
                    Console.WriteLine($"No data for TipsSection.{selection}\n\nWill Now End Application.");
                    ReadAndClear();
                    EndApplication();
                    break;
            }
            foreach (Command cmd in commandsList)
            {
                System.Console.WriteLine($"{cmd.name} \n- {cmd.desc}\n");
            }
        }
        public static void WriteSelection(TipsSection selection)
        {
            Console.WriteLine($"\n\nYou have selected {selection}.\n\nPress any key to continue.");
        }

    }
}
