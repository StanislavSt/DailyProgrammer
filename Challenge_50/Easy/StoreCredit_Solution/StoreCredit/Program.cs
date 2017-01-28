using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreCredit
{
    class Program
    {
        /*
         * Store Credit:
         * You receive a credit C at a local store and would like to buy two items. 
         * You first walk through the store and create a list L of all available items. 
         * From this list you would like to buy two items that add up to the entire value of the credit. 
         * The solution you provide will consist of the two integers 
         * indicating the positions of the items in your list (smaller number first).
         * For instance, with C=100 and L={5,75,25} the solution is 2,3; 
         * with C=200 and L={150,24,79,50,88,345,3} the solution is 1,4; 
         * and with C=8 and L={2,1,9,4,4,56,90,3} the solution is 4,5.        
         */
        static void Main(string[] args)
        {
            ProductFinder pf = new ProductFinder();

            int[] list = new int[8] { 2, 1, 9, 4, 4, 56, 90, 3 };
            Console.WriteLine("How much is you credit : ");
            int credit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The possible items are : {0}, {1}", pf.Daily50(list,credit)[0],pf.Daily50(list,credit)[1]);
            Console.ReadLine();
        }
    }
}

