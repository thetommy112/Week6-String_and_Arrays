using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab, mitu 'h', 'o', 'l' tähte on lauses "Hello World!"

            string Measurement = "Hello World!".ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for(int i = 0; i < Measurement.Length; i++)
            {
                if (Measurement[i] == 'h')
                {
                    hCounter++;
                }
                else if (Measurement[i] == 'o')
                {
                    oCounter++;
                }
                else if (Measurement[i] == 'l')
                {
                    lCounter++;
                }
            }

            int Sum = hCounter + oCounter + lCounter;

            Console.WriteLine($"Lauses \"{Measurement}\" on {hCounter} 'h' täht, {oCounter} 'o' tähte, {lCounter} 'l' tähte ja kokku on neid {Sum} tükki.");
        }
    }
}
