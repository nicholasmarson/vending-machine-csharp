using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineCLI.States
{
    internal abstract class StartingState : iVendingMachineState
    {
        private String currentState;
    }
}
