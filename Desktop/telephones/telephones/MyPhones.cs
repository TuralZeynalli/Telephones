using System;
using System.Collections.Generic;
using System.Text;

namespace telephones
{
    class MyPhones
    {
        public string Name { get; set; }
        public int ReleaseDate { get; set; }
        public double Inches { get; set; }
        public int Battery { get; set; }
        public int Price { get; set; }


        public MyPhones (string name, int releaseDate, double inches, int battery, int price)
        {
            Name = name;
            ReleaseDate = releaseDate;
            Inches = inches;
            Battery = battery;
            Price = price;
        }
      
    }
}
