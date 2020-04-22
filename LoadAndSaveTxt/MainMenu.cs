using System;

namespace LoadAndSaveTxt
{
    public class MainMenu
    {
        public void OpenMenu()
        {


            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu();
            }
        }
        private static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Add new guitar");
            Console.WriteLine("2) Show guitars");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    DataHandler.AddGuitar();
                    return true;
                case "2":
                    DataHandler.PrintGuitars();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }
    }
}
    

