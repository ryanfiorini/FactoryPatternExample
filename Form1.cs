using FactoryPatternExample.objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryPatternExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateComputer_Click(object sender, EventArgs e)
        {
            ComputerFactory factory = null;
            
            if (rdoGeneric.Checked)
                factory = new ConcreteComputerFactory();
            else
                factory = new BrandXFactory();

            new ComputerAssembler().AssembleComputer(factory);
        }
    }
}
