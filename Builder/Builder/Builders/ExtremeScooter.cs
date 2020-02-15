namespace Builder.Builders
{
    class ExtremeScooter : IScooterBuilder
    {
        public Scooter Build()
        {
            return new Scooter
            {
                Name = "Turbo scooter",
                Type = "Extreme"
            };
        }
    }
}
