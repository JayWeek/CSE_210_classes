class Product
{
    private string _productName;
    private int _productId;
    private double _productPrice;
    private int _productQuantity;

    //Constructor to instantiate objects
    public Product(string productName, int productId, double productPrice, int productQuantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    //method to calculate total
    public double TotalCost()
    {
        return _productPrice * _productQuantity;
    }

    //setting up the getter for productname and id
    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductId()
    {
        return _productId;
    }
}