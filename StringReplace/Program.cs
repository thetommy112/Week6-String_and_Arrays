using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab k]ik 'o' t'hed lauses "Hello World!" t'rniga *

            string helloW = "Hello World!";

            /*  for(int i = 0; i < helloW.Length; i++)
            {
                helloW[i] = //Sõnad on muutumatu andmetüüp
            } */

            helloW = helloW.Replace('o', '*');
            helloW = helloW.Replace('!', '1');
            Console.WriteLine(helloW);
        }
    }
}
