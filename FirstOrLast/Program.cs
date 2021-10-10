using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikem, kas ees või perekonnanimi

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi:");
            string userFName = Console.ReadLine();

            if(userName.Length < userFName.Length)
            {
                Console.WriteLine("Teie perekonna nimi on pikem, kui teie eesnimi.");
            }
            else if(userName.Length > userFName.Length)
            {
                Console.WriteLine("Teie eesnimi on pikem, kui teie perekonnanimi.");
            }
            else
            {
                Console.WriteLine("Teie ees- ja perekonnanimi on sama pikad.");
            }
        }
    }
}
