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
            Console.Clear();
            Console.WriteLine("Effective Fruits and Vegetables");
            Console.WriteLine("1) Opening Hours");
            Console.WriteLine("2) Calendar");
            Console.WriteLine("3) Shift Times");
            Console.WriteLine("4) Employees");
            Console.WriteLine("9) Exit");
            Console.Write("\r\nSelect an option: ");
 
            switch (Console.ReadLine())
            {
                case "1":
                    OpenHours cl = new OpenHours();
                    cl.TestMethod(); 
                    return true;
                case "2":
                    RemoveWhitespace();
                    return true;
                case "3":

                    return true;
                case "4":
                    return true;
                case "9":
                    return false;
                default:
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