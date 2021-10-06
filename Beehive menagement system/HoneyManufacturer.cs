using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWorkerhive_menagement_system
{
    class HoneyManufacturer : IWorker
    {
        public const float NECTAR_COLLECTED_PER_SHIFT = 33.15f;
        public override float CostPerShift { get { return 1.7f; } }
        public HoneyManufacturer() : base ("Honey Manufacturer")
        {

        }
        protected override void DoJob()
        {
            HoneyVault.CollectNectar(NECTAR_COLLECTED_PER_SHIFT);
        }
    }
}
