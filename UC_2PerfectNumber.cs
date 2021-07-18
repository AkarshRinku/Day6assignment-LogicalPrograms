using System;
using System.Collections.Generic;
using System.Text;

namespace Day6assignment_LogicalPrograms
{
    class UC_2PerfectNumber
    {
        public void Checkperfectnumber()
        {
            int number; 
            int sum = 0;
            int n;
          
            Console.Write("enter the Number:");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\n Entered number is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
                Console.ReadLine();
            }
        }
    }
}
