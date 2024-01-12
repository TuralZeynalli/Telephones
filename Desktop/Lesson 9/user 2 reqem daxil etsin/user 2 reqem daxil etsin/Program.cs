using System;
using System.Collections.Generic;
using System.Text;

namespace user_2_reqem_daxil_etsin
{
    class Program
    {
        static void Main(string[] args)
        {
            string birinci = Console.ReadLine();
            string ikinci = Console.ReadLine();
             
            int first = int.Parse(birinci);
            int second = int.Parse(ikinci);

            if (second > first && second > 0 && first > 0)
            {
                for (int i = first; i < second; i++)
                {
                    if (i%2==1)
                    {

                        if (i*i == second)
                            {
                             Console.WriteLine("Process terminated");
                                 break;
                            }

                        if (i != second / 2 )
                        {
                            Console.WriteLine(i);
                        }
                                                                       
                    }
                                     
                }
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
        }
    }
}
