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
    public partial class frmCultivoConsulta : Form
    {
        public frmCultivoConsulta()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdListar2_Click(object sender, EventArgs e)
        {
            //Leo archivo
            StreamReader ConsultaCultivos = new StreamReader("./Cultivos.csv");

            //Agrego datos a grilla
            while (!ConsultaCultivos.EndOfStream)
            {
                string DatosCultivos = ConsultaCultivos.ReadLine();
                string[] vectorDatosCultivos = DatosCultivos.Split((';'));
                dgvConsultaCultivos.Rows.Add(vectorDatosCultivos[0], vectorDatosCultivos[1]);
            }
            ConsultaCultivos.Close();
        }
    }
}
