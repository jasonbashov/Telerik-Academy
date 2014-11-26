using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using log4net;
using log4net.Config;
using log4net.Appender;
using log4net.Layout;
using log4net.Core;

namespace FourFuncCalculator
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main()
        {
            var fileAppender = new FileAppender();
            fileAppender.File = "log.txt";
            fileAppender.AppendToFile = true;
            fileAppender.Layout = new SimpleLayout();
            fileAppender.Threshold = Level.Warn;
            fileAppender.ActivateOptions();

            BasicConfigurator.Configure(fileAppender);

            var add = Calculator.Add(2, 3);
            log.Info(add);
            var substract = Calculator.Substract(10, 2);
            log.Info(substract);
            var divide = Calculator.Divide(10, 2.5);
            log.Error(divide);
            var multiply = Calculator.Multiply(10, 2.5);
            log.Warn(multiply);
        }
    }
}
