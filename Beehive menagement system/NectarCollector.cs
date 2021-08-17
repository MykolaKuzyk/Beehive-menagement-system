using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_menagement_system
{
    class NectarCollector : Bee
    {
        public override float CostPerShift { get { return 1.95f; } }
        public NectarCollector(string job) : base("Nectar Collector")
        {

        }
    }
}
