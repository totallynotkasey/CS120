using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_and_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kasey Henyard
            //CS 120
            //Lab 6 Loops and Randoms


            //task 2 - use a while loop to create the following output

            //declare variables
            int task1Num1 = 0;

            //while task1Num1 is less than 10..
            while (task1Num1 < 10)
            {
                //write it to the console and increase the value of it by one
                Console.Write($"{task1Num1} ");
                task1Num1++;
            }

            Console.ReadLine();
            //end of task 1

            //task 2 - use a for loop

            //starting at i(1) as long as i less than 10, with an increment of 2
            for (int i = 1; i < 10; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //end of ask 2


            //task3 Write a C# program that gets a positive integer number from the user. Use a loop to add up all numbers less than the user number and display the total
           
           //get input from user and delcare variables 
            Console.WriteLine("Please enter a positive integer number");

            int task3Num1 = int.Parse(Console.ReadLine());
            int varTotal = 0;

            //while the number we received from the user is greater than zero
           while (task3Num1 > 0)
            {
                //take 1 from it and add it to the total
                task3Num1--;
                varTotal += task3Num1;

            }
            //write the total of those numbers
            Console.WriteLine($"The total is {varTotal}");
            Console.ReadLine();
            //end of task 3

            
            //task4 Write a program that gets a positive integer from the user and use a loop to the detect if the number is Prime
            //this was a little confusing but I think I got it right

            //declare variables and get input from user
            Console.Write("Enter a Number to see if its prime");
            bool IsPrime = true;
            int number = int.Parse(Console.ReadLine());
            
            
            //Loop to check and see if the number is prime or not
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            
            //reporting if the number is prime or not
            if (IsPrime)
            {
                Console.Write("Number is Prime.");
            }
            else
            {
                Console.Write("Number is not Prime.");
            }
            Console.ReadKey();
            
            //end of task 4

            //task 5 write a program that will loop 10 random numbers between 0-99 inclusive

            //declare new randomclass
            Random task5RandomNum = new Random();

            //for loop which runs 10 times
            for (var i = 0; i < 10; i++)
            {
                //Print a random number
                Console.WriteLine(task5RandomNum.Next(100));
            }

            Console.ReadLine();

            //end of task 5
        }
    }
}
