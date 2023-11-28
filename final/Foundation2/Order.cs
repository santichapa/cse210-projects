class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new();
    }

    public int CalculateTotal()
    {
        return 0;
    }
    public string RenderLabelText()
    {
        return "";
    }
    public string RenderShippingText()
    {
        return "";
    }
}