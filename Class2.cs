using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionProblem
{
    class EvenAndOdd
    {
        public static void CheckNo()
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }


        }
    }


}