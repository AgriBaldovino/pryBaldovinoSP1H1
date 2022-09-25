using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryBaldovinoSP1H1
{
    public partial class frmProduccionConsulta : Form
    {
        public frmProduccionConsulta()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            //Leo archivo
            StreamReader ConsultaProduccion = new StreamReader("./Produccion.csv");

            //Agrego datos a grilla
            while (!ConsultaProduccion.EndOfStream)
            {
                string Produccion = ConsultaProduccion.ReadLine();
                string[] vecProduccion = Produccion.Split((';'));
                dgvConsultaProduccion.Rows.Add(vecProduccion [0], vecProduccion[1], vecProduccion[2], vecProduccion[3]);
            }
            ConsultaProduccion.Close();
        }
    }
}
