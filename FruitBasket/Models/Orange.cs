using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBasket.Models
{

    internal class Orange : Fruit
    {
        public Orange(int vitaminC, decimal price, string sort) : base(price, sort)
        {
            VitaminC = vitaminC;
        }

        public int VitaminC { get; set; }
        public override void Taste()
        {
            Console.WriteLine("Tursh dadir");
        }
    }
}
