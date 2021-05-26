using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    class Evaluate
    {
        public float Calculate(int value)
        {
            float result=1
                ;
            for (float i = 1; i <= value; i++)
            {
                result = result +(1 / i); 
            }
                return result; 
        }
    }
}
