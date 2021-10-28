using System;

namespace FridayNightRandomReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            string[] drinks = { "apple juice", "coke", "fanta", "sprite", "water" };
            string[] movies = { "How I met your Mother", "The Hunger Games", "Bond", "Need for Speed", "It 2" };

            randomFood = PickRandomElementFromArray(foods);
            randomDrink = PickRandomElementFromArray(drinks);
            randomMovie = PickRandomElementFromArray(movies);

            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}.");
            Console.WriteLine("Have a nice night!");
        }

        private static int GeneralRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }


 
        private static string PickRandomElementFromArray(string[] someArray)
        {

            string randomElement = someArray[GeneralRandomIndex(someArray)];
            return randomElement;

        }
    }
}
