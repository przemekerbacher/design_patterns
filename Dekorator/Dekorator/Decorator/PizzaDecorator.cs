namespace Dekorator
{
    public class PizzaDecorator: Pizza
    {
        protected Pizza _pizza;
        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        protected override double Price { get; set; }

        public override double GetPrice()
        {
            return _pizza.GetPrice();
        }
    }
}
