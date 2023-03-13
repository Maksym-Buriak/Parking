using System;
using System.Collections.Generic;

namespace Завдання_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int places = 3;
            Parking lot = new Parking(places);
            Console.WriteLine($"Кількість місць на стоянці: {places}");
            try
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Виберіть дію: ");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("Припаркувати автомобіль - 1");
                    Console.WriteLine("Виїзд автомобіля - 2");
                    Console.WriteLine("---------------------------");

                    int choice = int.Parse(Console.ReadLine());
                    if (choice != 1 && choice != 2 && Char.IsLetter(choice.ToString()[0]))
                    {
                        Console.WriteLine("Ви не правильно вибрали дію");
                    }
                    else if (choice == 1) // паркування автомобілів
                    {
                        bool continueParking = true;
                        do
                        {
                            Console.Write("Введіть номер автомобіля у форматі |АА0000АА|: ");
                            string carNumber = Console.ReadLine();
                            if (lot.parkedCars.Contains(carNumber))
                            {
                                Console.WriteLine("Автомоіль з таким номером вже припаркований");
                            }
                            else if (carNumber.Length > 8 || carNumber.Length < 8)
                            {
                                Console.WriteLine("Ви неправильно ввели номер");
                                Console.WriteLine("--------------------------");

                                Console.WriteLine("\nБажаєте припаркувати автомобіль? Якщо так - написніть 1");
                                Console.WriteLine("                                 Якщо ні  - натисніть Backspace");
                                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                                if (keyInfo.Key == ConsoleKey.Backspace)
                                {
                                    continueParking = false; // зупиняємо роботу циклу після успішного додавання автомобіля
                                }
                                else
                                {
                                    continueParking = true; // продовжуємо роботу циклу
                                }

                            }
                            else
                            {
                                lot.AddCar(carNumber);
                                Console.WriteLine("\nБажаєте припаркувати автомобіль? Якщо так - написніть 1");
                                Console.WriteLine("                                 Якщо ні  - натисніть Backspace");
                                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                                if (keyInfo.Key == ConsoleKey.Backspace)
                                {
                                    continueParking = false; // зупиняємо роботу циклу після успішного додавання автомобіля
                                }
                                else
                                {
                                    continueParking = true; // продовжуємо роботу циклу
                                }

                            }
                        }
                        while (continueParking);
                    }
                    else if (choice == 2) // виїзд автомобілів з парковки
                    {
                        bool continueUnparking = true;
                        do
                        {
                            Console.Write("Введіть номер автомобіля у форматі |АА0000АА|: ");
                            string carNumber = Console.ReadLine();
                            if (carNumber.Length > 8 || carNumber.Length < 8)
                            {
                                Console.WriteLine("Ви неправильно ввели номер");
                                Console.WriteLine("--------------------------");
                                Main(args);
                            }
                            else
                            {
                                lot.RemoveCar(carNumber);
                                Console.WriteLine("\nБажаєте забрати автомобіль із стоянки? Якщо так - написніть 1");
                                Console.WriteLine("                                       Якщо ні  - натисніть Backspace");
                                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                                if (keyInfo.Key == ConsoleKey.Backspace)
                                {
                                    continueUnparking = false; // зупиняємо роботу циклу після успішного додавання автомобіля
                                }
                                else
                                {
                                    continueUnparking = true; // продовжуємо роботу циклу
                                }
                            }
                        }
                        while (continueUnparking);
                    }
                
                }
                while (true) ;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введений неправильний тип даних");
            }
        


            Console.ReadKey();
        }
    }
}