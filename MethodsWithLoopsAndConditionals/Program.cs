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

            CountingHigh();
            Console.WriteLine();

            NumbersByThree();
            Console.WriteLine();

            Equal(0, 0);
            Console.WriteLine();

            EvenOrOdd();
            Console.WriteLine();

            PositiveOrNegative();
            Console.WriteLine();

            CanYouVote();
            Console.WriteLine();

            InRange();
            Console.WriteLine();

            Multiplication();
            Console.WriteLine();
        }

        static void CountingHigh()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void NumbersByThree()
        {
            for (int i = 0; i < 1000 ; i += 3)
            {
                Console.WriteLine(i);
            } 
        }
        static void Equal(int x, int y)
        {
            int userGuess = x;
            int userGuessTwo = y;
            do
            {
                Console.WriteLine("Pick a number");
                var works = int.TryParse(Console.ReadLine(), out userGuess);
            }
            while (userGuess == 0);
            do
            {
                Console.WriteLine("Pick a second number");
                var worksTwo = int.TryParse(Console.ReadLine(), out userGuessTwo);
            }
            while(userGuessTwo == 0);

            if (userGuess > userGuessTwo)
            {
                Console.WriteLine($"{userGuess} is greater than {userGuessTwo}"); 
            }
            else if (userGuess < userGuessTwo)
            {
                Console.WriteLine($"{userGuessTwo} is greater than {userGuess}");
            }
            else
            {
                Console.WriteLine($"{userGuess} is even with {userGuessTwo}.");
            }
        }
        static void EvenOrOdd()
        {
            int userGuess;
            do
            {
                Console.WriteLine("Pick a number, any number!");
                var works = int.TryParse(Console.ReadLine(), out userGuess);
            }
            while (userGuess == 0);

            if (userGuess%2==0)
            {
                Console.WriteLine($"{userGuess} is an even number.");
            }
            else
            {
                Console.WriteLine($"{userGuess} is an odd number.");
            }
        }
        static void PositiveOrNegative()
        {
            int userGuess;
            do
            {
                Console.WriteLine("Pick a number to decide if it is positive or negative.");
                var works = int.TryParse(Console.ReadLine(), out userGuess);
            }
            while (userGuess == 0);

            if (userGuess > 0)
            {
                Console.WriteLine($"{userGuess} is a positive number.");
            }
            else
            {
                Console.WriteLine($"{userGuess} is a negative number");
            }
        }

        static void CanYouVote()
        {
            int userAge;
            do
            {
                Console.Write("Are you old enough to vote? Input age: ");
                var works = int.TryParse(Console.ReadLine(), out userAge);
            }
            while (userAge == 0);

            if (userAge >= 18)
            {
                Console.WriteLine("Congratulation! You're old enough to vote.");
            }
            else
            {
                Console.WriteLine("We're sorry, you're too young to vote.");
            }
        }

        static void InRange()
        {
            int userInput;
            do
            {
                Console.WriteLine("Is your number between -10 and 10? Input number: ");
                var works = int.TryParse(Console.ReadLine(), out userInput);
            }
            while (userInput == 0);
            if (userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine($"Yes! {userInput} is in range!");
            }
            else
            {
                Console.WriteLine($"No! {userInput} is not in range.");
            }
        }

        static void Multiplication()
        {
            int multiplicationNumber;
            do
            {
                Console.WriteLine("What number would you like to see the multiplication table for?");
                var works = int.TryParse(Console.ReadLine(), out multiplicationNumber);
            }
            while (multiplicationNumber == 0);
            Console.WriteLine($"{multiplicationNumber * 1}, {multiplicationNumber * 2}, {multiplicationNumber * 3}, {multiplicationNumber * 4}, {multiplicationNumber * 5}, {multiplicationNumber * 6}, " +
                $"{multiplicationNumber * 7}, {multiplicationNumber * 8}, {multiplicationNumber * 9}, {multiplicationNumber * 10}, {multiplicationNumber * 11}, {multiplicationNumber * 12}");
        }
    }
}
