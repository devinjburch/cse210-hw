//Make a parent class for the three shape classes
public class Shape
{
    private string _color;  //Store the color of shape and make it private to this class



    //Constructor for whenever a new shape is made
    public Shape(string color)
    {
        _color = color;
    }




    //Method that gets and returns the color of the shape
    public string GetColor()
    {
        return _color;
    }





    //Method to change the color of the shape
    public void SetColor(string color)
    {
        _color = color;
    }






    //Method includes inheritance.
    //Virtual means the child classes can replace this 
    //method with their own method to get area
    public virtual double GetArea()  //double used because of expected decimals
    {
        return 0;  //If the method isnt repalced return 0
    }
}