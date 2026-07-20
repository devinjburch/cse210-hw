using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Diplay the name of the game
        Console.WriteLine("RED RISING FLEET COMBAT");
        Console.WriteLine("=======================\n");

        //*************POLYMORPHISM*****************
        //Each ship type can be treated as 'ships'
        //Make a list that can store all ship types
        List<Ship> risingFleet = new List<Ship>  //First Fleet
        {
            new RipWing("Howler RipWing"),
            new Destroyer("Morning Star"),
            new Dreadnought("Pax")
        };




        List<Ship> societyFleet = new List<Ship> //Second Fleet
        {
            new RipWing("Olympic RipWing"),
            new Destroyer("Society Destroyer"),
            new Dreadnought("Invictus")
        };



        //Display each fleet before the battle start
        DisplayFleet("Rising Fleet", risingFleet);
        DisplayFleet("Society Fleet", societyFleet);
        Thread.Sleep(10000);



        //Variables to track turns and battle rounds
        int risingShipNumber = 0;
        int societyShipNumber = 0;
        int round = 1;






        //Continue the game until one side doesn't have ships
        //if risingFleet.Count is equal to risingShipNumber there are none left (same with society)
        while (risingShipNumber < risingFleet.Count && societyShipNumber < societyFleet.Count)
        {
            //Display the updated round number
            Console.WriteLine($"\n--- Round {round} ---");


            Ship risingShip = risingFleet[risingShipNumber];   //Get the current Rising Ship
            Ship societyShip = societyFleet[societyShipNumber];//Get the current Society Ship

            int damage = risingShip.Attack(); //The Rising ship attacks first

            societyShip.TakeDamage(damage); //Have the society ship take the damage

            //Display the results of the attack
            Console.WriteLine($"{risingShip.GetName()} attacks " + $"{societyShip.GetName()} for {damage} damage.");

            Console.WriteLine(societyShip.GetStatus()); //Show society ships health

            //Move to the next Society ship if this one is destroyed
            if (societyShip.IsDestroyed())
            {
                Console.WriteLine($"{societyShip.GetName()} has been destroyed!"); //tell the user the ship is toast

                societyShipNumber++; //move to new society ship
            }
            else
            {
                //Society ship attacks Rising ship
                damage = societyShip.Attack();
                //Rising ship take damage
                risingShip.TakeDamage(damage);

                //Display the results of the attack
                Console.WriteLine($"{societyShip.GetName()} attacks " + $"{risingShip.GetName()} for {damage} damage.");
                
                //Show society ships health
                Console.WriteLine(risingShip.GetStatus());


                //Move to the next Rising ship if this one is destroyed
                if (risingShip.IsDestroyed())
                {
                    Console.WriteLine($"{risingShip.GetName()} has been destroyed!"); //tell the user the ship is toast
                    risingShipNumber++; //move to new rising ship
                }
            }
            Thread.Sleep(7000);
            round++; //moce to the next round
        }

        Console.WriteLine("\n=======================");


        // Display the winning fleet
        if (risingShipNumber < risingFleet.Count)
        {
            Console.WriteLine("The Rising Fleet wins!");
        }
        else
        {
            Console.WriteLine("The Society Fleet wins!");
        }

        Console.WriteLine("=======================");
    }







    //Method that displays name and health each and every ship in a fleet
    static void DisplayFleet(string fleetName, List<Ship> fleet)
    {
        Console.WriteLine(fleetName);

        foreach (Ship ship in fleet) //Loop through the list of ships
        {
            Console.WriteLine($"- {ship.GetStatus()}");  //Display health and name
        }

    }
}