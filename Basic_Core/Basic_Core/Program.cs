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
            //Console.WriteLine("")

            //Coin Toss 
            Toss obj = new Toss();
            obj.Coin();

            //leap year
            Year objYear = new Year();
            objYear.year(2020);

            //Power of 2
            PowerOfTwo objPower = new PowerOfTwo();
            Console.WriteLine("Enter the numer to check its 2's power=");
            int input = Convert.ToInt32(Console.ReadLine());
            int result = objPower.power(input);
            Console.WriteLine("result is=" + result);

            //Evaluate
            Evaluate objEvaluate = new Evaluate();
            Console.WriteLine("enter number to evaluate=");
            int evalInput = Convert.ToInt32(Console.ReadLine());
            float resultEval=objEvaluate.Calculate(evalInput);
            Console.WriteLine("eval result="+resultEval);

            //Even-odd
            EvenOdd objEvenOdd = new EvenOdd();
            Console.WriteLine("Enter number to check is even or odd:");
            int inputEvenOdd = Convert.ToInt32(Console.ReadLine());
            objEvenOdd.Number(inputEvenOdd);
            
            //Grestest Among 3
            Greatest objGreatest = new Greatest();
            Console.WriteLine("Enter the 3 numbers to check greatest among them: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            objGreatest.GreaterNumber(number1, number2, number3);
            
            //swap
            Swap objSwap = new Swap();
            Console.WriteLine("Enter Two Values to swap:");
            int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("values before swap is " + value1 + " and " + value2);
            objSwap.swapValues(value1,value2);

            //Quo and reminder
            QuoAndReminder objQuoAndReminder = new QuoAndReminder();
            Console.WriteLine("Enter divident: ");
            int divi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter diviser : ");
            int  divis= Convert.ToInt32(Console.ReadLine());
            objQuoAndReminder.Calculate(divi,divis);
            
            
            //factor
            Factors objFactor = new Factors();
            Console.WriteLine("Enter number to check its factors:");
            int inputfact = Convert.ToInt32(Console.ReadLine());
            objFactor.Factor(inputfact);
            
            //vowel
            Vowel objVowel = new Vowel();
            Console.WriteLine("Enter Alphabet to check its Vowel:");
            char inputVowel = Convert.ToChar(Console.ReadLine());
            objVowel.CheckVowel(inputVowel);
            Console.ReadKey();


        }
    }
}
