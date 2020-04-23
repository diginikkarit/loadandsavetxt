using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LoadAndSaveTxt
{
    public class FileHandler
    {
        List<Guitar> guitars = new List<Guitar>();
        string filePath = @"C:\Users\jj\Documents\Visual Studio 2019\Demos\loadandsaveturd\GuitarData.txt";
        List<string> lines = File.ReadAllLines(filePath).ToList();
        FileHandler fh = new FileHandler();


        public string GuitarToString(Guitar guitar)
        {

            return $"{ guitar.Brand},{ guitar.Type},{ guitar.Price},{ guitar.Electric}";


        }
        public void WriteLineToFile(List<string> lines)
        {
            File.WriteAllLines(filePath, lines);
        }

        public List<string> ObjectsToString(List<Guitar> guitars)
        {
            List<string> guitars2 = new List<string>();
            
            foreach (var guitar in guitars)
            {
                guitars2.Add(GuitarToString(guitar));
            }

            return guitars2;
        }
        public void SaveToFile(List<Guitar> guitars)
        {
            lines = GuitarToString(guitars);
            WriteLineToFile(lines);
        
        }
        
    }
}
