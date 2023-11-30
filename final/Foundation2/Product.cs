class Product 
{
    private int _productId;
    private string _productName;
    private decimal _productPrice;
    private int _productQuantity;

    public Product(int id, string name, decimal price, int quantity)
    {
        _productId = id;
        _productName = name;
        _productPrice = price;
        _productQuantity = quantity;
    }

    public decimal GetPrice()
    {
        return _productPrice * _productQuantity;
    }
    public string RenderPoductRow()
    {
        return $"|{_productId}\t\t|{_productName, -39}|$ {_productPrice, -13}|{_productQuantity}\n";
    }
}