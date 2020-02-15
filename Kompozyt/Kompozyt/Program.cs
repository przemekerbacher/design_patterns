using Kompozyt.Composits;
using Kompozyt.ConcreteComponents;
using System;

namespace Kompozyt
{
    class Program
    {
        static void Main(string[] args)
        {
            var chief = new WorkerComposit("Adam", "Szef");
            var manager = new WorkerComposit("Janusz", "Manager");
            var manager2 = new WorkerComposit("Anna", "Manager");
            manager.AddWorker(new ConcreteWorker("Beata", "Sprzedawca"));
            manager.AddWorker(new ConcreteWorker("Kamil", "Sprzedawca"));
            manager2.AddWorker(new ConcreteWorker("Rafał", "Kurier"));
            chief.AddWorker(manager);
            chief.AddWorker(manager2);

            chief.GetInfo();
            Console.ReadKey();
        }
    }
}
