using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    internal class Day
    {
        private List<string> forecasts;
        public List<Customer> customers = null;
        int temp;
        Weather weather;

        public Day()
        {
           
            GetWeather();
            customers = new List<Customer>();
            GetCustomers();
        }

        private void GetWeather()
        {
            for (int i = 1; i <= 100; i++)
            {
                weather = new Weather();
            }
        }
        public void GetCustomers()
        {
            for (int i = 0; i <= 100; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
            }
        }
        

    }
}