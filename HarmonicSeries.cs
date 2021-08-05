using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionProblem
{
    class HarmonicSeries
    {
        public static void harmonicseries()
        {
            int i, n;
            
            
         
            Console.WriteLine("Calculate the harmonic series :");
            Console.Write("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            
            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0} +",+ n);
                
            }
            
        }
    }
}
