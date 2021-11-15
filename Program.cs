using System;
using System.Collections.Generic;

namespace StarbuzzCoffee
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            g1: HashSet<string> list = new HashSet<string>() { "1", "2", "3" };
            string beverageID;

            do
            {
                Console.WriteLine("1 - Кофе");
                Console.WriteLine("2 - Кофе + молоко");
                Console.WriteLine("3 - Чай + лимон");
                Console.Write("Выберите напиток (цифра): ");
                beverageID = Console.ReadLine();
            } while (!list.Contains(beverageID));

            CaffeineBeverage beverage;
            switch (beverageID)
            {
                case "1": // Кофе
                    beverage = new Coffee(false);
                    break;
                case "2": // Кофе с молоком
                    beverage = new Coffee(true);
                    break;
                default: // Чай с лимоном
                    beverage = new Tea();
                    break;
            }
            Console.WriteLine();
            beverage.Display();

            Console.Write("\n\nПовторить? (1 - да): ");
            if (Console.ReadLine() == "1")
            {
                Console.Clear();
                goto g1;
            }
        }
    }
}
