using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.objects
{
    abstract class ComputerFactory
    {
        public abstract Computer GetComputer();
    }
}
