using System.Runtime.CompilerServices;

public class Square: Shape{
    private double _length;
    public Square(double length):base(){
        _length = length;
    }
    public override double GetArea(){
        return _length*_length;
    }
}