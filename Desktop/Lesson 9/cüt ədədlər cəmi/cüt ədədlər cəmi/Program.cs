using System;
using System.Collections.Generic;
using System.Text;

namespace cüt_ədədlər_cəmi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] evenN = { 2, 3, 4, 8, 9, 10, 10, 6 };
            int sum = 0;

            foreach (int even in evenN)
            {
                if (even % 2 == 0)
                {
                    sum += even;
                }
                
            }
            Console.WriteLine($"cüt ededlerin cemi: {sum}");

        }
    }
}
