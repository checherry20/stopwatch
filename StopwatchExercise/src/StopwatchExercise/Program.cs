using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StopwatchExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var stopwatch = new StopwatchControl();

            String rl;
            int ctr = 0;
            do
            {
                ctr++;
                
                Console.WriteLine("Start time: {0}", stopwatch.GetStartTime());
                Console.WriteLine("Stoped: {0}", stopwatch.Stop(DateTime.Now));
                Console.WriteLine("Duration is {0}", stopwatch.GetDuration());

                Thread.Sleep(2000);

                stopwatch.Start(stopwatch.GetStopTime());

                rl = Console.ReadLine();
            } while (rl != null);
        }
    }
}
