using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_menagement_system
{
    interface IWorker
    {
        string Job { get;  set; }

        void WorkTheNextShift();

    }
        
            
}
