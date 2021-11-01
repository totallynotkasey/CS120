using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {

        //Kasey Henyard
        //CSI 120
        //MidTerm

        

        //Task 1 delcare variables and assign values to them making sure to to choose the correct data type

        decimal task1Num1 = 19.99m;
        int task1Num2 = -120;
        int task1Num3 = 200000000;
        long task1Num4 = -9123456798123;
        double task1Num5 = 9.784;

        //task 2

       //create two int variables
        int task2Num1 = 6;
        int task2Num2 = 9;

        //num1 is not greater than 10
        //num2 is NOT equal to 5 AND NOT EQUAL TO 7
        //num1 is between 20 and 30
        //num2 is NOT between 30 and 40
        //num1 is greater than 5 AND num 2 OR num2 is less than -3
        //num1 is not equal to 3 and not equal to 5

        bool firstBool = task2Num1 < 10;
        bool secondBool = task2Num2 != 5 && task2Num2 != 7;
        bool thirdBool = task2Num1 > 20 && task2Num1 < 30;
        bool fourthBool = task2Num2 < 30 && task2Num2 > 40;
        bool fifthBool = task2Num1 > 5 && task2Num1 > task2Num2 || task2Num2 < -3;
        bool sixthBool = task2Num1 != 3 && task2Num1 != 5;


        //task 3

        //declare float variables
        float firstNum;
        float secondNum;
        float thirdNum;
        float resultNum;

        //set a user prompt to return to upon error
        userPromptTask3:

        //create a try catch for error control
        try
        {
            //request and read three interger values (convert to float for decimal value))
            Console.WriteLine("Please enter your first number");
            firstNum = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            secondNum = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your third number");
            thirdNum = float.Parse(Console.ReadLine());

            //find the avreage of the three values and display it
            resultNum = (firstNum + secondNum + thirdNum) / 3;
            Console.WriteLine($"The average of {firstNum}, {secondNum}, {thirdNum} is {resultNum}");
        }
        catch
        {
            //if we're here we received an invalid value
            Console.WriteLine("Please enter a valid number");
            goto userPromptTask3;
        }
        Console.ReadLine();


        //task 4

        //label and try for error control
        task4UserPrompt:
       try
        {
            //prompt user for number. convert input to integer
            Console.WriteLine("Please give me a number.");
            int task4Num1 = int.Parse(Console.ReadLine());
        //being logic    
        if (task4Num1 % 3 == 0 && task4Num1 % 7 == 0)
            {
                //if we are here the number is evenly divisible by both 3 and 7
                Console.WriteLine($"{task4Num1} is divisible 3 and 7");
            }
            else if (task4Num1 % 3 == 0)
            {
                //if here the number is only divisible by 3
                Console.WriteLine($"{task4Num1} is divisible by 3");
            }
            else if (task4Num1 % 7 == 0)
            {
                //if here then number is only divisible by 7
                Console.WriteLine($"{task4Num1} is divisible by 7");
            }
            else
            {
                //not sure if its possible but just in case 
                Console.WriteLine($"Now how did we get here? {task4Num1}");
            }
        }
        catch
        {
            //if here we received an invalid input we're here and a return to the label we've set above
            Console.WriteLine("Please enter a valid number");
            goto task4UserPrompt;
        }

        Console.ReadLine();



        //task 5

        //request the item quantity and price from the user and set up a label for error control

        task5UserPrompt:
        Console.WriteLine("How much did the item cost?");
        string itemCost = Console.ReadLine();
        Console.WriteLine("How many of them did you buy?");
        string itemAmount = Console.ReadLine();

        //try catch for error control
        try
        {
            //convert inputs to mathable values
            double dblItemCost = double.Parse(itemCost);
            int intItemAmount = int.Parse(itemAmount);
            double finalTotal = dblItemCost * intItemAmount;

            //logic for determining discounts
            if(finalTotal > 1000)
            {
                double grandTotal = finalTotal * .85;
                Console.WriteLine($"Your total before discounts is {finalTotal} you have a 15% discount rate which gives you a grand total of {grandTotal}");
            }
            else if(finalTotal > 500)
            {
                double grandTotal = finalTotal * .90;
                Console.WriteLine($"Your total before discounts is {finalTotal} and you have a 10% discount rate which gives you a total of {grandTotal}");
            }
            else
            {
                Console.WriteLine($"Your total is {finalTotal}");
            }

        }
        catch
        {
            //error message incase values are not convertable and a prompt to return to the preveiously set label
            Console.WriteLine("Please enter a valid number");
            goto task5UserPrompt;
        }
        Console.ReadLine();



        //task 6

        //label to return to for error control
        task6UserPrompt:
            try
            {
                //get x and y input from users and turn them into ints
                Console.WriteLine("Please enter your x value");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your v value");
                int y = int.Parse(Console.ReadLine());

                //logic for determining which quadrant 
                if (x > 0 && y > 0)
                {
                    Console.WriteLine($"You are in the first quadrant {x} and {y}");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine($"You are in the second quadrant {x} and {y}");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine($"You are in the third quadrant {x} and {y}");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine($"You are in the fourth quadrant {x} and {y}");
                }
                else if (x == 0 && y != 0)
                {
                    Console.WriteLine($"You are on the Y axis {x} and {y}");
                }
                else if (y == 0 && x != 0)
                {
                    Console.WriteLine($"You are on the X axis {x} and {y}");
                }
                else
                {
                    Console.WriteLine($"You are at the point of origin {x} and {y}");
                }
            }
            catch
            {
                //if we receive improper values, provide an error and return to the label
                Console.WriteLine("Please enter a valid number.");
                goto task6UserPrompt;
            }
            Console.ReadLine();


        //task 7

        //label for error control
        task7UserPrompt:
        try
        {
            //request value from users and convert them to mathable values
            Console.WriteLine("Please enter the radius");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the height");
            int height = int.Parse(Console.ReadLine());
            //math for determining volume
            double volume = (Math.PI * (Math.Pow(radius, 2))) * height / 3;
            Console.WriteLine($"{volume} is the volume");

        }
        catch
        {
            //error control
            Console.WriteLine("Please enter a valid number");
            goto task7UserPrompt;
        }
        Console.ReadLine();



        //task8
        //set up a pompt to return to on error control
        task8UserPrompt:

        try
        {

            //get input from user and turn it into a mathable value
            Console.WriteLine("Please give an integer value");
            int task8Num1 = int.Parse(Console.ReadLine());

            //logic for the number
            if (task8Num1 % 3 == 0)
            {
                //if here number is evenly divisible by 3
                Console.WriteLine($"{task8Num1}");
            }
            else if (task8Num1 % 3 != 0)
            {
                //if here number not divisible by 3 and find the remainder and quotient 
                int remainder = task8Num1 % 3;
                int finalNum = task8Num1 / 3;
                Console.WriteLine($"{finalNum} with a remainder of {remainder}");
            }
        }
        catch
        {
            Console.WriteLine("Please enter a valid number.");
            goto task8UserPrompt;
        }

        Console.ReadLine();

        

        //task 9
        //prompt the user for a number and set a label to return to for error control
        task9UserPrompt:
            Console.WriteLine("Please enter a number");
            //try catch for error control
            try
            {
                //attempting to get an input from the user and convert it to an int
                int userChoice = int.Parse(Console.ReadLine());
                //attempting to match users input to a choice
                switch(userChoice)
                {
                    case 1:
                        Console.WriteLine("Happy Monday");
                        break;
                    case 2:
                        Console.WriteLine("Happy Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Happy Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Happy Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Happy Friday");
                        break;
                    case 6:
                        Console.WriteLine("Happy Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Happy Sunday");
                        break;
                    default:
                        //if we are here the input we received was converted but did not match a day of the week - return to label as error control
                        Console.WriteLine("Error: Invalid Day of the Week");
                        goto task9UserPrompt;
                        break;

                }
            }
            catch
            {
                //if we are here we did not receive a valid numerical input
                Console.WriteLine("Please enter a valid number");
                goto task9UserPrompt;
            }
            Console.ReadLine();

        }
    }
}
