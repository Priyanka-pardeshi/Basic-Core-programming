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
            if (number2 > number1 & number2 > number3)
            {
                Console.WriteLine(number2 + "is Greater number");
            }
            if (number1 == number2 & number2 == number3 & number3 == number1)
            {
                Console.WriteLine("Three numbers are have same values ");
            }
            else
            {
                Console.WriteLine(number3 + "is Greater number");
            }
        }
    }
}
