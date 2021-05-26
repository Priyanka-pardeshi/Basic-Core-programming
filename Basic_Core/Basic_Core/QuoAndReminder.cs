using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    class QuoAndReminder
    {
        public void Calculate(int divident, int diviser)
        {
            float quotient = (divident / diviser);
            Console.WriteLine("Quotient is:" + quotient);
            int reminder = (divident % diviser);
            Console.WriteLine("Reminder is:" + reminder);
        }
    }
}
