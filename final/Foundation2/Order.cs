class Order
{
    Customer customer;
    public List<Product> productsList;
    public int totalCost;

    public Order(Customer orderCustomer)
    {
        productsList = new List<Product>();
        customer = orderCustomer;
    }

    public double calculateTotalCost()
    {
        foreach (Product product in productsList)
        {
            totalCost += product.totalCost();
        }
        if (customer.livesInUS() == true)
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    public void addProduct(Product product)
    {
        productsList.Add(product);
    }
    public string shippingLabel()
    {
        return customer.returnShippingLabelDetails();
    }
    public void packingLabel()
    {
        foreach (Product product in productsList)
        {
            Console.WriteLine(product.returnPackingListDetails());
        }
    }
}