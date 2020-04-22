using System;
using System.Collections.Generic;
using System.Text;

namespace LoadAndSaveTxt
{
    public class Guitar
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public bool Electric { get; set; }

        public Guitar(string Brand, string Type, int Price, bool Electric)
        {
            this.Brand = Brand;
            this.Type = Type;
            this.Price = Price;
            this.Electric = Electric;


        }
        public Guitar()
        {

        }
    }
}
