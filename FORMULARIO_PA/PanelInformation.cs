using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
