
public class Rectangle: Shape{
    private double _length, _width;
    public Rectangle(double length, double width):base(){
        _length = length;
        _width = width;
    }
    public override double GetArea(){
        return _length*_width;
    }
}