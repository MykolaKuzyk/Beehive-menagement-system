using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_menagement_system
{
    class Queen : Bee
    {
        private Bee[] workers;
        private float unassignedWorkers = 0;
        private float eggs = 0;
        const float EGGS_PER_SHIFT = 0.45f;
        const float HONNEY_PER_UNASSIGNED_WORKER = 0.5f;
        protected override void DoJob()
        {
            eggs += EGGS_PER_SHIFT;
            foreach (Bee worker in workers)
            {

                WorkTheNextShift(this.CostPerShift);
                HoneyVault.ConsumeHoney(HONNEY_PER_UNASSIGNED_WORKER * workers.Length);
            }
        }


        public override float CostPerShift { get { return 2.17f; }  }
        public Queen(string job) : base("Queen")
        {
            for (int i = 0; i < 2; i++) 
            {
                if (i ==0 )
                AssignBee("Egg care");
                else if (i == 1)
                AssignBee("Nectar Collector");
                else if (i == 2)
                AssignBee("Honey Manufacturer");
            }
        }
        


        private void AddWorker(Bee worker)
        {
            if (unassignedWorkers >= 1)
            {
                unassignedWorkers--;
                Array.Resize(ref workers, workers.Length + 1);
                workers[workers.Length - 1] = worker;
            }
        }

        public void AssignBee(string job)
        {
            switch (job)
            {
                case "Egg care":
                    AddWorker(new EggCare(this.Job));
                    break;
                case "Nectar Collector":
                    AddWorker(new NectarCollector(this.Job));
                    break;
                case "Honey Manufacturer":
                    AddWorker(new HoneyManufacturer(this.Job));
                    break;
            }

        }

    }
}
