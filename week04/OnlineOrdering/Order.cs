using System.Collections.Generic;
class Order{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer cust){
        _products = products;
        _customer = cust;
    }
    private double calcShippingCost(){
        if(_customer.InUSA()){
            return 5.00;
        }else{
            return 35.00;
        }
    }
    public double calcTotalCost(){
        double total = calcShippingCost();
        for(int x = 0; x < _products.Count;x++){
            total += _products[x].TotalCost();
        }
        return total;
    }
    public string PackingLabel(){
        string output = "";
        for(int x = 0; x < _products.Count;x++){
            output += "\n" + _products[x].Display();

        }
        return output;
    }
    public string ShippingLabel(){
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}