using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    class Factors
    {
        public void Factor(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i+",");
                }
            }
        }
    }
}
