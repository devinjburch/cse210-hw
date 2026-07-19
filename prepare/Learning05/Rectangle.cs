//Make a Rectangle class that inherits from the Parent Class Shape
public class Rectangle : Shape
{
    private double _length; //Variable for area
    private double _width;  //Both length and width needed

    
    
    // Constructor for the rectangle
    
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }



    //Calculate the area of a rectangle (A = L*W)
    //Overide the parent class GetArea()
    public override double GetArea()//double used because of expected decimals
    {
        return _length * _width;
    }
}