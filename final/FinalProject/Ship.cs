using System;

//Abstract base class for every ship
public abstract class Ship
{
    //******************ENCAPSULATION************************ 
    //These are the variable I'll use for this class and other class cannot 
    //access or change them
    private string _name;
    private int _health;
    private int _attackPower;

    //Static means one copy of it
    private static Random _random = new Random();




    //Base Ship Constructor - Starting Values For Name, Health and Attack Power
    public Ship(string name, int health, int attackPower)
    {
        _name = name;
        _health = health;
        _attackPower = attackPower;
    }



    //method for other classes to see a ships name
    public string GetName()
    {
        return _name;
    }





    //method for displaying current health
    public int GetHealth()
    {
        return _health;
    }





    //method to use attack power and can only be used by parent and child classes
    protected int GetAttackPower()
    {
        return _attackPower;
    }



    //Method to allow child classes to create random attacks within min and max
    protected int GetRandomNumber(int minimum, int maximum)
    {
        return _random.Next(minimum, maximum + 1);
    }





    //***********ABSTRACTION*************
    //Make an abstract method to create an attack for each ship
    public abstract int Attack();






    //This method will removes health when the ship is attacked
    public void TakeDamage(int damage)
    {
        _health -= damage; //Subtract damage from health

        //Health cannot go below zero
        if (_health < 0)
        {
            _health = 0;
        }
    }






    //Method that checks if the ship has been destroyed
    public bool IsDestroyed()
    {
        return _health <= 0;
    }





    //Method to check a ships name and current health
    public string GetStatus()
    {
        return $"{_name}: {_health} health";
    }
}