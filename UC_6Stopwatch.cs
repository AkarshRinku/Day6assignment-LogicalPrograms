using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Day6assignment_LogicalPrograms
{
    class UC_6S
    {
        public void Stopwatch()

        {

            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("To start the stopwatch enter S or s.");
            char start = Convert.ToChar(Console.ReadLine());
            stopwatch.Start();
            if (start == 's' || start == 'S')
            {

                Console.WriteLine("To stop the stopwatch enter Q or q.");
                char end = Convert.ToChar(Console.ReadLine());
                if (end == 'q' || end == 'Q')
                {
                    stopwatch.Stop();
                    Console.WriteLine("stopwatch stopped, the time:" + stopwatch.Elapsed);
                }
                TimeSpan Ts = stopwatch.Elapsed;
                Console.WriteLine("Time elapsed:{0:hh\\:mm\\:ss}",stopwatch.Elapsed);
            }
        }
    }
   
}
