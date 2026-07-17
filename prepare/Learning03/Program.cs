using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Random random = new Random();

        for (int i = 1; i <= 20; i++)
        {
            int numerator = random.Next(1, 11);
            int denominator = random.Next(1, 11);

            fraction.SetNumerator(numerator);
            fraction.SetDenominator(denominator);

            Console.WriteLine(
                "Fraction " + i +
                ": string: " + fraction.DisplayFraction() +
                " Number: " + fraction.ConvertToDecimal()
            );
        }
    }
}