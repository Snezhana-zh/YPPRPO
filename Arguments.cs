using Fclp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagrangeInterpolation
{
    class ApplicationArguments
    {
        public List<double> xv { get; set; }
        public List<double> yv { get; set; }
        public double xi { get; set; }
    }
    class Arguments
    {
        public static ApplicationArguments FillParams(string[] args)
        {
            var p = new FluentCommandLineParser();

            ApplicationArguments app_params = new ApplicationArguments();

            p.Setup<List<double>>(Fclp.CaseType.CaseSensitive, "xv")
             .Callback(value => app_params.xv = value)
             .Required();

            p.Setup<List<double>>(Fclp.CaseType.CaseSensitive, "yv")
             .Callback(value => app_params.yv = value)
             .Required();

            p.Setup<double>(Fclp.CaseType.CaseSensitive, "xi")
             .Callback(value => app_params.xi = value)
             .Required();

            var result = p.Parse(args);

            if (result.HasErrors)
            {
                throw new ArgumentException($"Error parsing arguments: {result.ErrorText}");
            }

            return app_params;
        }
    }
}
