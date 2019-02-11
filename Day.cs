using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    internal class Day
    {
        public List<Customer> customers = null;
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
            for (int i = 0; i <= 1000; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
            }
        }
        

    }
}