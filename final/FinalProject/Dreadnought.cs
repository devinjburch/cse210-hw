//The Dreadnaught will be a large ship with high health and powerful attacks
//Inherits from Ship class
public class Dreadnought : Ship
{
    public Dreadnought(string name) //Constructor for Destroyer
        : base(name, 150, 25)        //Starts with 80 health 15 attack
    {
    }


    //The override will replace the attack method from the Ship class.
    public override int Attack()
    {
        //Dreadnoughts will deal between 25 and 45 damage
        return GetRandomNumber(GetAttackPower(),GetAttackPower() + 20);
    }
}