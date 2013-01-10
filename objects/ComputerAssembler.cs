using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.objects
{
    class ComputerAssembler
    {
        public void AssembleComputer(ComputerFactory factory)
        {
            Computer computer = factory.GetComputer();
            Debug.WriteLine("assembled a {0} running at {1} MHz", computer.GetType().FullName, computer.Mhz);
        }
    }
}
