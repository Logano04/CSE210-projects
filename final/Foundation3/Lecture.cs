class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string eventTitle, string eventDescription, string eventDate, string eventTime, string addressStreet, string addressCity, string addressState, string eventSpeaker, int eventCapacity)
    {
        address = new Address(addressStreet, addressCity, addressState);
        eventType = "Lecture";
        title = eventTitle;
        description = eventDescription;
        date = eventDate;
        time = eventTime;
        speaker = eventSpeaker;
        capacity = eventCapacity;
    }

    public string lectureFullDetails()
    {
        return $"{standardDetails()} \n Speaker: {speaker} - Capacity: {capacity}";
    }
}