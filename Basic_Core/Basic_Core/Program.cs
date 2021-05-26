using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# .net Core Programming");

            //Creating an obbject for an Toss class
            Toss Obj = new Toss();
            Obj.Coin();

            Year ObjYear = new Year();
            ObjYear.year(2020);

            Console.ReadKey();
        }
    }
}
