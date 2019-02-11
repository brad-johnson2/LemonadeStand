using System;
using System.Collections.Generic;

namespace LemonadeStand
{
     class Customer
    {
        public double priceHigh;
        public int tempHigh;
        public int tempLow;
        public int lemonsLow;
        public int sugarLow;
        public int iceLow;

        //public double PriceHigh { get; set; }
        //public int TempHigh { get; set; }
        //public int TempLow { get; set; }
        //public int LemonsLow { get; set; }
        //public int SugarLow { get; set; }
        //public int IceLow { get; set; }

        public Customer()
        {
            priceHigh = GetPriceHigh();
            tempHigh = GetTempHigh();
            tempLow = GetTempLow();
            lemonsLow = GetLemonsLow();
            sugarLow = GetSugarLow();
            iceLow = GetIceLow();
        }


    public double GetPriceHigh()
        {
            double result;

            Random rnd = new Random();
            result = rnd.Next(40, 101);
            result /= 100;
            return result;
        }

        public int GetTempHigh()
        {
            int result;

            Random rnd = new Random();
            result = rnd.Next(84, 96);
            return result;
        }

        public int GetTempLow()
        {
            int result;

            Random rnd = new Random();
            result = rnd.Next(55, 66);
            return result;
        }

        public int GetLemonsLow()
        {
            int result;

            Random rnd = new Random();
            result = rnd.Next(1, 2);
            return result;
        }

        public int GetSugarLow()
        {
            int result;

            Random rnd = new Random();
            result = rnd.Next(1, 2);
            return result;
        }

        public int GetIceLow()
        {
            int result;

            Random rnd = new Random();
            result = rnd.Next(2, 3);
            return result;
        }

    }           
}
