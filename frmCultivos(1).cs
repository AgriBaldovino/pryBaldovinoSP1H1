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
using System.Text;

namespace pryBaldovinoSP1H1
{
    public partial class frmCultivos : Form
    {
        public frmCultivos()
        {
            InitializeComponent();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
        }

        private void cmdEscribir2_Click(object sender, EventArgs e)
        {

        }

        private void cmdBorrar3_Click(object sender, EventArgs e)
        {
            File.Delete("./Cultivos.txt"); 
            MessageBox.Show("Borraste el archivito");
        }

        private void cmdCrear2_Click(object sender, EventArgs e)
        {
            StreamWriter cultivos = new StreamWriter("./Cultivos.txt", true);
            cultivos.WriteLine(txtCodigo.Text + "," + txtNombre.Text);
            MessageBox.Show("Dato cargado con éxito.");
            cultivos.Close();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCodigo.Focus();
        }

        private void frmCultivos_Load(object sender, EventArgs e)
        {
            

        }
    }
}
