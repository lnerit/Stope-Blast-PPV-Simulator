using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMdiMain : Form
    {
        public frmMdiMain()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuEmphiricalConstants_Click(object sender, EventArgs e)
        {
            miscClass.LoadForm(new frmEmphiricalConstants(), this, "Emphirical Constants");
        }

        private void simulationCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miscClass.LoadForm(new frmSimulationCalculator(), this, "Generate Simulation");
        }

        private void frmMdiMain_Load(object sender, EventArgs e)
        {
            miscClass.LoadForm(new frmSimulationCalculator(), this, "Stope Blast PPV Simulator");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miscClass.LoadForm(new AboutBox1(), this, "About Stope Blast Simulator");
        }
    }
}
