using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kasey Henyard
            //10-5
            //CSI 120
            //Project 3 

            

            //create numeric variables for each of the following values

            long num1 = -28210730126103;
            decimal num2 = 10.45m;
            double num3 = 2.7182818284590;
            sbyte num4 = 100;
            float num5 = 9.784f;

            //write the value and data type using string interlocation 
            Console.WriteLine($"The data type for {num1} is {num1.GetType()}");
            Console.WriteLine($"The data type for {num2} is {num2.GetType()}");
            Console.WriteLine($"The data type for {num3} is {num3.GetType()}");
            Console.WriteLine($"The data type for {num4} is {num4.GetType()}");
            Console.WriteLine($"The data type for {num5} is {num5.GetType()}");
            Console.WriteLine("*****====END OF TASK 1====*****");
            Console.ReadLine();

            //Prompt the user to input a value
            Console.WriteLine("Please enter a number");
            //Get user input and store in string variable
            string input = Console.ReadLine();
            //declare an integer variable
            int inputInt;
            //Try to convert input (string) to inputInt (integer)
            try
            {
                inputInt = Convert.ToInt32(input);
                //I know that if this next line runs that my conversion was successful
                Console.WriteLine($"The value is {inputInt} the data type {inputInt.GetType()}");
            }
            catch
            {
                //If this code runs I know that my conversion failed
                Console.WriteLine($"Conversion failed {input} cannot covert to an Int");
            }

            //Convert to a double
            //declare a double variable
            double inputDouble;
            //Try to convert input (string) to inputDouble (double)
            try
            {
                inputDouble = Convert.ToDouble(input);
                //I know that if this next line runs that my conversion was successful
                Console.WriteLine($"The value is {inputDouble} the data type {inputDouble.GetType()}");
            }
            catch
            {
                //If this code runs I know that my conversion failed
                Console.WriteLine($"Conversion failed {input} cannot covert to an Int");
            }

            //Convert to a single
            //declare a single  variable
            float inputSingle;
            //Try to convert input (string) to inputDouble (double)
            try
            {
                inputSingle = Convert.ToSingle(input);
                //I know that if this next line runs that my conversion was successful
                Console.WriteLine($"The value is {inputSingle} the data type {inputSingle.GetType()}");
            }
            catch
            {
                //If this code runs I know that my conversion failed
                Console.WriteLine($"Conversion failed {input} cannot covert to an Int");
            }
            Console.WriteLine("****====END OF TASK 2====****");
            Console.ReadLine();

            //prompt the user to input the price of gas 
            //convert to a usable data type
       
            Console.WriteLine("Enter the price of gas");
            string stringGasPrice = Console.ReadLine();
            decimal decimalGasPrice = Convert.ToDecimal(stringGasPrice);
            //get the miles per gallon of the car 
            //convert to a useable data type
            Console.WriteLine("Enter the miles per gallon of the car");
            string stringDistance = Console.ReadLine();
            int intDistance = Convert.ToInt16(stringDistance);
            //get number of miles of driven
            //convert data type
            Console.WriteLine("Enter the number of miles driven");
            string stringMilesDriven = Console.ReadLine();
            int intMilesDriven = Convert.ToInt16(stringMilesDriven);

            //create a decimail to hold the math 
            decimal gasTotal = decimalGasPrice * intMilesDriven;

            //print the results 
            Console.WriteLine($"The total cost of the trip is {gasTotal}");
            Console.WriteLine("****====END OF TASK 3====****");
            Console.ReadLine();

            

            //prompt the user to to input an amount of change in pennies between 0 and 99
            Console.WriteLine("How many pennies do you have?");
            string stringPennies = Console.ReadLine();
            int intPennies;

            //try catch for error handling
            try
            {
                //attempt to convert string input from user to mathable value
                intPennies = Convert.ToInt16(stringPennies);
                Console.WriteLine($"The data type is {intPennies.GetType()}");
                //logic for figuring out change

                int quarters = intPennies / 25; //figure out how many quarters are needed
                int newTotal = intPennies - quarters * 25; //update the total of change
                int dimes = newTotal / 10; //figure out how many dimes are needed
                newTotal = newTotal - dimes * 10; //update total
                int nickles = newTotal / 5; //figure out how many nickles are needed
                newTotal = newTotal - nickles * 5; //update total
                int pennies = newTotal / 1; //figure out how many pennies are needed
                //print out results
                Console.WriteLine($"That is {quarters} quarters, {dimes} dimes, {nickles} nickles, and {pennies} pennies");
              

            }
            catch
            {
                //if we are here the code didn't work and we need an error message
                Console.WriteLine("Please enter a correct value");
            }

            Console.WriteLine("****====END OF TASK 4====****");
            Console.ReadLine();

           
            
            //create a variable and assign it a value of 11
            //subtract 1 and update the value
            // divide the variable by 2 and update the value
            // add 1 to the variable an udpate the value
            // multiply the variable by and update the value
            // output the variable using string interlopation 

            int number1 = 11;
                number1--;
                number1/= 2;
                number1++;
                number1 *= 5;
            Console.WriteLine($"The value of the number is {number1}");

            Console.WriteLine("****====END OF TASK 5====****");
            Console.ReadLine();
           


        }
    }
}
