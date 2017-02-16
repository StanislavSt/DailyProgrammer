using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge50_Difficult
{
    /*
             * T9 Spelling: The Latin alphabet contains 26 characters and telephones only have ten digits on the keypad. 
             * We would like to make it easier to write a message to your friend using a sequence of keypresses to indicate the desired characters.
             * The letters are mapped onto the digits as 2=ABC, 3=DEF, 4=GHI, 5=JKL, 6=MNO, 7=PQRS, 8=TUV, 9=WXYZ. 
             * To insert the character B for instance, the program would press 22. 
             * In order to insert two characters in sequence from the same key, the user must pause before pressing the key a second time.
             * The space character should be printed to indicate a pause. For example “2 2″ indicates AA whereas “22″ indicates B. 
             * Each message will consist of only lowercase characters a-z and space characters. Pressing zero emits a space. 
             * For instance, the message “hi” is encoded as “44 444″, “yes” is encoded as “999337777″, “foo bar” (note two spaces) is encoded as “333666 6660022 2777″,
             * and “hello world” is encoded as “4433555 555666096667775553″.
             * https://www.reddit.com/r/dailyprogrammer/comments/teu8p/592012_challenge_50_difficult/
             */
    class Challenge50
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DailyProgrammer_50_Hard("4433555 555666096667775553"));
            Console.ReadLine();

        }
        public static string DailyProgrammer_50_Hard(string numbers)
        {
            string[] keys = new string[] {"abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            List<string[]> keyCodes = new List<string[]>();

            for (int i = 0; i < keys.Length; i++ )
            {
                char[] characters = keys[i].ToCharArray();
                string current = (i + 2).ToString();

                for(int j = 0 ; j < characters.Length; j++)
                {
                    keyCodes.Insert(0, new string[] { current, characters[j].ToString() });
                    current += (i + 2).ToString();
                }
            }

            foreach(string[] items in keyCodes)
            {
                numbers = numbers.Replace(items[0], items[1]);
            }
            numbers = numbers.Replace(" ", string.Empty).Replace("0", " ");
            return numbers;
            
        }
    }
}
