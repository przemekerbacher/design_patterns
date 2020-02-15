namespace Dekorator
{
    public class PizzaWithBecon: PizzaDecorator
    {
        public PizzaWithBecon(Pizza pizza): base(pizza)
        {
            base.Price = 4;
        }

        public override double GetPrice()
        {
            return base._pizza.GetPrice() + base.Price;
        }
    }
}
