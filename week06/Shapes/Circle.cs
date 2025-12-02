public class Circle : Shape{
    private double _radius;
    public Circle(double radius):base(){
        _radius = radius;
    }
    public override double GetArea(){
        return 2*Math.PI*_radius;
    }
}