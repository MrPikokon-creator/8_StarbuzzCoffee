using System;

namespace StarbuzzCoffee.Beverages
{
    public abstract class CaffeineBeverage
    {
        protected abstract void Supplement(); // Заварка
        protected abstract void Add(); // Добавка

        // Кипятим воду
        private void BoilWater()
        {
            Console.WriteLine("1. Кипятим воду");
        }

        // Разливаем по чашкам
        private void PourInCup()
        {
            Console.WriteLine("3. Разливаем по чашкам");
        }

        // Нужна ли добавка
        protected virtual bool IsAdd()
        {
            return false;
        }

        // Информация о приготовлении
        public void Display()
        {
            BoilWater();
            Supplement();
            PourInCup();
            Add();
        }
    }
}
