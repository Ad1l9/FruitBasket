using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBasket.Models
{
    internal class Apple:Fruit
    {
        public Apple(int vitamin, int  vitaminA, decimal price, string sort) : base(price, sort)
        {
            VitaminA = vitaminA;
            Vitamin = vitamin;
        }

        public int VitaminA { get; set; }

        public int Vitamin { get; set; }



        public override void Taste()
        {
            Console.WriteLine("Kemshirin dadir");
        }
    }
}
