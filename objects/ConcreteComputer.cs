using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.objects
{
    class ConcreteComputer : Computer
    {
        int _mhz = 500;

        public override int Mhz
        {
            get { return _mhz; }
        }//Mhz
    }
}
