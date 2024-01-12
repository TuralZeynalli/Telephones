using System;
using System.Collections.Generic;
using System.Text;

namespace telephones
{
    class Samsung : MyPhones
    {
        public Samsung (string model, int releaseDay, double inches, int battery, int price) : base (model, releaseDay, inches, battery, price)  { }
    }
}
