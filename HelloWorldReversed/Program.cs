using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World!" Tagurpidi
            string Reversee = "Hello World!";

            for(int i = Reversee.Length-1;i >= 0; i--)
            {
                Console.Write(Reversee[i]);
            }
        }
    }
}
