namespace Dekorator
{
    public abstract class Pizza
    {
        protected abstract double Price { get; set; }
        public virtual double GetPrice()
        {
            return Price;
        }
    }
}
