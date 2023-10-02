using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    internal class Week2Lesson4
    {
        static void Main (string[] args)
        {
            //ExerciseOne();
            //ExerciseTwo();
            //ExerciseThree();
            //ExerciseFour();
            ExerciseFive();
        }

        private static void ExerciseOne()
        {
            Console.WriteLine("Rejestracja pracownika: \r\n 1. Podaj imie: ");
            string name = Console.ReadLine();
            Console.WriteLine($"2. Podaj naazwisko: ");
            string surname = Console.ReadLine();
            Console.WriteLine("3. Podaj wiek: ");
            int age;
            string input = Console.ReadLine();
            bool trueFalse= int.TryParse(input, out age);
            Console.WriteLine("4. Podaj plec: ");
            char gender;
            input = Console.ReadLine();
            trueFalse = char.TryParse(input, out gender);
            Console.WriteLine("5. Podaj PESEL: ");
            string personalId = Console.ReadLine();
            Console.WriteLine("6. Podaj nr pracownika: ");
            string workerId = Console.ReadLine();

            Console.WriteLine($" Imie: {name} \r\n Nazwisko: {surname} \r\n Wiek: {age} \r\n Plec: {gender} \r\n PESEL: {personalId} \r\n Nr pracownika: {workerId}");
        }

        private static void ExerciseTwo()
        {
            char a = 'a';
            char b = 'b';
            char c = 'c';

            Console.WriteLine($"{c} {b} {a}");
        }

        private static void ExerciseThree()
        {
            Console.WriteLine($"###### Oblicznie przekatnej prostokata ###### \r\n Podaj dl podstawy:");
            double a;
            string input = Console.ReadLine();
            bool TrueFalse = double.TryParse(input, out a);
            Console.WriteLine($"Podaj dl boku:");
            double b; 
            input = Console.ReadLine();
            TrueFalse = double.TryParse(input, out b);
            double diagonal = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine(Math.Round(diagonal, 2));
        }

        private static void ExerciseFour()
        {
            int a = 10;
            string b = "Szkola Dotneta";
            double c = 12.5;

            Console.WriteLine(a + "\n\r" + b + "\n\r" + c);
        }

        private static void ExerciseFive()
        {
            Console.WriteLine("Prosze podaj mi swoje dane: \r\n 1. Podaj imie: ");
            string name = Console.ReadLine();
            Console.WriteLine($"2. Podaj naazwisko: ");
            string surname = Console.ReadLine();
            Console.WriteLine("3. Podaj wiek: ");
            int age;
            string input = Console.ReadLine();
            bool trueFalse = int.TryParse(input, out age);
            Console.WriteLine("4. adres e-mail: ");
            string gender = Console.ReadLine();
            Console.WriteLine("5. Podaj adres: ");
            string adress = Console.ReadLine();
            Console.WriteLine("6. Podaj nr buta: ");
            double shoeSize; 
            input = Console.ReadLine();
            trueFalse = double.TryParse(input, out shoeSize);
            Console.WriteLine("7. Podaj kolor oczu: ");
            string eyeColor = Console.ReadLine();
            Console.WriteLine("8. Podaj kolor wlosow: ");
            string hairColor = Console.ReadLine();
            Console.WriteLine("9. Podaj wage: ");
            double weight;
            input = Console.ReadLine();
            trueFalse = double.TryParse(input, out weight);
            Console.WriteLine("10. Podaj ile masz wzrosu:");
            int height; 
            input = Console.ReadLine();
            trueFalse = int.TryParse(input, out height);

            Console.WriteLine(name + "\n\r" + surname + "\n\r" + age + "\n\r" + gender + "\n\r" + adress + "\n\r" 
                              + shoeSize + "\n\r" + eyeColor + "\n\r" + hairColor + "\n\r" + weight + "\n\r" + height);
        }
    }
}
