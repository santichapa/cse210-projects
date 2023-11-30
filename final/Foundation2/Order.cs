class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new();
    }

    public decimal CalculateTotal()
    {
        decimal subtotal = 0;
        decimal total;
        foreach (Product p in _products)
        {
            subtotal += p.GetPrice();
        }
        if (_customer.GetAddress().CheckLocality())
        {
            total = subtotal + 5;
        }
        else
        {
            total = subtotal + 35;
        }
        return total;
    }
    public string RenderPackingLabel()
    {
        string titles = "---Order Details---\n|Product Id\t|Product Name\t\t\t\t|Price\t\t|Quantity";
        string productsList = ""; 
        foreach (Product p in _products)
        {
            string row = p.RenderPoductRow();
            productsList += $"{row}"; 
        }
        return $"\n{titles}\n{productsList}";
        
    }
    public string RenderShippingText()
    {
        string address = _customer.GetAddress().GetRenderedAdress();
        return $"\n---Shipping Label---\n{_customer.GetName()}\n{address}";
    }
    public void AddProduct(Product p)
    {
        _products.Add(p);    
    }
}