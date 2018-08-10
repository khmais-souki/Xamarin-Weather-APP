namespace Xameteo.Model
{
    public class Weather
    {
        public string city { get; set; } ="" ;
        public string temperature { get; set; } ="" ;
        public string statue { get; set; } ="" ;
        public string tmpMax { get; set; } ="" ;
        public string tmpMin { get; set; } ="" ;  

   

        public Weather(string city, string temperature, string statue, string tmpMax, string tmpMin)
        {
            this.city = city;
            this.temperature = temperature;            
            this.statue = statue;
            this.tmpMax = tmpMax;
            this.tmpMin = tmpMin;
        }
        public Weather()
        {
            city = null;
            temperature= null;
            statue = null;
            tmpMax = null;
            tmpMin = null;

        }
    }
}
