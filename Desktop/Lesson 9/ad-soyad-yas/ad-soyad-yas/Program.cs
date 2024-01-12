using System;
using System.Collections.Generic;
using System.Text;

namespace ad_soyad_yas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adinizi qeyd edin...");
            string name = Console.ReadLine();

            Console.WriteLine("Soyadinizi qeyd edin...");
            string surN = Console.ReadLine();

            Console.WriteLine("Yasinizi qeyd edin...");
            string yas = Console.ReadLine();
            int age = int.Parse(yas);
            int diff = 18 - age;


            if (age < 18)
            {
                for (int i = 0; i <= diff; i++)
                {
                    Console.WriteLine($"{name} {surN} {age} yasiniz mubarek");
                    age++;
                }
            }

            else
            {
                Console.WriteLine($" {name} {surN} {age} yasiniz mubarek");
            }
        }
    }
}
