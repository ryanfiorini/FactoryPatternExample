using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.objects
{
    class BrandXComputer : Computer
    {
        int _mhz = 1500;

        public override int Mhz
        {
            get { return _mhz; }
        }
    }
}
