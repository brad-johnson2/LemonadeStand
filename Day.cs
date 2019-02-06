using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    internal class Day
    {
        private List<string> forecasts;
        List<Customer> customers;
        int temp;

        public Day()
        {
            forecasts = new List<string>() { "sunny", "overcast", "windy", "rainy", "storms" };
            GetCustomers();
        }

        public void GetCustomers(){
            for (int i = 1; i <= 100; i++)
                {
                    Customer customer = new Customer();
                    customers.Add(customer);
                }
        
        public void GetTemp()
            {

                Random rnd = new Random();
                temp = rnd.Next(55, 96);
                Console.WriteLine(temp);
            }

            public void GetActualTemp()
            {
                int adjust;

                Random rnd = new Random();
                adjust = rnd.Next(-5, 6);
                int actualTemp = temp + adjust;
            }

            public void GetForecast()
            {
                string forecast;

                Random rnd = new Random();
                int compRand = rnd.Next(1, 6);

                switch (compRand)
                {
                    case 1:
                        forecast = forecasts[0];
                        break;
                    case 2:
                        forecast = forecasts[1];
                        break;
                    case 3:
                        forecast = forecasts[2];
                        break;
                    case 4:
                        forecast = forecasts[3];
                        break;
                    case 5:
                        forecast = forecasts[4];
                        break;
                    default:
                        break;
                }
            }
    }
}