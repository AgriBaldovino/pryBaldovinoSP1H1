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
    public partial class frmLocalidadConsulta : Form
    {
        public frmLocalidadConsulta()
        {
            InitializeComponent();
        }

        private void cmdListar3_Click(object sender, EventArgs e)
        {
            //Leo archivo
            StreamReader ConsultaLocalidad = new StreamReader("./localidades1.csv");
            while (!ConsultaLocalidad.EndOfStream)
            {
                string DatosLocalidad = ConsultaLocalidad.ReadLine();
                string[] vectorLocalidad = DatosLocalidad.Split((';'));
                dgvConsultaLocalidad.Rows.Add(vectorLocalidad[0], vectorLocalidad[1]);
            }
            ConsultaLocalidad.Close();
        }
    }
}
