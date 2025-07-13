class Order
{
    Customer customer = new Customer();
    List<Product> productsList;
    int totalCost;

    public void calculateTotalCost()
    {
        foreach (Product product in productsList)
        {
            totalCost += product.totalCost();
        }
        if (customer.address.isInUS() == true)
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
    }
    public string shippingLabel()
    {
        return $"{customer.name}\n{customer.address.returnAddressString()}";
    }
    public List<string> packingLabel()
    {
        List<string> packingList = new List<string>();
        foreach (Product product in productsList)
        {
            packingList.Add($"{product.name} - {product.productID}");
        }
        return packingList;
    }
}