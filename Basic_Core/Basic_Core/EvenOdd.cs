using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    class EvenOdd
    {
        public void Number(int value)
        {
            if (value % 2 == 0)
            {
                Console.WriteLine(value + " is Even number");
            }
            else
            {
                Console.WriteLine(value + " Is odd number");
            }
        }
    }
}
