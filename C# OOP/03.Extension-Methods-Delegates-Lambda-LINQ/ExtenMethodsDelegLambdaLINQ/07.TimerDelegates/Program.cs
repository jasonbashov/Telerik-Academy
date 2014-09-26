//07.Using delegates write a class Timer that has can execute certain method at each t seconds.

namespace _07.TimerDelegates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;

    public delegate void Timer(string message, int seconds); 
    public class ExecuteAtEachSecond
    {
        public static void LoopMethod(string message, int seconds) 
        {
            Stopwatch sw = new Stopwatch(); 
            sw.Start();
            while (true)
            {
                if (sw.ElapsedMilliseconds == seconds * 1000) //CONVERT SECONDS TO MILISECONDS
                {
                    Console.WriteLine(message);
                    sw.Restart(); 
                }
            }
        }

        static void Main()
        {
            Timer t = new Timer(LoopMethod); 
            t("THERE IS SOMEBODY BEHIND YOU!!!", 4); 
        }
    }
}

