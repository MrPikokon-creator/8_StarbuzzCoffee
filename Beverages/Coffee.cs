using System;

namespace StarbuzzCoffee
{
    public class Coffee : CaffeineBeverage
    {
        private readonly bool isAdd;

        public Coffee(bool isAdd)
        {
            this.isAdd = isAdd;
        }
        
        // Заварка
        protected override void Supplement()
        {
            Console.WriteLine("2. Добавление заварки (кофе)");
        }
        
        // Добавка
        protected override void Add()
        {
            if (IsAdd())
            {
                Console.WriteLine("4. Добавление молока");
            }
        }
        
        // Нужна ли добавка
        protected override bool IsAdd()
        {
            return isAdd;
        }
    }
}
