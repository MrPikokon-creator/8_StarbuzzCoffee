using System;

namespace StarbuzzCoffee.Beverages
{
    public class Tea : CaffeineBeverage
    {
        // Заварка
        protected override void Supplement()
        {
            Console.WriteLine("2. Добавляем заварку (чай)");
        }
        
        // Добавка
        protected override void Add()
        {
            Console.WriteLine("4. Добавляем лимон");
        }
    }
}
