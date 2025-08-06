namespace Weather_App.Models
{
    public class WeatherResponse
    {
        public Main main { get; set; }
        public List<Weather> weather { get; set; }
        public Wind wind { get; set; }
        public string name { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public int humidity { get; set; }
    }

    public class Weather
    {
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
    }
}
