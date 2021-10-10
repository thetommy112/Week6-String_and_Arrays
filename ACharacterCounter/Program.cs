using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm k[sib kasutajal sisestada ees ja perekonnanime
            //programm kuvab, mitu 'a' t'hte on kasutaja ees- ja perekonnanimes kokku

            Console.WriteLine("Palun sisesta oma eesnimi:");
            string firstName = Console.ReadLine().ToLower();
            Console.WriteLine("Palun sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine().ToLower();

            string fullName = $"{firstName}{lastName}".ToLower();

            int aCounter = 0;

            for(int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'a')
                {
                    aCounter++;
                }
            }

            if(aCounter != 1)
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} a tähte.");
            }
            else
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} a täht.");
            }
        }
    }
}
