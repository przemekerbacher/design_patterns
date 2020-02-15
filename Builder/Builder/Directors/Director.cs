namespace Builder.Directors
{
    class Factory
    {
        public Scooter Build(IScooterBuilder builder)
        {
            return builder.Build();
        }
    }
}
