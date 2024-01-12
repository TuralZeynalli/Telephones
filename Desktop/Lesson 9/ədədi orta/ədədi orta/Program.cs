using System;
using System.Collections.Generic;
using System.Text;

namespace ədədi_orta
{
    class Program
    {
        static void Main(string[] args)
        {
            float [] ededler = { 2, 4, 6, 13, 18, 17, 5 };
            float sum = 0;
            float divide = 0;

            foreach (float eded in ededler)
            {
                sum += eded;

                divide = sum / ededler.Length;

            }

            Console.WriteLine(divide);

        }
    }
}
