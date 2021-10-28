using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomJoke;
            randomJoke = GetRandomFromFile("chuck.txt");

            Console.WriteLine($"{randomJoke}");
        }
        private static int GeneralRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

        private static string GetRandomFromFile(string fileName)
        {
            string randomJoke = ($@"C:\Koolistuff\TKTK\TKTK 2021\Programeerimine\Nädal 8 -failid\chuck.txt");
            string[] dataFromFile = File.ReadAllLines(randomJoke);
            string randomElement = dataFromFile[GeneralRandomIndex(dataFromFile)];

            return randomElement;
        }

    }
}
