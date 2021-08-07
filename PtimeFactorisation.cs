using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionProblem
{
    class Factorisation
    {
        public static void factor()
        {
            int num;
            int count;
            Console.WriteLine("Please enter your integer: ");
            num = int.Parse(Console.ReadLine());
            for (count = 2; num>1; count++)
            {
              while(num % count == 0)  
                {
                    Console.WriteLine(count);
                    num = num / count;
                }
            }

        }
    }
}