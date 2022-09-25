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
    public partial class frmLocalidades : Form
    {
        public frmLocalidades()
        {
            InitializeComponent();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtLocalidad.Text = "";
            txtIdentificador.Text = "";
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            File.Delete("./localidades1.txt");
            MessageBox.Show("Borraste el archivito");
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            StreamWriter localidad1 = new StreamWriter("./localidades1.txt", true);
            localidad1.WriteLine(txtIdentificador.Text + "," + txtLocalidad.Text);
            MessageBox.Show("Dato cargado con éxito.");
            localidad1.Close();
            txtIdentificador.Text = "";
            txtLocalidad.Text = "";
            txtIdentificador.Focus();

            bool bandera = false;

            StreamReader localidad = new StreamReader("./localidades1.txt");

            while (!localidad.EndOfStream)
            {
                if (txtIdentificador.Text == localidad.ReadLine())
                {
                    bandera = true; 
                    MessageBox.Show("Sos de la B");
                    
                    //No se puede grabar
                    //bandera : var de control
                }

            }

            localidad.Close();

            if (bandera == false)
            {
                MessageBox.Show("Podes grabar champ");
            }
            else
            {
                txtIdentificador.Text = "";
                txtIdentificador.Focus();
            }

        }
        private void frmLocalidades_Load(object sender, EventArgs e)
        {
            txtIdentificador.Focus();
     
        }
    }
}

