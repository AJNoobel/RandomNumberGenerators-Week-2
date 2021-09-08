using System;

namespace EpicDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat
            //iga mängija viskab täringut (1-6)
            // arvuti programm kuvab nende visete tulemused ja kuvab ka, kes on võitija
            // - ehk kes viskas suuremat

            Random rnd = new Random();

            string PlayerOne = "Harry Potter";
            string PlayerTwo = "Voldemort";

            int HarryThrow = rnd.Next(1, 7);
            int VoldemortThrow = rnd.Next(1, 7);

            Console.WriteLine($"{PlayerOne} threw {HarryThrow};");
            Console.WriteLine($"{PlayerTwo} threw {VoldemortThrow};");

            if (HarryThrow > VoldemortThrow)
            {
                Console.WriteLine($"{PlayerOne} Wins!");
            }
            else if (HarryThrow < VoldemortThrow) 
            {
                Console.WriteLine($"{PlayerTwo} Wins!");
            }
            else
            {
                Console.WriteLine("Draw! Let them try again.");
            }
        }
    }
}
