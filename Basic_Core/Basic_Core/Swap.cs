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
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine("after Swapping values: " + firstNumber + " and " + secondNumber);
            
        }
        
    }
}
