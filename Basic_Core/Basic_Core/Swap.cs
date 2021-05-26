using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    class Swap
    {
        public void swapValues(int firstNumber,int secondNumber)
        {
            int temp = 0;
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine("after Swapping values: " + firstNumber + " and " + secondNumber);
        }
        
    }
}
