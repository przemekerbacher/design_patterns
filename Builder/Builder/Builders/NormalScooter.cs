namespace Builder.Builders
{
    class NormalScooter : IScooterBuilder
    {
        public Scooter Build()
        {
            return new Scooter
            {
                Name = "Custom scooter",
                Type = "Normal",
            };
        }
    }
}
