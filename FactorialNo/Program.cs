using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNo
{
    /* class Factorial
     {

         public int Fact(int n)
         {
             if (n == 1)
                 return 1;
             else
                 return n * Fact(n - 1);
         }

         static void Main(string[] args)
         {

             int value = 9;
             int ret;

             Factorial fact = new Factorial();
             ret = fact.Fact(value);
             Console.WriteLine("Value is : {0}", ret);
             Console.ReadLine();
         }
     }  */


    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter a number");

            int number = Convert.ToInt32(Console.ReadLine());

            long fact = GetFactorial(number);

            Console.WriteLine("{0} Factorial is {1}", number, fact);

            Console.ReadKey();

        }



        private static long GetFactorial(int number)

        {

            if (number == 0)

            {

                return 1;

            }

            return number * GetFactorial(number - 1);

        }

    }
}
