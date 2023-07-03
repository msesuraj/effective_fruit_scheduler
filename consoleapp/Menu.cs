using System;
 
namespace ConsoleApp1
{
    class Menu
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            /* This shows the homepage along with the main menu for the different menus to access each page.
                what you need to do is to type one of the numbers that's listed though if you put a number that's not on the list,
                it can lead to an error,
                if you need to exit, you can press "5" to exit the homepage. */
            Console.Clear();
            Console.WriteLine("Effective Fruits and Vegetables");
            Console.WriteLine("1->) Opening Hours");
            Console.WriteLine("2->) Calendar");
            Console.WriteLine("3->) Shift Times");
            Console.WriteLine("4->) Employees");
            Console.WriteLine("5->) Exit");
            Console.Write("\r\nSelect an option: ");
 
            switch (Console.ReadLine())
            {
                case "1":
                    //calling the program that manages the opening hours
                    OpenHours cl = new OpenHours();
                    cl.TestMethod(); 
                    return true;
                case "2":
                    //calling the program that shows the calendar
                    RemoveWhitespace();
                    return true;
                case "3":
                    //calling the program that looks over the shift times
                    return true;
                case "4":
                    //brings in the programs that lists all the employees and their jobs
                    return true;
                case "5":
                    //exits user from the homepage
                    return false;
                default:
                    //error has been handled
                    Console.Write("You have selected wrong menu option..Please select 1-5 ");
                    Console.ReadLine();
                    return true;
            }
        }
 
        private static string CaptureInput()
        {
            Console.Write("Enter the string you want to modify: ");
            return Console.ReadLine();
        }
 
        private static void ReverseString()
        {
            Console.Clear();
            Console.WriteLine("Reverse String");
 
            char[] charArray = CaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));
        }
 
        private static void RemoveWhitespace()
        {
            Console.Clear();
            Console.WriteLine("Remove Whitespace");
 
            DisplayResult(CaptureInput().Replace(" ", ""));
        }
 
        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nYour modified string is: {message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}