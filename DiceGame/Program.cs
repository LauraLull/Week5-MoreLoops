using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontollib, kumb mängija viskas rohkem;
            //mängija, kes viskab rohkem, ongi mängu võitja;
            //*täringuid visatakse kolm korda;
            //proramm kuulutab võitja.

            Random rnd = new Random();
            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {
                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise
                int userRandom = rnd.Next(1, 7);

                cpuScore = cpuScore + cpuRandom;
                userScore = userScore + userRandom;

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");

                if (i < 2)
                {
                    Console.WriteLine("" + "");
                    Console.WriteLine("Uuesti viskamiseks vajuta klahvi ''enter'':");
                    string userName = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("" + "");
                    Console.WriteLine("Tulemuste kuvamiseks vajuta klahvi ''enter'':");
                    string userName = Console.ReadLine();
                }
            }

            if(cpuScore < userScore)
            {
                Console.WriteLine($"Arvuti viskas kokku {cpuScore} punkti. Kasutaja viskas kokku {userScore} punkti.");
                Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
            }
            else if(cpuScore > userScore)
            {
                Console.WriteLine($"Arvuti viskas kokku {cpuScore} punkti. Kasutaja viskas kokku {userScore} punkti.");
                Console.WriteLine("Arvuti on mängu võitnud.");
            }
            else
            {
                Console.WriteLine($"Arvuti viskas kokku {cpuScore} punkti ja kasutaja visaks samuti {userScore} punkti.");
                Console.WriteLine("Viik!");
            }
        }
    }
}
