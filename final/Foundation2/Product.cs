
class Product
{
    private string _name;
    private int _productID;
    private float _price;
    private int _quantity;
    public Product(string name, int ID,float price, int num)
    {
        _name = name;
        _productID = ID;
        _price = price;
        _quantity = num;
    }
    public float CalcCost()
    {
        return _price * _quantity;
    }
    public string MakePackLabel()
    {
        return _name + ' '+ _productID;
    }
}
