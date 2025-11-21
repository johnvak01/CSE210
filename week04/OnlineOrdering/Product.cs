class Product{
    private string _name;
    private int _productID, _quantity;
    private double _price;

    public Product(string name, int id, int quant, double price){
        _name = name;
        _productID = id;
        _quantity = quant;
        _price = price;
    }

    public double TotalCost(){
        return (double)_quantity*_price;
    }
    public string Display(){
        return $"{_productID}\t{_name}:\t{_quantity} x ${_price}";
    }
}