
// Derived OutdoorGathering class representing outdoor gatherings with weather forecast attribute
public class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    // Getter method for weather forecast
    public string GetWeatherForecast()
    {
        return weatherForecast;
    }

    // Override FullDetails method to include outdoor gathering-specific details
    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nWeather Forecast: {weatherForecast}";
    }
}