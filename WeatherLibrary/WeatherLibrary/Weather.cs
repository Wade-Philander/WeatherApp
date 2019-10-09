using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherLibrary
{
    public class Weather
    {
        public static async Task<string> Getweather()
        {
            HttpClient httpClient = new HttpClient();

            string fix = await httpClient.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?q=Cape%20Town&appid=e30a3785da67bd9d83b65bf8933359b5");
            
            forcast meatballs  = JsonConvert.DeserializeObject<forcast>(fix);

            string country = meatballs.sys.country;
            
            int humidity = meatballs.main.humidity;
            
            //double temp = meatballs.main.temp;
            
            double min = meatballs.main.temp_min;
            
            double max = meatballs.main.temp_max;

            var weatherman = "Your weather today is" + country + min + max + humidity;

            return weatherman;
           

            //Console.WriteLine("Humidity" + meatballs);

            return weatherman;




/*            string Weatherforcast = "Max-temp:" + ChanceOfMeetBalls.main.temp + "Min-temp:" + ChanceOfMeetBalls.main.temp + "Temperature" + ChanceOfMeetBalls.main.temp + "Pressure" + ChanceOfMeetBalls.main.temp + "Humidity" + ChanceOfMeetBalls.main.temp;

            string Attributes = string.Empty;

            foreach (var sign in ChanceOfMeetBalls.weather)
            {
                Attributes += "Icon" + sign.icon + "Id" + sign.icon + "Main" + sign.icon;
            }

            string Service = Attributes + "    " + Weatherforcast;

            return Service;
            */
        }
    }
}
