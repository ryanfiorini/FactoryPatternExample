﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.objects
{
    class BrandXFactory: ComputerFactory
    {
        public override Computer GetComputer()
        {
            return new BrandXComputer();
        }
    }
}
