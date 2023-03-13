using System;
using System.Collections.Generic;
using System.Linq;

namespace Завдання_1
{
    internal class Parking
    {
        public int parking; //розмір парковки
        public List<string> parkedCars; //парковка

        public Parking(int parking)
        {
            this.parking = parking;
            this.parkedCars = new List<string>(parking);
        }

        public void AddCar(string car) //додавання автомобілів до стоянки
        {
            if (parkedCars.Count < parking)
            {
                parkedCars.Add(car);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Автомобіль ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(car);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" припарковано");
                Console.ResetColor();
                Console.WriteLine($"\nКількість автомобілів на стоянці: {parkedCars.Count}");
            }
            else
            {
                Console.WriteLine($"Автомобіль {car} не припарковано (немає місць)");
            }    
        }

        public void RemoveCar(string car) //видалення автомобілів зі стоянки
        {
            if (parkedCars.Contains(car))
            {
                parkedCars.Remove(car);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Автомобіль ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(car);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" видалено із стоянки");
                Console.ResetColor();
                Console.WriteLine($"\nКількість автомобілів на стоянці: {parkedCars.Count}");
            }
            else
            {
                Console.WriteLine($"Автомобіль {car} не припаркований на цій стоянці");
                Console.WriteLine("\nАвтомобілі з такими номерними знаками припарковані:");
                foreach (string park in parkedCars)
                {
                    Console.WriteLine(park);
                }
            }
        }
    }
}
        