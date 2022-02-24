/*
Lesson #3 Data types and variables
Very nice
*/


using System;




namespace SuperHero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Brokolis";
            int age = 23;
            char gender = 'm';
            string power1 = "Full fridge full-ination";
            string power2 = "Can stop wars";
            string power3 = "Never has a bug in code";

            
            Console.WriteLine("*****************************");
            Console.WriteLine("           Hero #1           ");
            Console.WriteLine("*****************************\n");
            Console.WriteLine($"    Name: {name}");
            Console.WriteLine($"    Age: {age}");
            Console.WriteLine($"    Gender: {gender}");
            Console.WriteLine($"    Powers: {power1}, {power2}, {power3}");
        }
    }
}