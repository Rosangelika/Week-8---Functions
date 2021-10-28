using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }
        private static int GeneralRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }


        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };

            Console.WriteLine($"Computer picked food: {foods[GeneralRandomIndex(foods)]}");

        }
        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite", "water"};
           
            Console.WriteLine($"Computer picked drink: {drinks[GeneralRandomIndex(drinks)]}");
        }
        private static void DisplayRandomMovie()
        {
            string[] movies = { "How I met your Mother", "The Hunger Games", "Bond", "Need for Speed", "It 2" };

            Console.WriteLine($"Computer picked movie: {movies[GeneralRandomIndex(movies)]}");
        }
    }
}
