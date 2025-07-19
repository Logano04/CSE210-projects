class Address
{
    private string streetAddress;
    private string city;
    private string state;

    public Address(string streetAddressString, string cityString, string stateString)
    {
        streetAddress = streetAddressString;
        city = cityString;
        state = stateString;
    }

    public string returnAddressInfo()
    {
        return $"{streetAddress} - {city}, {state}";
    }
}