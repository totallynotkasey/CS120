using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kasey Henyard
            //CS120
            //Project 4
            //In this project we will use decision making with IF/Else and using labels and goto to create a loop for when an incorrect value is entered. 
            

            //declare some variables and ask for an input and also set a label
            int num1, num2;
            promptUser0:
            
            Console.WriteLine("Please enter two integer numbers");
            //try for error handling
            try
            {
                //ask user for two numbers
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
                //begin the logic to check and see if they are the same number
                if (num1 == num2)
                {
                    //if I am here they are the same number
                    Console.WriteLine($"{num1} is equal to {num2}");
                }
                else
                {
                    //if I am here they are not the same number
                    Console.WriteLine($"{num1} is not equal to {num2}");
                }
            }
            catch
            {
                //if I am here they gave me an invalid input - return to label set earlier to loop program
                Console.Write("Please enter a valid input\n");
                goto promptUser0;
            }

            Console.WriteLine("*****=====END OF TASK 1====****");
            Console.ReadLine();

            
             
           
             
            //declare some variables
            int num3;
            //adding a label 
            promptUser1:
            //ask the user for input and convert the string to numbers
            Console.WriteLine("Please enter an integer number");
           

            //first check and see if the value that was entered is even mathable
            try 
            {
                num3 = Convert.ToInt32(Console.ReadLine());
                //if num1 is even (divisible by 2 with no remainder)
                if (num3 % 2 == 0)
                    {
                    Console.WriteLine($"{num3} is even");

                    }
                //if num1 isn't even (a remainder when dividing by 2)
                else if (num3 % 2 != 0)
                {
                    Console.WriteLine($"{num3} is odd");
                }
            }
            catch
            {
                //if math can't be done then go here to tell them to put in a correct number
                Console.WriteLine("Error: Please enter a whole integer number");
                //going to that label
                goto promptUser1;
            }

            Console.WriteLine("*****=====END OF TASK 2====****");
            
            Console.ReadLine();
            
            
            
            int num4;

            //ask the user for input and set a prompt to return to

            promptUser2:
            Console.WriteLine("Please enter an integer number");
            num4 = Convert.ToInt32(Console.ReadLine());

            try
            {
                //if the number is positive
                if ( num4 > 0 )
                {
                    Console.WriteLine($"{num4} is positive");
                }
                //if the number is negative
                else if (num4 < 0)
                {
                    Console.WriteLine($"{num4} is negative");

                }
                //if its not positive or negative then its zero (which is even for some reason)
                else
                {
                    Console.WriteLine($"{num4} is zero");
                }
            }
            catch
            {
                //input is not mathable if we're here
                Console.WriteLine("Error: Please enter a valid integer number");
                goto promptUser2;

            }
            Console.WriteLine("*****=====END OF TASK 3====****");

            Console.ReadLine();
            
            

            //declare variables and set a label point
            int num5;

            promptUser3:

            //ask the user how old they are
            Console.WriteLine("How old are you?");
            try
            {
                //try to convert the users age input to a number
                num5 = Convert.ToInt32(Console.ReadLine());
                //check to see how hold they are
                if (num5 >= 18)
                {
                    Console.WriteLine("Congrats you can vote!");
                }
                else
                {
                    Console.WriteLine("You can not vote.");
                }
            }
            catch
            {
                //if a valid number is not entered, display the error and return to the label 
                Console.WriteLine("Error: Please a valid number");
                goto promptUser3;
            }
            Console.WriteLine("*****=====END OF TASK 4====****");
            Console.ReadLine();
            
            

            //declare variables
            int mathScore, sciScore, langScore;

            //prompt the user for 3 test scores 
            //also set a prompt return point in case of errors
            promptUser4:
            Console.WriteLine("Please enter a math score, science score and language score");
            try 
            {
                
                //convert the inputs to mathable values
                mathScore = Convert.ToInt32(Console.ReadLine());
                sciScore = Convert.ToInt32(Console.ReadLine());
                langScore = Convert.ToInt32(Console.ReadLine());
                //create a new floating point variable because we're doing division with a remainder
                float scoreAvg = mathScore + sciScore + langScore;
                                

                //starting to see where they qualify for scholarship
                if (scoreAvg/3 >= 80)
                {
                    //if we're here the average of all 3 scores are 80
                    Console.WriteLine($"Grats! You are scholarship elligible AVG > 80%");
                }
                else if(langScore >= 90 && sciScore >= 90)
                {
                    //if we are here then the language score AND the science score are above 90
                    Console.WriteLine("Grats! You are scholarship elligible LNG and SCI > 90");
                }
                else if(mathScore == 95 || sciScore == 95)
                {
                    //if we are here they 95 in math OR science 
                    Console.WriteLine("Grats! You are scholarship elligible MTH or SCI = 95");
                }
                else
                {
                    //if we are here the student did not meet any scholarship critera
                    Console.WriteLine("These scores do not qualify for a scholarship");
                }
            }
            catch
            {
                //if we're here then we received an input that resulted in an error - goto the label we set back at the beginning of the program
                Console.WriteLine("Error, one of the scores you entered was not a number");
                goto promptUser4;
            }

            Console.WriteLine("*****=====END OF TASK 5====****");
            Console.ReadLine();

            

            //declare variables
            int num6, num7, num8;
            //prompt the user for three numbers and set label to return to
           promptUser5:
            Console.WriteLine("Please enter three different integer numbers for values x, y, and z");
            //try catch for error control
            try
            {
                //convert string input to numbers
                num6 = Convert.ToInt32(Console.ReadLine());
                num7 = Convert.ToInt32(Console.ReadLine());
                num8 = Convert.ToInt32(Console.ReadLine());

                //start the logic to find the largest number
                if(num6 > num7 & num6 > num8)
                {
                    //if we are here num6 is bigger than num7 and num8
                    Console.WriteLine($"Hey {num6} is the greatest!");
                }
                else if ( num7 > num6 & num7 > num8)
                {
                    //if we are here num7 is bigger than num6 and num8
                    Console.WriteLine($"Yo {num7} is the greatest!");
                }    
                else
                {
                    //if we are here neither num6 or num7 is bigger than num8
                    Console.WriteLine($" Yup, {num8} is the greatest!");
                }
            }
            catch
            {
                //if we are here we received a value that is invalid and a prompt to return the label
                Console.WriteLine("Please enter a valid integer number");
                goto promptUser5;

            }
            Console.WriteLine("*****=====END OF TASK 6====****");
            Console.ReadLine();
           
            
            
            
             
            //declare variables - using decimal for money
            decimal totalPurchase;

        //prompt the user for how much their purchase is and set a label to return to
            promptUser6:
            Console.WriteLine("Please enter the total dollar amount purchased");
            

            //set up a try and catch for error control
            try
            {
                //get the input from the user and convert it to a mathable value -- decimal for money
                totalPurchase = Convert.ToDecimal(Console.ReadLine());
                //being logic to find the shipping cost
                if(totalPurchase <= 250.00m)
                {
                    //if we are here the total is in range of 0 to 250
                    Console.WriteLine("The total shipping charge is $5.00");
                }
                else if (totalPurchase <= 500.00m)
                {
                    //if we are here the range is greater than 250 but still less than (or equal to) 500
                    Console.WriteLine("Total shipping charge is $8.00");
                }
                else if(totalPurchase <= 1000.00m)
                {
                    //if we are here the range is greater than 500 but less than (or equal to) 1000
                    Console.WriteLine("The total shipping charge is $10.00");
                }
                else if( totalPurchase <= 5000.00m)
                {
                    //if we are here the range is greater than 1000 but less than (or equal to) 5000
                    Console.WriteLine("The total shipping charge is $15.00");

                }
                else
                {
                    //if we are here the value is greater than 5000
                    Console.WriteLine("The total shipping charge is $20.00");

                }
            }
            catch
            {
                //if we're here then we received an input that resulted in an error - goto the label we set back at the beginning of the program
                Console.WriteLine("Error, one of the scores you entered was not a number");
                goto promptUser6;
            }
            Console.WriteLine("*****=====END OF TASK 7====****");
            Console.ReadLine();
            
            
        }
    }
}
