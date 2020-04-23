using System;

namespace LoadAndSaveTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataHandler.AddTest();
            //MainMenu mainMenu = new MainMenu();
            //mainMenu.OpenMenu();
            DataHandler dh = new DataHandler();
            FileHandler fh = new FileHandler();
            fh.SaveToFile();

            

            

        }
    }
}
        
        
