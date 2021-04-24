using System;

namespace _3._1Exercises31_32
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop1 = true;

            int[] numbers = { 2, 8, 0, 24, 51 };

            //#31
            while (loop1)
            {
                Console.WriteLine("I have 5 numbers, which location do you want to pull from?");
                int location = int.Parse(Console.ReadLine());
                int search = location - 1;

                if (search < 5 && search >= 0)
                {
                    Console.WriteLine($"\n{numbers[search]} is #{location} in the array.\n");
                }
                else
                {
                    Console.WriteLine($"\n{location} is not a valid index.\n");
                }

                Console.WriteLine("Want to try another index? Please enter \"Y\" or \"N\"");
                string again1 = Console.ReadLine().ToLower();

                if (again1 == "y")
                {
                    loop1 = true;
                }
                else
                {
                    loop1 = false;
                }
            }

            //#32
            bool loop2 = true;

            while (loop2)
            {
                Console.WriteLine("\nEnter a number and let's see if it's in our array!");
                int number = int.Parse(Console.ReadLine());

                bool found = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    int index = i + 1;
                    if (number == numbers[i])
                    {
                        Console.WriteLine($"\n\'{number}\' is located as #{index} in the array.");
                        found = true;
                    }
                }

                if (found == false)
                {
                    Console.WriteLine($"\n\'{number}\' is not within the array.");
                }

                Console.WriteLine("\nWant to try another number? Please enter \"Y\" or \"N\"");
                string again2 = Console.ReadLine().ToLower();

                if (again2 == "y")
                {
                    loop2 = true;
                }
                else
                {
                    loop2 = false;
                }
            }


        }
    }
}
