using System;

class Program
{
    static void Main(string[] args)
    {
        Square test1 = new Square("red", 4.0);
        Circle test2 = new Circle("blue", 4.0);
        Rectangle test3 = new Rectangle("green",4.0,2.0);

        Console.WriteLine($"{test1.GetColor()} {test1.GetArea()} ");
        Console.WriteLine($"{test2.GetColor()} {test2.GetArea()} ");
        Console.WriteLine($"{test3.GetColor()} {test3.GetArea()} ");
        List<Shape> shapes = [];
        shapes.Add(test1);
        shapes.Add(test2);
        shapes.Add(test3);

        foreach(Shape shape in shapes){
            Console.WriteLine($"{shape.GetColor()} {shape.GetArea()} ");
            
        }        
    }
}