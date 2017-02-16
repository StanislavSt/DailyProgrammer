using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreCredit
{
    class ProductFinder
    {
        public int[] Result;
        public ProductFinder()
        {
            Result = new int[2];
        }
        public int[] Daily50(int[] list, int credit)
        {
            for(int i = 0 ; i < list.Length ; i++ )
                for(int j = i + 1 ; j < list.Length ; j++ )
                    if(list[i] + list[j] == credit)
                    {
                        Result[0] = i + 1;
                        Result[1] = j + 1;
                        return Result;
                    }
            return Result;
                    
        }
    }
}
