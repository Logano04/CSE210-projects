class Reception : Event
{
    private string RSVP;

    public Reception(string eventTitle, string eventDescription, string eventDate, string eventTime, string addressStreet, string addressCity, string addressState, string eventRSVP)
    {
        address = new Address(addressStreet, addressCity, addressState);
        eventType = "Reception";
        title = eventTitle;
        description = eventDescription;
        date = eventDate;
        time = eventTime;
        RSVP = eventRSVP;
    }

    public string receptionFullDetails()
    {
        return $"{standardDetails()} \n RSVP: {RSVP}";
    }
}