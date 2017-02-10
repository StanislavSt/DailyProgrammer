using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DailyProgrammer_302_easy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ElementSymbol = new List<string>();
            List<string> ElementName = new List<string>();

            //Reading a csv file to get all the information
            var reader = new StreamReader(File.OpenRead(@"C:\\Users\\Stanislav\\Desktop\\pt-data2.csv"));
            while (!reader.EndOfStream)
            {
                var parts = reader.ReadToEnd().Split(',');
                //get the Symbols
                for (int i = 1; i < parts.Length; i += 18)
                    ElementSymbol.Add(parts[i]);
                //get the Names
                for (int i = 2; i < parts.Length; i += 18)
                    ElementName.Add(parts[i]);
            }
            string[] ElementSymbolArray = ElementSymbol.ToArray();
            string[] ElementNameArray = ElementName.ToArray();

            Console.WriteLine("Write your word : ");
            string word = Console.ReadLine();

            //foreach char in the word 
            for (int j = 0 ; j < word.Length ; j ++ )
            {
                    //for each symbol in the Periodic table
                    for (int i = 0; i < ElementSymbolArray.Length; i++)
                    {
                        //Check for symbols of 2 chars
                        if (Char.IsLower(word[j]) && ElementSymbolArray[i].Contains(word.Substring(j-1, 2)))
                                Console.WriteLine(ElementNameArray[i]);
                        //Check for symbols of 1 char
                        else if (ElementSymbolArray[i].Contains(word[j]) && ElementSymbolArray[i].Length < 4)
                            if(j+1 < word.Length)
                            {
                                if (!Char.IsLower(word[j + 1]))
                                    Console.WriteLine(ElementNameArray[i]);
                            }
                            else
                                Console.WriteLine(ElementNameArray[i]);
                    }
            }
            Console.ReadLine();
        }

    }
}
