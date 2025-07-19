class OutdoorActivity : Event
{
    private string weatherForecast;

    public OutdoorActivity(string eventTitle, string eventDescription, string eventDate, string eventTime, string addressStreet, string addressCity, string addressState, string eventWeather)
    {
        address = new Address(addressStreet, addressCity, addressState);
        eventType = "Outdoor Activity";
        title = eventTitle;
        description = eventDescription;
        date = eventDate;
        time = eventTime;
        weatherForecast = eventWeather;
    }

    public string outdoorActivityFullDetails()
    {
        return $"{standardDetails()} \n weather forecast: {weatherForecast}";
    }
}