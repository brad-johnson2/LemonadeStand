using System;
using System.Collections.Generic;

namespace LemonadeStand
{
     class Customer
    {
        private double priceHigh;
        private int tempHigh;
        private int tempLow;
        private int lemonsLow;
        private int sugarLow;
        private int iceLow;

        public double PriceHigh { get; set; }
        public int TempHigh { get; set; }
        public int TempLow { get; set; }
        public int LemonsLow { get; set; }
        public int SugarLow { get; set; }
        public int IceLow { get; set; }



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
            result = rnd.Next(75, 96);
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
            result = rnd.Next(1, 3);
            return result;
        }

        public int GetSugarLow()
        {
            int result;

            Random rnd = new Random();
            result = rnd.Next(1, 3);
            return result;
        }

        public int GetIceLow()
        {
            int result;

            Random rnd = new Random();
            result = rnd.Next(2, 6);
            return result;
        }

    }           
}
            //if(lemons > 7 || lemons< 5)
            //{
                
            //}
            //if(sugar > 7 || sugar< 5)
            //{
                 
            //}
            //if(ice > 10 || ice< 6)
            //{
                 
            //}
