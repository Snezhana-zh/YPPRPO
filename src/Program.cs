using System;
using System.Collections.Generic;
using System.Xml;
using Fclp;
using static System.Net.Mime.MediaTypeNames;

namespace LagrangeInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var app_params = Arguments.FillParams(args);

                // Вывод результатов
                Console.WriteLine("xv: " + string.Join(", ", app_params.xv));
                Console.WriteLine("yv: " + string.Join(", ", app_params.yv));
                Console.WriteLine("xi: " + app_params.xi);

                double interpolatedValue = LagrangeInterpolation.Lagrange(app_params.xv, app_params.yv, app_params.xi);
                Console.WriteLine($"The value of the interpolation polynomial at a point {app_params.xi}: {interpolatedValue}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
