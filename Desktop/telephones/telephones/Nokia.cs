using System;
using System.Collections.Generic;
using System.Text;

namespace telephones
{
    class Nokia : MyPhones
    {
        public Nokia (string model, int releaseDay, double inches, int battery, int price) : base(model, releaseDay, inches, battery, price) { }
    }
}
