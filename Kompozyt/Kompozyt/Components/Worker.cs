using System;

namespace Kompozyt.ConcreteComponents
{
    public abstract class Worker
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public Worker(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Position: {Position}");
        }
    }
}
