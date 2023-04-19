using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Program
    {
        class Dessert
        {
            string name;
            double weight;
            int calories;

            public Dessert(string name, double weight, int calories)
            {
                this.name = name;
                this.weight = weight;
                this.calories = calories;
            }

            public string Name { get => name; set => name = value; }
            public double Weight { get => weight; set => weight = value; }
            public int Calories { get => calories; set => calories = value; }

            public override string ToString()
            {
                return "Ime: " + name + "\nTežina: " + weight + "\nkalorije: " + calories;
            }

            public string getDessertType()
            {
                return "dessert";
            }
        }
        static void Main(string[] args)
        {
            Dessert dessert = new Dessert("Torta", 5, 5000);
            Console.WriteLine(dessert.ToString());
            Console.ReadKey();
        }
    }
}
