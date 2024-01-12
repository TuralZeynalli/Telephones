using System;
using System.Collections.Generic;
using System.Text;

namespace telephones
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia phone1 = new Nokia ("Nokia 5230", 2010, 3.2, 1320, 100);

            Iphone phone2 = new Iphone ("Iphone 5", 2012, 4.1, 3500, 600);  // sual? 2ci en kohne telefonu tapmaq ucun ne etmeli?

            Samsung phone3 = new Samsung ("Galaxy A01 Core", 2021, 5.7, 3000, 200);

            Xiaomi phone4 = new Xiaomi("Redmi Not 12 Pro", 2023, 6.67, 5000, 500);
           
            MyPhones[] priceAvarage = new MyPhones[] { phone1, phone2, phone3, phone4 };

            PriceAvarage(priceAvarage); //sual? niye her variable ile cagirmaq olur? basqa cur de olurmu?

            TheOldestRelease(priceAvarage);

            BestBattery(priceAvarage);

            LongName(priceAvarage);

            ShowInches(phone2);
        }

        public static void PriceAvarage(MyPhones[] phones)
        {
            int sum = 0;
            foreach (var phone in phones)
            {
                sum += phone.Price / phones.Length;
            }
            Console.WriteLine($"your phones price avarage is {sum}");
        }

        public static void TheOldestRelease(MyPhones[] phones)
        {
            int old = 10000;
            string oldest = "";

            foreach (var phone in phones)
            {
                if (old > phone.ReleaseDate)
                {
                    old = phone.ReleaseDate;
                    oldest = phone.Name;
                }
            }
            Console.WriteLine($"the oldest telephone is {oldest} it's release date is {old}");
        }

        public static void BestBattery(MyPhones[] phones)
        {
            int strongest = 0;
            string battery = "";

            foreach (var phone in phones)
            {
                if (strongest < phone.Battery)
                {
                    strongest = phone.Battery;
                    battery = phone.Name;
                }
            }
            Console.WriteLine($"the strongest battery of a telephone is {battery} - {strongest}");
        }

        public static void LongName(MyPhones[] phones)
        {
            int maxLeng = 0;
            string longestName = "";

            foreach (var phone in phones)
            {
                if (maxLeng < phone.Name.Length)
                {
                    maxLeng = phone.Name.Length;
                    longestName = phone.Name;
                }
            }
            Console.WriteLine($"the longest name of a telephone is {longestName} - {maxLeng}");

            // SUAL bu yuxaridakilar DRY prinsipini pozur?
        }

        public static void ShowInches(MyPhones name)
        {
            Console.WriteLine($"{name.Name} - {name.Inches}");
        }


    }
}
