using System;
using System.Threading.Tasks;
using Xameteo.Data;
using Xameteo.Model;

namespace Xameteo.Work
{
    public class Core
    {
        public static async Task<Weather> GetWeather(string city)
        {
            string queryString = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid=6b7c9e112046b2c89e55dbec0f31672a";
            dynamic result = await DataService.getDataFromService(queryString).ConfigureAwait(false);
            if (result["weather"] != null)
            {  
               string temperature = (Math.Round((double)result["main"]["temp"]-273)).ToString();               
               string statue = (string)result["weather"][0]["description"];
               string tmpMax = (Math.Round((double)result["main"]["temp_max"]-273)).ToString();               
               string tmpMin = (Math.Round((double)result["main"]["temp_min"]-273)).ToString();               
               Weather weather = new Weather(city, temperature, statue, tmpMax, tmpMin);
               return weather;
            }
            else
            {
                return null;
            }

        }
    }
}
