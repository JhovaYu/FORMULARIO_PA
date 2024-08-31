using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMULARIO_PA
{
    public partial class PanelInformation : Form
    {

        private Form1 F1;
        public PanelInformation(Form1 form1)
        {
            InitializeComponent();

            F1 = form1;
        }




        public void AgregarInfo(string Nombre, string Apellido, string Telefono, int Edad, int Estatura, bool Genero)
        {
            LB_NombrePI.Text = "Nombre: " + Nombre;
            LB_ApellidoPI.Text = "Apellido: " + Apellido;
            LB_TelefonoPI.Text = "Telefono: " + Telefono;
            LB_EdadPI.Text = "Edad: " + Edad;
            LB_EstaturaPI.Text = "Estatura: " + Estatura;
            if (Genero)
            {
                LB_GeneroPI.Text = "Genero: Hombre";
            }
            else
            {
                LB_GeneroPI.Text = "Genero: Mujer";
            }
        }

        private void btn_Ok_InfoPanel_Click_1(object sender, EventArgs e)
        {

            F1.BTN_Cancelar_Click(sender, e);
            this.Close();
        }

        private void btn_Guardar_InfoPanel_Click(object sender, EventArgs e)
        {
            String Nombre = F1.Nombre;
            String Apellido = F1.Apellido;
            String Telefono = F1.Telefono;
            int Edad = F1.Edad;
            int Estatura = F1.Estatura;
            bool Genero = F1.Genero;
            String genero = "";
            if (Genero)
            {
                genero = "Hombre";
            }
            else
            {
                genero = "Mujer";
            }

            GuardarArhivos(Nombre, Apellido, Telefono, Edad, Estatura, genero);
        }

        public void GuardarArhivos(string Nombre, string Apellido, string Telefono, int Edad, int Estatura, string Genero)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            saveFileDialog.Title = "Guardar valores en archivo de texto";
            saveFileDialog.FileName = "valores.txt";

            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                string rutaArchivo = saveFileDialog.FileName;


                using (StreamWriter escritor = new StreamWriter(rutaArchivo))
                {
                    escritor.WriteLine("Nombre: " + Nombre);
                    escritor.WriteLine("Apellido: " + Apellido);
                    escritor.WriteLine("Teléfono: " + Telefono);
                    escritor.WriteLine("Edad: " + Edad);
                    escritor.WriteLine("Estatura: " + Estatura);
                    escritor.WriteLine("Genero: " + Genero);
                }
            }


        }
    }
}
