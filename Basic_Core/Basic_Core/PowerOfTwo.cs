using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    class PowerOfTwo
    {
        public int power(int value)
        {
            int temp=1;
            for(int i=1; i<=value; i++)
            {
                temp =temp * 2;
            }
            return temp;
        }
    }
}
