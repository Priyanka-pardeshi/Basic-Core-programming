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

            Console.WriteLine("1:Flip Coin to check Head or tail");
            Console.WriteLine("2:Check Leap Year");
            Console.WriteLine("3:Power of 2");
            Console.WriteLine("4:Harmonic number");
            Console.WriteLine("5:Factors of number");
            Console.WriteLine("6:Quo and Reminder");
            Console.WriteLine("7: Swap the Numbers");
            Console.WriteLine("8:Check Even and Odd number");
            Console.WriteLine("9:check alphabet Vowel");
            Console.WriteLine("10:Greatest number among Three");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: 
                    Toss obj = new Toss();
                    obj.Coin();
                    break;
                case 2: 
                    Year objYear = new Year();
                    objYear.year(2020);
                    break;
                case 3:
                    PowerOfTwo objPower = new PowerOfTwo();
                    Console.WriteLine("Enter the numer to check its 2's power=");
                    int input = Convert.ToInt32(Console.ReadLine());
                    int result = objPower.power(input);
                    Console.WriteLine("result is=" + result);
                    break;
                case 4:
                    Evaluate objEvaluate = new Evaluate();
                    Console.WriteLine("enter number to evaluate=");
                    int evalInput = Convert.ToInt32(Console.ReadLine());
                    float resultEval = objEvaluate.Calculate(evalInput);
                    Console.WriteLine("eval result=" + resultEval);
                    break;
                case 5: 
                    Factors objFactor = new Factors();
                    Console.WriteLine("Enter number to check its factors:");
                    int inputfact = Convert.ToInt32(Console.ReadLine());
                    objFactor.Factor(inputfact);
                    break;
                case 6: 
                    QuoAndReminder objQuoAndReminder = new QuoAndReminder();
                    Console.WriteLine("Enter divident: ");
                    int divi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter diviser : ");
                    int divis = Convert.ToInt32(Console.ReadLine());
                    objQuoAndReminder.Calculate(divi, divis);
                    break;
                case 7: 
                    Swap objSwap = new Swap();
                    Console.WriteLine("Enter Two Values to swap:");
                    int value1 = Convert.ToInt32(Console.ReadLine());
                    int value2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("values before swap is " + value1 + " and " + value2);
                    objSwap.swapValues(value1, value2);
                    break;
                case 8: 
                    EvenOdd objEvenOdd = new EvenOdd();
                    Console.WriteLine("Enter number to check is even or odd:");
                    int inputEvenOdd = Convert.ToInt32(Console.ReadLine());
                    objEvenOdd.Number(inputEvenOdd);
                    break;
                case 9: 
                    Vowel objVowel = new Vowel();
                    Console.WriteLine("Enter Alphabet to check its Vowel:");
                    char inputVowel = Convert.ToChar(Console.ReadLine());
                    objVowel.CheckVowel(inputVowel);
                    Console.ReadKey();
                    break;
                case 10: 
                    Greatest objGreatest = new Greatest();
                    Console.WriteLine("Enter the 3 numbers to check greatest among them: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    int number3 = Convert.ToInt32(Console.ReadLine());
                    objGreatest.GreaterNumber(number1, number2, number3);
                    break;
                default :
                    Console.WriteLine("invalid choice.");
                    break;
            }//switch close 
            Console.ReadLine();   
        }
    }
}
