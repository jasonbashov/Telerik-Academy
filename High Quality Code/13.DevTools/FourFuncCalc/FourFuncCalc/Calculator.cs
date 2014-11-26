using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourFuncCalculator
{
    /// <summary>
    /// A basic 4 function calculator
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// a + b
        /// </summary>
        /// <param name="a">First Number</param>
        /// <param name="b">Second Number</param>
        /// <returns>The Sum</returns>
        public static double Add(double a, double b)
        {
            return a + b;
        }
        /// <summary>
        /// a - b
        /// </summary>
        /// <param name="a">First Number</param>
        /// <param name="b">Second Number</param>
        /// <returns>The Difference</returns>
        public static double Substract(double a, double b)
        {
            return a - b;
        }
        /// <summary>
        /// a * b
        /// </summary>
        /// <param name="a">First Number</param>
        /// <param name="b">Second Number</param>
        /// <returns>The result</returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        /// <summary>
        /// a / b
        /// </summary>
        /// <param name="a">First Number</param>
        /// <param name="b">Second Number</param>
        /// <returns>The result</returns>
        public static double Divide(double a, double b)
        {
            return a / b;
        }

    }
}
