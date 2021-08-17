using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_menagement_system
{
    class Bee 
    {
        public  string  Job { get; private set; }
        public virtual float CostPerShift { get; protected set;}

        public Bee(string job)
        {
            job = Job;
        }
        protected virtual void DoJob()
        {
            /// - fillin
        }

        public void WorkTheNextShift(float HoneyConsumed)
        {
            if (HoneyVault.ConsumeHoney(HoneyConsumed))
            {
                DoJob();
            }
            
        }


    }
}
