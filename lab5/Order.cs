using System;

namespace lab5
{
    internal class Order
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime FirstDay { get; set; }
        public int DaysCount { get; set; }
        public decimal Price { get; set; }
        public bool Helmet { get; set; }
        public bool Goggles { get; set; }
        public bool Poles { get; set; }
        public decimal FullPrice
        {
            get 
            {
                decimal fullPrice = DaysCount * Price;

                if (Helmet)
                {
                    fullPrice += 10;
                }
                if (Goggles)
                {
                    fullPrice += 10;
                }
                if (Poles) 
                {
                    fullPrice += 10;
                }

                return fullPrice;
            }
        }

        public Order()
        {
            FirstDay = DateTime.Today;
            DaysCount = 1;
            Price = 50;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} -> ${FullPrice}";
        }
    }
}
