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
            File.Delete("./localidades1.csv");
            MessageBox.Show("Borraste el archivo");
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            //Creo var para saber que no se repita codigo
            bool repetido = false;
            if (File.Exists("./localidades1.csv"))
            {
                StreamReader ControlarRepLoc = new StreamReader("./localidades1.csv");
                while (!ControlarRepLoc.EndOfStream)
                {
                    //Split elimina punto y coma en el archivo
                    //ReadLine lee por linea
                    string repiteLocalidad = ControlarRepLoc.ReadLine();
                    string[] Localidad = repiteLocalidad.Split(';');
                    if (txtIdentificador.Text == Localidad[0])
                    {
                        MessageBox.Show("Codigo repetido");
                        txtIdentificador.Text = "";
                        txtIdentificador.Focus();
                        repetido = true;
                    }
                }
                ControlarRepLoc.Close();

                //Sino se repite codigo, se crea el archivo 
                if (repetido == false)
                {
                    //Con true no se sobreescribe
                    //el punto y coma se usa para archivos de excel
                    StreamWriter localidad1 = new StreamWriter("./localidades1.csv", true);
                    localidad1.WriteLine(txtIdentificador.Text + ";" + txtLocalidad.Text);
                    MessageBox.Show("Dato cargado con éxito.");
                    localidad1.Close();
                    txtIdentificador.Text = "";
                    txtLocalidad.Text = "";
                    txtIdentificador.Focus();
                }
            }

        }
        private void frmLocalidades_Load(object sender, EventArgs e)
        {
            txtIdentificador.Focus();
     
        }
    }
}

