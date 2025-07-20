class Product
{
    private string name;
    private int productID;
    private double pricePerUnit;
    private int quantity;

    public Product(string productName, int ID, double PPU, int productQuantity)
    {
        name = productName;
        productID = ID;
        pricePerUnit = PPU;
        quantity = productQuantity;
    }
    public int totalCost()
    {
        int total = (int)(quantity * pricePerUnit);
        return total;
    }

    public string returnPackingListDetails()
    {
        return $"{name} - {productID}";
    }
}