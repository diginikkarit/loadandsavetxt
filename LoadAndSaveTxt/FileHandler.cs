using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LoadAndSaveTxt
{
    public class FileHandler
    {
        string filePath = @"C:\Users\jj\Documents\Visual Studio 2019\Demos\loadandsaveturd\GuitarData.txt";
        //List<string> lines = File.ReadAllLines(filePath).ToList();

        public string GuitarToString(Guitar guitar)
        {

            return $"{ guitar.Brand},{ guitar.Type},{ guitar.Price},{ guitar.Electric}";


        }
        public void WriteLineToFile(List<string> lines)
        {
            File.WriteAllLines(filePath, lines);
        }

        public Guitar MethodToBeNamed(List<Guitar> guitars)
        {

        }
    }
}
