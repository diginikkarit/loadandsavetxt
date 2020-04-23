using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace LoadAndSaveTxt
{
    public class DataHandler
    {
        public static List<Guitar> guitars = new List<Guitar>();
        public static void AddTest()
        {
            guitars.Add(new Guitar("Fender", "Classical", 1200, false));
            guitars.Add(new Guitar("Gibson", "Les paul", 3000, true));
            guitars.Add(new Guitar("Ibanez", "stratocaster", 1500, true));
        }
        public static Guitar AddGuitar()
        {
            Guitar guitar1 = new Guitar();
            Console.WriteLine("Enter brand");
            guitar1.Brand = Console.ReadLine();
            Console.WriteLine("Enter type");
            guitar1.Type = Console.ReadLine();
            Console.WriteLine("Enter Price");
            guitar1.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter if its electric or not");
            guitar1.Electric = bool.Parse(Console.ReadLine());
            guitars.Add(guitar1);
            return guitar1;


        }


        public static void PrintGuitars()
        {
            for (int i = 0; i < guitars.Count; i++)
            {
                Console.WriteLine($"{i} {guitars[i].Brand} {guitars[i].Type} {guitars[i].Price} {guitars[i].Electric}");
            }

            Console.ReadLine();
            
            
        }
        
    }
}
