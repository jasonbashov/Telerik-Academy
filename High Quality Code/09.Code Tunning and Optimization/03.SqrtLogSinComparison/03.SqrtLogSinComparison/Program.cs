using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SqrtLogSinComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            SqrtMethods.CalculateSqrtDouble(2d, 10000d, 0.002d);

            SqrtMethods.CalculateSqrtDecimal(2m, 10000m, 0.002m);

            SqrtMethods.CalculateSqrtFloat(2f, 10000f, 0.002f);

            LogMethods.CalculateLogDouble(2d, 10000d, 0.002d);

            LogMethods.CalculateLogDecimal(2m, 10000m, 0.002m);

            LogMethods.CalculateLogFloat(2f, 10000f, 0.002f);

            SinusMethods.CalculateSinDouble(2d, 10000d, 0.002d);

            SinusMethods.CalculateSinDecimal(2m, 10000m, 0.002m);

            SinusMethods.CalculateSinFloat(2f, 10000f, 0.002f);
        }
    }
}
