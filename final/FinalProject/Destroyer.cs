//The Destroyer will deal consistant damage
//Inherits from Ship class
public class Destroyer : Ship
{
    public Destroyer(string name) //Constructor for Destroyer
        : base(name, 55, 15)      //Starts with 55 health 15 attack
    {
    }

    //The override will replace the attack method from the Ship class.
    public override int Attack()
    {
        //Destroyers always deal 15 damage
        return GetAttackPower();
    }
}