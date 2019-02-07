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
            Weather[] weather = { temp, actualTemp, forecast };
        }

        //methods 
        public void GetTemp()
        {

            Random rnd = new Random();
            temp = rnd.Next(55, 96);
        }

        public void GetActualTemp()
        {
            int adjust;

            Random rnd = new Random();
            adjust = rnd.Next(-5, 6);
            actualTemp = temp + adjust;
        }

        public void GetForecast()
        {


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

        public static implicit operator Weather(int v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Weather(string v)
        {
            throw new NotImplementedException();
        }
    }
}
