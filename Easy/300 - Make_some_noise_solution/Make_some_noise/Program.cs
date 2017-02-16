using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_some_noise
{
    class Program
    {
        static void Main(string[] args)
        {
            int note = 260;
            for( int i = 0 ; i < 8 ; i ++)
            {
                Console.Beep(note, 400);
                note += 70;
            }
        }
    }
}
