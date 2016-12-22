namespace Observer
{
    public interface IParameters
    {
        
    }
    public class WeatherParameters : IParameters
    {
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }
    }
}