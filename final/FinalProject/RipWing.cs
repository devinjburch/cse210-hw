//In Red Rising a RipWing is a small quick ship and will deal small random damage
//This method will inherit from Ship
public class RipWing : Ship
{
    public RipWing(string name) //Ripwing constructor
        : base(name, 35, 7)     //Starts with 35 health 7 attack
    {
    }



    //The override will replace the attack method from the Ship class.
    public override int Attack()
    {
        //RipWing will deal between 5 and 11 damage at random
        return GetRandomNumber(GetAttackPower() - 2,GetAttackPower() + 4);
    }
}