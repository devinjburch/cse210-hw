//Make a Square class that inherits from the Parent Class Shape
public class Square : Shape
{
    private double _side;  //variable for one side of a square






    public Square(string color, double side)// Constructor for square class
        : base(color)
    {
        _side = side;
    }




    //Calculate the area of a square (A = L^2)
    //Overide the parent class GetArea()
    public override double GetArea()//double used because of expected decimals
    {
        return _side * _side;
    }
}