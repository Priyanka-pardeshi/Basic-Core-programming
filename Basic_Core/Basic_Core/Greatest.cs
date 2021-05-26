using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    class Greatest
    {
        public void GreaterNumber(int number1,int number2, int number3)
        {
            if (number1 > number2 & number1 > number3)
            {
                Console.WriteLine(number1 + "is Greater number");
            }
            else if (number2 > number1 & number2 > number3)
            {
                Console.WriteLine(number2 + "is Greater number");
            }
            else
            {
                Console.WriteLine(number3 + "is Greater number");
            }
        }
    }
}
