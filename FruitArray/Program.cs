﻿using System;

namespace FruitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis puuvilija kasutaja sööb
             string[] fruit = new string[5] { "an apple", "a banana", "a lemon", "an orange", "some grapes" };

            /* Console.WriteLine("enter a number from 0 to 4:");
            int userNumber = Convert.ToInt32(Console.ReadLine()); */

            Random rnd = new Random();
            int userNumber = rnd.Next(0, fruit.Length);

            Console.WriteLine($"Today you will have {fruit[userNumber]}.");
        }
    }
}
