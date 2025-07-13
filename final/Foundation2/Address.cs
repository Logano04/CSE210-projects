public class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    public Address(string streetAddressString, string cityString, string stateString, string countryString)
    {
        streetAddress = streetAddressString;
        city = cityString;
        state = stateString;
        country = countryString;
    }
    public bool isInUS()
    {
        if (country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string returnAddressString()
    {
        return $"{streetAddress}\n{city}, {state}\n{country}";
    }
}