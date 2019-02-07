using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    internal class Day
    {
        private List<string> forecasts;
        List<Customer> customers;
        int temp;
        Weather weather;

        public Day()
        {
            GetCustomers();
            GetWeather();
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
            for (int i = 1; i <= 100; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
            }
        }
        

    }
}