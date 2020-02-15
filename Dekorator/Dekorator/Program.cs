using Dekorator.ConcreteComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzas = new List<Pizza>();
            var smallPizza = new SmallPizza();
            var pizzaWithMozarella = new PizzaWithMozarella(smallPizza);
            var pizzaWithBecon = new PizzaWithBecon(pizzaWithMozarella);

            var mediumPizza = new MediumPizza();
            var mediumWithBecon = new PizzaWithBecon(mediumPizza);

            pizzas.Add(smallPizza);
            pizzas.Add(pizzaWithMozarella);
            pizzas.Add(pizzaWithBecon);

            pizzas.Add(mediumPizza);
            pizzas.Add(mediumWithBecon);

            

            foreach(var pizza in pizzas)
            {
                Console.WriteLine(pizza.GetPrice());
            }

            Console.ReadKey();
        }
    }
}
