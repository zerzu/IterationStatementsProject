﻿using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0 -DONE!
            int num = 0;



            // Create a do-while loop and use the template below: - DONE!
            do
            {
                // Increment num by 1 - DONE!
                num++;
                // Then add num to the collection - numbers
                // Hint: reference num inside of the Add method's parentheses - DONE!
                numbers.Add(num);

            } while (num < 100);// <---- While your variable is less than 100 - DONE!



            // Create a while loop
            // <--- While num is less than 200 - DONE!
            while (num < 200) 
            {
                // Increment num by 1 - DONE!
                num++;

                // Then add num to the collection numbers
                //HINT: copy how this was done in the do while loop -DONE!
                numbers.Add(num);
            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers
                //In the scope of the foreach loop, print each number in numbers - DONE!
             foreach (var number in numbers) 
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
                // in your initializer set the value of i to 199
                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
                // AND as long as i is greater than or equal to 0
                // Decrement i by 1 - DONE!

            //start for loop here - DONE !
            for (int i = 199; i <= (numbers.Count) && i >= 0; i--) 
            {
                Console.WriteLine(numbers[i]); // place numbers[i] inside of the Console.WriteLine() method - DONE!
            }

            //------------End of exercise
        }
    }
}
