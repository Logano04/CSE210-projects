public class Customer
{
    private string name;
    private Address address;

    public Customer(string customerName, Address customerAddress)
    {
        name = customerName;
        address = customerAddress;
    }
    public string returnShippingLabelDetails()
    {
        return $"{name}\n{address.returnAddressString()}";
    }

    public bool livesInUS()
    {
        return address.isInUS();
    }
}