class Product
{
    public string name;
    public int productID;
    public int pricePerUnit;
    public int quantity;

    public int totalCost()
    {
        int total = quantity * pricePerUnit;
        return total;
    }
}