using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Beehive_menagement_system
{
    class Bee : IWorker
    {
        public  string  Job { get;  set; }
        public virtual float CostPerShift { get; }

        public Bee(string job)
        {
            Job = job;
        }
        protected virtual void DoJob()
        {
            /// - fillin
        }

        public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
            }
            
        }


    }
}
