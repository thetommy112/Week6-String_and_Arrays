using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab k]ik 'o' t'hed lauses "Don't Panic!" nulliga - 0
            //programm asendab k]ik 'a' t'hed samas lauses 4-ga

            string dontP = "Don't Panic!";

            dontP = dontP.Replace('o', '0');
            dontP = dontP.Replace('a', '4');

            Console.WriteLine(dontP);
        }
    }
}
