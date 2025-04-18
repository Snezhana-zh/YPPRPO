using System;
using System.Collections.Generic;

namespace LagrangeInterpolation
{
    class LagrangeInterpolation
    {
        static public double Lagrange(List<double> x, List<double> y, double xi)
        {
            if (x.Count != y.Count)
            {
                throw new Exception("Error: size of xv != size of yv");
            }

            double result = 0.0;
            int n = x.Count;

            for (int i = 0; i < n; i++)
            {
                double term = y.ElementAt(i);
                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        term *= (xi - x.ElementAt(j)) / (x.ElementAt(i) - x.ElementAt(j));
                    }
                }
                result += term;
            }

            return result;
        }
    }
}