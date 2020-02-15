using Kompozyt.ConcreteComponents;
using System.Collections.Generic;

namespace Kompozyt.Composits
{
    class WorkerComposit : Worker
    {
        private IList<Worker> _workers;

        public WorkerComposit(string name, string position) : base(name, position)
        {
            Name = name;
            Position = position;
            _workers = new List<Worker>();
        }
        public void AddWorker(Worker worker)
        {
            _workers.Add(worker);
        }

        public void RemoveWorker(Worker worker)
        {
            _workers.Remove(worker);
        }

        public override void GetInfo()
        {
            foreach (var worker in _workers)
            {
                worker.GetInfo();
            }

            base.GetInfo();
        }
    }
}
