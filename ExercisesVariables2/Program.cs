using System;

namespace ExercisesVariables2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string b;
            double c;

            a = 10;
            b = "Szkoła Dotneta";
            c = 12.5;

            Console.WriteLine("Enter your firstname:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your lastname:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your phone number:");
            int phoneNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your clothing size(S, M, L, XL..):");
            string clothingSize = Console.ReadLine();

            Console.WriteLine("Enter your height(m):");
            double height = double.Parse(Console.ReadLine()); 

            Console.WriteLine("Enter your weight(kg):");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your shoe size(35 - 48):");
            double shoeSize = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your gender(F/M):");
            char gender = char.Parse(Console.ReadLine());

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(email);
            Console.WriteLine(phoneNumber);
            Console.WriteLine(clothingSize);
            Console.WriteLine(height);
            Console.WriteLine(weight);
            Console.WriteLine(shoeSize);
            Console.WriteLine(gender);
        }
    }
}