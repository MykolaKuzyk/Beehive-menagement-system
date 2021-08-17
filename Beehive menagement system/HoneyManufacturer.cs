using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_menagement_system
{
    class HoneyManufacturer : Bee
    {
        public override float CostPerShift { get { return 1.7f; } }
        public HoneyManufacturer(string job) : base ("Honey Manufacturer")
        {

        }
    }
}
