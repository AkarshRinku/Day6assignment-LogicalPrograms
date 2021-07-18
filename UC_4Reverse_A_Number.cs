using System;
using System.Collections.Generic;
using System.Text;

namespace Day6assignment_LogicalPrograms
{
    class UC_4Reverse_A_Number
    {
        public void reversenumber()
        {
            Console.WriteLine("Enter a No. to reverse");

            int Number = int.Parse(Console.ReadLine());
            int Reverse = 0;

            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);
            Console.ReadLine();
        }
    }
}
