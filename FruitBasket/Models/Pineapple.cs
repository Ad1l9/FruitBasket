using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBasket.Models
{
    internal class Pineapple : Fruit
    {
        public Pineapple(int vitaminE, int vitaminD, decimal price, string sort) : base(price, sort)
        {
            VitaminE = vitaminE;
            VitaminD = vitaminD;
        }

        public int VitaminE { get; set; }
        public int VitaminD { get; set; }
        public override void Taste()
        {
            Console.WriteLine("Shirin dadir");
        }
    }
}
