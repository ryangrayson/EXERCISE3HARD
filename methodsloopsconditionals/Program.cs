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
            Console.WriteLine("");
            Console.WriteLine("==========HEATIN' UP==========");
            Console.WriteLine("");

            //1. Write a method to check if an integer (from the user) is in the range of -10 to 10)

                Console.WriteLine("Type a round number");

            var input = Int32.Parse(Console.ReadLine());

            if (input <= 10 &&  input >= -10)
            {
                Console.WriteLine("You are in range");
            }
            else
            {
                Console.WriteLine("Sorry, you are not in range");
            }

            //2. Write a method to display the multiplication table (from 1 to 12) of a give integer

            static void Mult(int num)
            {
                for (int i = 1; i <=12; i++)
                {
                    var rslt = num * i;
                    Console.WriteLine($"{num} * {i} = {rslt}");

                }
            };

            Mult(4);



            //3. Write a method that takes a number from the user and retuns an array with that many indexes
            //The values shall be random numbers.
            Console.WriteLine("Enter a round number");
            var userInput = Int32.Parse(Console.ReadLine());
            var userArray = new int[userInput];
            var random = new Random();
           // Console.WriteLine(random.Next(0,50));

            for (int i = 0; i < userArray.Length; i++)
            {
                userArray[i] = random.Next(1,15);
                Console.WriteLine(userArray[i]);
            }


            //4. Write a method to compute the sum of all elements in an array of integers


            int sum = 0;
            foreach (var num in userArray)
            {
                sum += num;
            }
            Console.WriteLine(sum);




            //5. Write a method to display the cube of the number up to given an integer.
            //(if a user inputs the number 3 the method should print to the console:
            //Number is: 1 and the cube of 1 is: 1, Number is: 2 and the cube of 2 is: 8,
            //Number is: 3 and the cube of 3 is : 27

            int givenInteger = 5;

            for (int i = 1; i <= givenInteger; i++)
            {
                
                Console.WriteLine($"Number is: {i} and the cube of is: {i * i * i}");

            }

            

               
                

            

            





















 




            
           
            

 
            
            
        }
    }
}

