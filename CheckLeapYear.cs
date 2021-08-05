using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionProblem
{
    class CheckLeapYear
    {
        public static void checklp()
        {
                Console.WriteLine("Enter four digit Year : ");
                int Year = int.Parse(Console.ReadLine());
                if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                Console.WriteLine("This is a Leap Year.", Year);
                else Console.WriteLine("This is not a Leap Year.", Year);
                Console.ReadLine();
        }
    }
}
