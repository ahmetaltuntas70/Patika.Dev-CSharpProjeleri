using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciOrtalama
{
    public class FibonacciCalculator
    {
        public int[] CalculateFibonacciSeries(int depth)
        {
            int[] fibonacciSeries = new int[depth];

            for (int i = 1; i < depth; i++)
            {
                if (i == 1)
                {
                    fibonacciSeries[i] = i;
                }
                else
                {
                    fibonacciSeries[i] = fibonacciSeries[i - 1] + fibonacciSeries[i - 2];
                }
            }

            return fibonacciSeries;
        }
    }
}
