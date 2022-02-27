using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!";
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti.";
            //kasutajal on kolm katset;

            Console.WriteLine("Sisestage kasutajatunnus ja salasõna. Teil on 3 katset.");
            Console.WriteLine("" + "");

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("" + "");
                Console.WriteLine("Salasõna:");
                string userPassword = Console.ReadLine();
                Console.WriteLine("" + "");

                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++;
                    if (i == 1)
                    {
                        Console.WriteLine($"Vale kasutajatunnus või salasõna. Proovige uuesti, Teil on {3 - i} katset.");
                        Console.WriteLine("" + "");
                    }
                    else if (i == 2)
                    {
                        Console.WriteLine($"Vale kasutajatunnus või salasõna. Proovige uuesti, Teil on veel {3 - i} katse.");
                        Console.WriteLine("" + "");
                    }
                    else
                    {
                        Console.WriteLine($"Vale kasutajatunnus või salasõna. Kolm katset on kasutatud, proovige 24h pärast uuesti.");
                    }
                }
            }
        }
    }
}
