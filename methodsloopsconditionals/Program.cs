using System;

namespace methodsloopsconditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Write a method that will pring ot the console all numbers 1000 through -1000

            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

            //2. Write a method that will print to the console numbers 3 through 999 by 3 each time

            for (int i = 3; i < 999; i += 3)
            {
                Console.WriteLine(i);
            }

            //3. Write a method to accept to integers as parameters and check whether they are equal or not

            int x = 32;
            int y = -32;

            if (x == y)
            {
                Console.WriteLine("These numbers are equal");
            }else
                {
                Console.WriteLine("These numbers are not equal");
             }

            //4. Write a method to check whether a given number is positive or negative

            if (x > 0)
            {
                Console.WriteLine("This number is positive");
            }
            else if (x < 0)
            {
                Console.WriteLine("This number is negative");
            }
            else
            {
                Console.WriteLine("This number is zero");
            }

            //5. Write a method to check whether a given number is even or odd

            if (x%2 == 0)
            {
                Console.WriteLine("This number is even");
            }

            //6. Write a method to read the age of a candidate and determine whether they can vote

            int age = 12;

            if (age >= 18)
            {
                Console.WriteLine("Cast your vote!");
            }
            else
            {
                Console.WriteLine("Please enter a valid age");
            }

           
            

 
            
            
        }
    }
}

