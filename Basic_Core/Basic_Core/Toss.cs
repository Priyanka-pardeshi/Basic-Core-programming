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
            Random objRandom = new Random();
            int check = objRandom.Next(0, 2);
            if (check < 0.5)
            {
                Console.WriteLine("Winner is Head");
            }
            else
            {
                Console.WriteLine("Winner is Tail");
            }
            float persentageOfHead = (1 * 100/2);
            Console.WriteLine("Persentage of geeting head:"+persentageOfHead);
            float persentageOfTail = (1 * 100 / 2);
            Console.WriteLine("Persentage of geeting head:" + persentageOfTail);

        }
    }
}
