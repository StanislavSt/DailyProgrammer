using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange1_PrintInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DailyProgrammer Challange #1 /Easy/ ");
            Console.WriteLine("Please insert your name : ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please insert your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert your Reddir username : ");
            string username = Convert.ToString(Console.ReadLine());

            Console.WriteLine("your name is {0}, you are {1} years old, and your username is {2}", name, age, username);
            Console.ReadLine();
        }
    }
}
