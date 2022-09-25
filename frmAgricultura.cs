using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBaldovinoSP1H1
{
    public partial class frmAgricultura : Form
    {
        public frmAgricultura()
        {
            InitializeComponent();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalidades objVentL = new frmLocalidades();
            objVentL.ShowDialog();
        }

        private void cultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCultivos objVentC = new frmCultivos();
            objVentC.ShowDialog();
        }

        private void produccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion objVentP = new frmProduccion();
            objVentP.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void localidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLocalidadConsulta objVentL = new frmLocalidadConsulta();
            objVentL.ShowDialog();
        }

        private void cultivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCultivoConsulta objVentC = new frmCultivoConsulta();
            objVentC.ShowDialog();
        }

        private void producciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccionConsulta objVentP = new frmProduccionConsulta();
            objVentP.ShowDialog();
        }
    }
}
