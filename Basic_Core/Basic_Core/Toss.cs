using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    class Toss
    {
        public void Coin()
        {
            //created an object of class Random
            Random ObjRandom = new Random();
            int check = ObjRandom.Next(0, 2);
            if (check < 0.5)
            {
                Console.WriteLine("Winner is Head");
            }
            else
            {
                Console.WriteLine("Winner is Tail");
            }
        }
    }
}
