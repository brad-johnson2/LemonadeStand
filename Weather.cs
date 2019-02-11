using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Weather
    {
        public int temp;
        public int actualTemp;
        public string forecast;
        List<string> forecasts;


        public Weather()
        {
            forecasts = new List<string>() { "sunny", "overcast", "windy", "rainy", "storms" };
            GetWeather();
        }

       

       public void GetWeather()
        {
            temp = GetTemp();
            actualTemp = GetActualTemp();
            forecast = GetForecast();
        }

        public int GetTemp()
        {

            Random rnd = new Random();
            temp = rnd.Next(55, 96);
            return temp;
        }

        public int GetActualTemp()
        {
            int adjust;

            Random rnd = new Random();
            adjust = rnd.Next(-5, 6);
            actualTemp = temp + adjust;
            return actualTemp;
        }

        public string GetForecast()
        {


            Random rnd = new Random();
            int compRand = rnd.Next(1, 6);

            switch (compRand)
            {
                case 1:
                    forecast = forecasts[0];
                    return forecast;
                case 2:
                    forecast = forecasts[1];
                    return forecast;
                case 3:
                    forecast = forecasts[2];
                    return forecast;
                case 4:
                    forecast = forecasts[3];
                    return forecast;
                case 5:
                    forecast = forecasts[4];
                    return forecast;
                default:
                    return null;
            }
        }

        //public static implicit operator Weather(int v)
        //{
        //    throw new NotImplementedException();
        //}

        //public static implicit operator Weather(string v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
