using System.Runtime.CompilerServices;

public class Square: Shape{
    private double _length;
    public Square(string color, double length):base(color){
        _length = length;
    }
    public override double GetArea(){
        return _length*_length;
    }
}