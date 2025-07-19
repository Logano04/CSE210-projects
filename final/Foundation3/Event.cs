class Event
{
    public string title;
    public string description;
    public string date;
    public string time;
    public string eventType;
    public Address address;

    public string standardDetails()
    {
        return $"{title} \n {description} \n {date}, {time} \n location: {address.returnAddressInfo()}";
    }

    public string shortDescription()
    {
        return $"Event type: {eventType} \n Title: {title} \n Time: {time}";
    }
}