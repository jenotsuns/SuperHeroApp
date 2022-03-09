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
            string power2 = "can print new hero dollars";
            string power3 = "never has a bug in code";
            double salary = 1000;
            bool isEvil = false;
            
            Console.WriteLine("************GENERAL INFO*****************");
            Console.WriteLine("           Hero #1           ");
            Console.WriteLine("*****************************\n");
            Console.WriteLine($"    Name: {name}");
            Console.WriteLine($"    Age: {age}");
            Console.WriteLine($"    Gender: {gender}");
            Console.WriteLine($"    Powers: {power1}, {power2}, {power3}\n");

            // Cookie calculation
          /* - Add new variables - deedTimeInHours1, deedTimeInHours2, deedTimeInHours3 (INT), holding time that a deed took to complete
             - Add methods to calculate:
             - Total time spent on deeds
             - Average time spent on one deed
             - How many cookies Hero will get. 5 cookies per hour
                -- Add boughtCookies calculation
                -- isEvil or not
                -- monthlySalary */

            double cookieCost = 1.29;
            double boughtCookies = Math.Floor(salary / cookieCost);
            double dailySalary = Math.Round(salary / 30, 2);
            //int deedTimeInHours1, deedTimeInHours2, deedTimeInHours3
            int deedTimeInHours1 = 15;
            int deedTimeInHours2 = 1;
            int deedTimeInHours3 = 40;
            double paybackMoney = (deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3);
            salary += paybackMoney;
             var totalDeedTime = (deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3);
            var averageDeedTime = totalDeedTime/3;
            

            Console.WriteLine("Please enter your grade:");
            char deedGrade = Console.ReadLine();   // Fix later Parse
            Console.ReadLine();
           switch (deedGrade)
            {
                case 'A':
                case 'B':
                    Console.WriteLine("Perfect! You are so brave!");
                    break;
                case 'C':
                    Console.WriteLine("Good! But You can do better!");
                    break;
                case 'D':
                case 'E':
                    Console.WriteLine("It is not good! You should choose your bad or good side!");
                    break;
                case 'G':
                    Console.WriteLine("Bad, you are true villain");
                    break;
                default:
                    Console.WriteLine($"{name}, you need to work harder, but this isn't the end of the world! :)");
                    break;
            }
            

            Console.WriteLine("************FINANCIAL INFO***************\n");
            Console.WriteLine($"    {name} can buy {boughtCookies} cookies");
            Console.WriteLine($"    {name} earns  {dailySalary} hero dollars daily");
            Console.WriteLine($"    His monthly income is {salary} hero dollars");

            Console.WriteLine($"    {name} spends {averageDeedTime} hours on a task");
            Console.WriteLine($"    {name} spends {totalDeedTime} hours on tasks in total");
            //Console.WriteLine($"Cookies he can buy: {boughtCookies}");

            if (!isEvil)
            {
            Console.WriteLine($"\n    {name} protects the city and earns his cookies!");
            }
            else
            {
            Console.WriteLine("The villain is stealing the cookie supply!");
            }
            }
            }
            }