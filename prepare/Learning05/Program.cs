using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Make a list that can hold my shape objects
        List<Shape> shapes = new List<Shape>();

        
        
        //Make one of each shape and add them to my new list

        shapes.Add(new Square("Red", 5));         //Make a Red Square with l=5
        shapes.Add(new Rectangle("Blue", 4, 6));  //Make Blue Rectangle with l=4,w=6
        shapes.Add(new Circle("Green", 3));       //MAke Green Circle with r=3

        //Cycle through the shapes of my list
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");//Display the color of the shape
            Console.WriteLine($"Area: {shape.GetArea()}");  //Display the area of the shape (Inheritance)
        }
    }
}