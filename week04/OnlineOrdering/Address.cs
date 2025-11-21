using System.Security.Authentication;

class Address{
    private string _streetAddress, _city, _province, _country;
    public Address(string street, string city, string province, string country){
        _streetAddress = street;
        _city = city;
        _province = province;
        _country = country;
    }
    public bool InUSA(){
        return _country == "USA";
    }
    public string Display(){
        return $"{_streetAddress}\n{_city}, {_province}, {_country}";
    }
}