using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //for (int i = 0; i< 5; i++)
            //{ 
            //    Console.WriteLine($"{i}");
            //}

            //for (int i = 0; i< 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //for (int i = 0; i< 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            countingHigh();
            Console.WriteLine();

            numbersByThree();
            Console.WriteLine();

            equal(0,0);
            Console.WriteLine();

            evenOrOdd();
            Console.WriteLine();

            positiveOrNegative();
            Console.WriteLine();

            canYouVote();
            Console.WriteLine();

            inRange();
            Console.WriteLine();

            multiplication();
            Console.WriteLine();
        }

        static void countingHigh()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void numbersByThree()
        {
            for (int i = 1; i < 333 ; i++)
            {
                Console.WriteLine(i * 3);
            } 
        }
        static void equal(int x ,int y)
        {
            var userGuess = x;
            var userGuessTwo = y;
            Console.WriteLine("Pick a number");
            var works = int.TryParse(Console.ReadLine(), out userGuess);
            Console.WriteLine("Pick a second number");
            var worksTwo = int.TryParse(Console.ReadLine(), out userGuessTwo);
            if (userGuess > userGuessTwo)
            {
                Console.WriteLine($"{userGuess} is greater than {userGuessTwo}"); 
            }
            else
            {
                Console.WriteLine($"{userGuessTwo} is greater than {userGuess}");
            }
        }
        static void evenOrOdd()
        {
            int userGuess;
            Console.WriteLine("Pick a number, any number!");
            var works = int.TryParse(Console.ReadLine(), out userGuess);
            if (userGuess%2==0)
            {
                Console.WriteLine($"{userGuess} is an even number.");
            }
            else
            {
                Console.WriteLine($"{userGuess} is an odd number.");
            }
        }
        static void positiveOrNegative()
        {
            int userGuess;
            Console.WriteLine("Pick a number to decide if it is positive or negative.");
            var works = int.TryParse(Console.ReadLine(), out userGuess);
            if (userGuess > 0)
            {
                Console.WriteLine($"{userGuess} is a positive number.");
            }
            else
            {
                Console.WriteLine($"{userGuess} is a negative number");
            }
        }

        static void canYouVote()
        {
            int userAge;
            Console.Write("Are you old enough to vote? Input age: ");
            var works = int.TryParse(Console.ReadLine(), out userAge);
            if (userAge >= 18)
            {
                Console.WriteLine("You are old enough to vote.");
            }
            else
            {
                Console.WriteLine("You are too young to vote.");
            }
        }

        static void inRange()
        {
            int userInput;
            Console.WriteLine("Is your number between -10 and 10? Input number: ");
            var works = int.TryParse(Console.ReadLine(), out userInput);
            if (userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine($"Yes! {userInput} is in range!");
            }
            else
            {
                Console.WriteLine($"No! {userInput} is not in range.");
            }
        }

        static void multiplication()
        {
            int multiplicationNumber;
            Console.WriteLine("What number would you like to see the multiplication table for?");
            var works = int.TryParse(Console.ReadLine(), out multiplicationNumber);
            Console.WriteLine($"{multiplicationNumber * 1}, {multiplicationNumber * 2}, {multiplicationNumber * 3}, {multiplicationNumber * 4}, {multiplicationNumber * 5}, {multiplicationNumber * 6}, " +
                $"{multiplicationNumber * 7}, {multiplicationNumber * 8}, {multiplicationNumber * 9}, {multiplicationNumber * 10}, {multiplicationNumber * 11}, {multiplicationNumber * 12}");
        }
    }
}
