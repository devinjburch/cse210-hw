Fleet Combat Simulator - Red Rising Themed

This project is a simple console battle game based on the Red Rising book series.
I created two fleets with different types of ships, including RipWings, 
Destroyers, and Dreadnoughts. Each ship has its own health and attack power with 
some random effects. The ships attack each other one at a time until one fleet is 
completely destroyed. This project was done in an effort to prove my understanding
of the Abstraction, Encapsulation, Inheritance and Polymorphism and I will write 
how those were inplemented below. 

I used ABSTRACTION by creating an abstract base class called Ship. This class 
represents the basic idea of a ship and includes the common information and 
methods that every ship needs. The Attack() method is abstract because every 
ship attacks differently.

I used ENCAPSULATION by making the ship variables private. The ship’s name, 
health, and attack power cannot be changed directly from outside the class. 
Instead, I use methods like GetName(), GetStatus(), and TakeDamage() to control 
how the information is accessed or changed.

I used INHERITANCE by creating the RipWing, Destroyer, and Dreadnought classes 
from the main Ship class. This allows all of the ship types to reuse the same 
code instead of repeating the same variables and methods in every class.

I used POLYMORPHISM by overriding the Attack() method in each child class. All 
of the ships are stored in a List<Ship>, but when the program calls Attack(), 
C# automatically runs the correct version based on the actual type of ship.

For future work the possibilities are endless. As of now, the program is a 
simulation that the user only watches. I made it this way to make it easy to
test and not have the grader be stuck in menus or typing lots of text. In a 
future update I would love to gamify this simulation with fun activities like
being given a small amount of time to "Charge up a shot" by hitting the space
bar as many times as poosible to increase a damage modifier. I could also make
more class od ships, have the user make strategic choices etc... In the end this 
was to demonstrate the benefits of certain programming principles and I believe 
this simple project does just that.