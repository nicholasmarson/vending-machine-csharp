using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineCLI.States
{
    internal interface iVendingMachineState
    {

        void enterState();
        void runLoop();
        void exitState();

    }
}
