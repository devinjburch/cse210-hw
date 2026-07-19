using System;
//Make a Circle class that inherits from the Parent Class Shape
public class Circle : Shape
{
    private double _radius; //The only variable I need for calculation of area




    //Constructor for circle
    public Circle(string color, double radius)
        : base(color)
    {
        _radius = radius;
    }




    //Calculate the area of a circle (A = Pi*r^2)
    //Overide the parent class GetArea()
    public override double GetArea()//double used because of expected decimals
    {
        return Math.PI * _radius * _radius;
    }
}