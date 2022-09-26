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
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            File.Delete("./Produccion.csv");
            MessageBox.Show("Borraste el archivo");

        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
            txtFecha.Text = "";
            lstCultivo.SelectedIndex = -1;
            lstLocalidad.SelectedIndex = -1;
        }

        private void cmdCrear_Click(object sender, EventArgs e)
        {
            StreamWriter Produccion = new StreamWriter("./Produccion.csv", true);
            Produccion.WriteLine(txtFecha.Text + ";" + lstCultivo.SelectedItem + ";" + lstLocalidad.SelectedItem + ";" + txtCantidad.Text);
            MessageBox.Show("Archivo creado con éxito");
            Produccion.Close();
            txtFecha.Text = "";
            txtCantidad.Text = "";
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            StreamReader lectorlocalidades1 = new StreamReader("./localidades1.csv");
            StreamReader lectorCultivos = new StreamReader("./Cultivos.csv");

            char varSeparador = Convert.ToChar(";");

            while (!lectorlocalidades1.EndOfStream)
            {
                string[] NombresLocalidad = lectorlocalidades1.ReadLine().Split(varSeparador);
                lstLocalidad.Items.Add(NombresLocalidad[1]);
            }

            lectorlocalidades1.Close();

            while (!lectorCultivos.EndOfStream)
            {
                string[] NombresCultivos = lectorCultivos.ReadLine().Split(varSeparador);
                lstCultivo.Items.Add(NombresCultivos[1]);
            }

            lectorCultivos.Close();
        }

        private void lstLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
