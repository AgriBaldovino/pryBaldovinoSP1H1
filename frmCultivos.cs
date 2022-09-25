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
            File.Delete("./Cultivos.csv"); 
            MessageBox.Show("Borraste el archivo");
        }

        private void cmdCrear2_Click(object sender, EventArgs e)
        {
            //Creo var para saber que no se repita codigo
            bool repetido = false;
            if (File.Exists("./Cultivos.csv"))
            {
                StreamReader ControlarRepCultivo = new StreamReader("./Cultivos.csv");
                while (!ControlarRepCultivo.EndOfStream)
                {
                    //Split elimina punto y coma en el archivo
                    //ReadLine lee por linea
                    string repiteCultivo = ControlarRepCultivo.ReadLine();
                    string[] Cultivo = repiteCultivo.Split(';');
                    if (txtCodigo.Text == Cultivo[0])
                    {
                        MessageBox.Show("Codigo repetido");
                        txtCodigo.Text = "";
                        txtCodigo.Focus();
                        repetido = true;
                    }
                }
                ControlarRepCultivo.Close();

                //Sino se repite codigo, se crea el archivo 
                if (repetido == false)
                {
                    //Con true no se sobreescribe
                    //el punto y coma se usa para archivos de excel
                    StreamWriter cultivos = new StreamWriter("./Cultivos.csv", true);
                    cultivos.WriteLine(txtCodigo.Text + ";" + txtNombre.Text);
                    MessageBox.Show("Dato cargado con éxito");
                    cultivos.Close();
                    txtCodigo.Text = "";
                    txtNombre.Text = "";
                    txtCodigo.Focus();
                }
            }
        }

        private void frmCultivos_Load(object sender, EventArgs e)
        {
            

        }
    }
}
