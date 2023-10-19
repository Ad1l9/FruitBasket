using FruitBasket.Models;

namespace FruitBasket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit[] Basket =
            {
                new Apple(20,15,20.3m,"Qirmizi"),
                new Pineapple(7,32,20.8m,"Ananas"),
                new Orange(60,9.8m,"Portagal")
            };
            foreach (Fruit fruit in Basket)
            {
                Type type = fruit.GetType();
                Console.WriteLine(type.Name);
                foreach (var member in type.GetProperties())
                {
                    Console.WriteLine($"{member.Name} : {member.GetValue(fruit)}");
                }

                Console.WriteLine();
            }
        }
    }
}