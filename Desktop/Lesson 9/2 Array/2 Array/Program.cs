using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstBag = { 2, 4, 6, 93, 8, 10, 25, 12, 64, };

            int[] secondBag = { 3, 4, 94, 48, 100, 107, 24, 35 };

            
            int sum = 0 ;
            int sum2 = 0;
            foreach  (int birinci in firstBag)
            {
                if (birinci > sum)
                {
                    sum = birinci;
                }
            }
            Console.WriteLine($"en boyuk eded: {sum}");

            foreach (int ikinci in secondBag)
            {
                if (ikinci > sum2)
                {
                    sum2 = ikinci;
                }
            }
            Console.WriteLine($"en boyuk eded: {sum2}");

            Console.WriteLine("iki ededin cemini bilmek ucun Enter duymesine basin");

            string toplama = Console.ReadLine();
            Console.WriteLine(sum + sum2);
        }
    }
}
