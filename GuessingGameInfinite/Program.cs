using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);
            bool loopActive = true;
            while (loopActive)
            {
                Console.WriteLine("Vali number 1-10:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuRandom == userNumber)
                {
                    Console.WriteLine("Palju õnne! Oled võitnud");
                    //break;
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Proovi uuesti.");
                }
            }

            Console.WriteLine("kena päeva.");        
        }
    }
}
