using System;
using CoffeeShop;

namespace CoffeeShopApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Coffee coffee = PrepareStandardCoffee();

            PrintCoffeDetails(coffee);
        }
        static public Coffee PrepareStandardCoffee()
        {
            Coffee coffee = new()
            {
                Name = "Espresso",
                Strength = 5,
                Bean = "Arabica",
                size = 12,
                Price = 2.99
            };

            return coffee;
        }

        static public void PrintCoffeDetails(Coffee coffee)
        {
            Console.WriteLine($"Name: {coffee.Name}");
            Console.WriteLine($"Strength: {coffee.Strength}");
            Console.WriteLine($"Bean: {coffee.Bean}");
            Console.WriteLine($"Size: {coffee.size}");
            Console.WriteLine($"Price: {coffee.Price}");
        }
    }
}

