﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_menagement_system
{
    class Queen : Bee
    {
        private Bee[] workers = new Bee[0];
        private float unassignedWorkers = 3;
        private float eggs = 0;
        const float EGGS_PER_SHIFT = 0.45f;
        const float HONNEY_PER_UNASSIGNED_WORKER = 0.5f;
        public string StatusReport { get; private set; }
        protected override void DoJob()
        {
            eggs += EGGS_PER_SHIFT;
            foreach (Bee worker in workers)
            {

                WorkTheNextShift(this.CostPerShift);
                
            }
            HoneyVault.ConsumeHoney(HONNEY_PER_UNASSIGNED_WORKER * workers.Length);
            UpDateStatusReport();
        }


        public override float CostPerShift { get { return 2.15f; }  }
        public Queen() : base("Queen")
        {
         
                AssignBee("Egg care");
                AssignBee("Nectar Collector");
                AssignBee("Honey Manufacturer");
 
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
                    AddWorker(new EggCare(this));
                    break;
                case "Nectar Collector":
                    AddWorker(new NectarCollector());
                    break;
                case "Honey Manufacturer":
                    AddWorker(new HoneyManufacturer());
                    break;
            }
            UpDateStatusReport();

        }
        private void UpDateStatusReport()
        {
            StatusReport = $"Vault report:\n{HoneyVault.StatusReport}\n" +
                $"\nEgg count: {eggs: 0.0}\nUnassigned workers: {unassignedWorkers: 0.0}\n" +
                $"\n{WorkerStatus("Nectar Collector")}" +
                $"\n{WorkerStatus("Honey Manufacturer")}" +
                $"\n{WorkerStatus("Egg Care")}" +
                $"\nTOTAL WORKERS: {workers.Length}";
        }

        private string WorkerStatus  (string job)
        {
            int count = 0;
            foreach (Bee worker in workers)
                if (worker.Job == job) count++;
            string s = "s";
            if (count == 1) s = "";
            return $"{count} {job} bee{s}";
        }

        public void CareForEggs(float eggsToConvert)
        {
            if (eggs >= eggsToConvert)
            {
                eggs -= eggsToConvert;
                unassignedWorkers += eggsToConvert;
            }
        }

    }
}
