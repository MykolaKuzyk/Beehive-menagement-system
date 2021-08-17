using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_menagement_system
{
    class EggCare : Bee
    {
        public override float CostPerShift { get { return 1.35f; } }
        public EggCare(string job) : base ("Egg Care")
        {

        }
    }
}
