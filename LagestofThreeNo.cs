using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionProblem
{
    class LagestofThreeNo
    {
        public static void lagestofthreeno()
        {
            int num1, num2, num3;
            num1 = 10;
            num2 = 20;
            num3 = 50;
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Number one is the largest!");
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine("Number two is the largest!");
            }
            else
            {
                Console.WriteLine("Number three is the largest!");
            }
        }
    }

}