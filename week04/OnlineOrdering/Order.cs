class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;


    //Constructor to get customer details
    public Order(string name, string address)
    {
        _customer = new Customer(name, address);
    }

    //method to add the products
    public void AddProduct(string productName, int productId, double productPrice, int productQuantity)
    {
        Product product = new Product(productName, productId, productPrice, productQuantity);
        _products.Add(product);
    }


    //method to get the total
    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            double productTotal = product.TotalCost();
            total += productTotal;
        }

        if (!_customer.LivesInTheUs())
        {
            total += 35;
            return total;
        }

        return total += 5;
    }

    public string PackingLabel()
    {
        string label = "";

        if (_products.Count <= 0)
        {
            label += "No products are in the cart";
        }

        else
        {
            Console.WriteLine("These are the current items in your cart;\n");
            foreach (Product product in _products)
            {
                string prodName = product.GetProductName();
                int prodId = product.GetProductId();

                label += $"Product Name: {prodName}. Product ID: {prodId}\n";
            }
        }

        return label;
    
    }

    public string ShippingLabel()
    {
        string custName = _customer.GetCustomerName();
        string custAddress = _customer.GetCustomerAddress();

        return $"Customer: {custName}.\n Address: {custAddress}";
    }

}