using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program                       //Exersise 2:
    {
        static void Main(string[] args)
        {
            //Exercise 1:
            for (int i=0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i=0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i=0; i < 5; i++)
            {
                Console.WriteLine($"{i})");
            }
            for (int i= 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }




            //TODO - Read each comment and complete its instruction
            // like the example below

            //Create a List called "numbers" - DONE!
            var numbers = new List<int>();
            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0 - DONE!
            int num = 0;
            // Create a do-while loop and use the template below:   - DONE!
            do
            {
                // Increment num by 1  - DONE!
                num++;
                // Then add num to the collection - numbers
                // Hint: reference num inside of the Add method's parentheses   - DONE!
                numbers.Add(num);
                //here I print out the number of elements contained in the List, which is 1 - 100:
                Console.Write(numbers.Count);
            } while (num < 100);// <---- While your variable is less than 100  - DONE!



            // Create a while loop
            while (num < 200)// <--- While num is less than 200  - DONE!
            {
                // Increment num by 1        - DONE!
                num++;
                // Then add num to the collection numbers
                //HINT: copy how this was done in the do while loop   - DONE!
                numbers.Add(num);
                //here I print out the number of elements contained in the List, which is 101 - 200:
                Console.Write($"\n{ numbers.Count}");
            }
            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("\nIncrease:");





            // Create a foreach loop using the collection - numbers  DONE!
            //In the scope of the foreach loop, print each number in numbers   DONE!
            foreach (int i in numbers)
            {
                num--;
                Console.WriteLine(i);
            }



            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1 - DONE!
            // in your initializer set the value of i to 199   - DONE!
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)   - DONE!
            // AND as long as i is greater than or equal to 0   - DONE!
            // Decrement i by 1   - DONE!
            //start for loop here
            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                // place numbers[i] inside of the Console.WriteLine() method  - DONE!
                Console.WriteLine(i);
            }

            //------------End of exercise
        }
    }
}
