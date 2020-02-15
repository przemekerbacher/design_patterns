namespace Dekorator
{
    public class PizzaWithMozarella:PizzaDecorator
    {
        public PizzaWithMozarella(Pizza pizza) :base(pizza)
        {
            base.Price = 2;
        }

        override public double GetPrice()
        {
            return base._pizza.GetPrice() + base.Price;
        }
    }
}
