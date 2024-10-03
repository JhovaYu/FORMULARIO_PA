using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;


namespace FORMULARIO_PA
{
    public partial class Form1 : Form
    {
        private PanelInformation PI;

        public String Nombre, Apellido, Telefono;

        public int  Edad, Estatura;

        public Boolean isClose, Genero;
        
        public Form1()
        {
            InitializeComponent();
            PanelRedondo.ConfigurarFormulario(this);

            PI = new PanelInformation(this);
        }

        private void PanelInformation_ValorChanged(object sender, EventArgs e)
        {
            

            Funciones.LimpiarPaneles(TB_Nombre, TB_Apellido, TB_Telefono, TB_Edad, TB_Estatura);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LB_Name_Click(object sender, EventArgs e)
        {
            Funciones.AjustarLabelFormDown(LB_Name, new Point(51, 120));
            TB_Nombre.Focus();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PI.AgregarInfo(Nombre, Apellido, Telefono, Edad, Estatura, Genero);
            PI.Show();
        }

        private void LB_Apellido_Click(object sender, EventArgs e)
        {
            Funciones.AjustarLabelFormDown(LB_Apellido, new Point(51, 181));
            TB_Apellido.Focus();
        }

        private void LB_Telefono_Click(object sender, EventArgs e)
        {
            Funciones.AjustarLabelFormDown(LB_Telefono, new Point(51, 247));
            TB_Telefono.Focus();
        }

        private void LB_Edad_Click(object sender, EventArgs e)
        {
            Funciones.AjustarLabelFormDown(LB_Edad, new Point(51, 317));
            TB_Edad.Focus();
        }

        private void LB_Estatura_Click(object sender, EventArgs e)
        {
            Funciones.AjustarLabelFormDown(LB_Estatura, new Point(51, 376));
            TB_Estatura.Focus();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Funciones.RegresarEstadoOriginal(TB_Nombre, LB_Name, value => Nombre = value, new Point(51, 140));
            
        }

        private void TB_Apellido_Leave(object sender, EventArgs e)
        {
            Funciones.RegresarEstadoOriginal(TB_Apellido, LB_Apellido, value =>  Apellido = value, new Point(51, 201));
        }

        private void TB_Telefono_Leave(object sender, EventArgs e)
        {
            Funciones.RegresarEstadoOriginal(TB_Telefono, LB_Telefono, value => Telefono = value, new Point(51, 267));
        }

        private void TB_Edad_Leave(object sender, EventArgs e)
        {
            Funciones.RegresarEstadoOriginal(TB_Edad, LB_Edad, value => Edad = int.Parse(value), new Point(51, 327));
        }

        private void TB_Estatura_Leave(object sender, EventArgs e)
        {
            Funciones.RegresarEstadoOriginal(TB_Estatura, LB_Estatura, value => Estatura = int.Parse(value), new Point(51, 396));
        }

        public void BTN_Cancelar_Click(object sender, EventArgs e)
        {
    
            Funciones.LimpiarPaneles(TB_Nombre, TB_Apellido, TB_Telefono, TB_Edad, TB_Estatura);
 
            ReordenarFormulario();
        }

        private async void PB_Male_Click(object sender, EventArgs e)
        {
            Genero = true;
            await ImageManager.CambiarImagen(this, PB_Male, true, Properties.Resources.male_shadow, Properties.Resources.male);
        }

        private async void PB_Female_Click(object sender, EventArgs e)
        {
            Genero = false;
            await ImageManager.CambiarImagen(this, PB_Female, true, Properties.Resources.femenine_shadow, Properties.Resources.femenine);
        }

        private void TB_Estatura_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
        {
            Funciones.ComprobarInts(LB_AdvertenciaEstatura, KeyPressEvent);
        }

        private void TB_Nombre_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
        {
            Funciones.ComprobarStrings(LB_AdvertenciaNombre, KeyPressEvent);
        }

        private void TB_Apellido_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
        {
            Funciones.ComprobarStrings(LB_AdvertenciaApellido, KeyPressEvent);
        }

        private void PB_Male_MouseEnter(object sender, EventArgs e)
        {
            PB_Male.Padding = new Padding(0, 0, 0, 0);
        }

        private void PB_Male_MouseLeave(object sender, EventArgs e)
        {
            PB_Male.Padding = new Padding( 5, 5, 5, 5);
        }

        private void PB_Female_MouseEnter(object sender, EventArgs e)
        {
            PB_Female.Padding = new Padding(0, 0, 0, 0);
        }

        private void PB_Female_MouseLeave(object sender, EventArgs e)
        {
            PB_Female.Padding = new Padding(5, 5, 5, 5);
        }

        private void LB_AdvertenciaNombre_Click(object sender, EventArgs e)
        {

        }

        private void LB_Telefono_Click_1(object sender, EventArgs e)
        {
            Funciones.AjustarLabelFormDown(LB_Telefono, new Point(51, 251));
            TB_Telefono.Focus();
        }
    

        private void TB_Edad_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
        {
            Funciones.ComprobarInts(LB_AdvertenciaEdad, KeyPressEvent);
        }

        private void TB_Telefono_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
        {   
            Funciones.ComprobarInts(LB_AdvertenciaTelefono, KeyPressEvent);
        }


        private void ReordenarFormulario()
        {
            Funciones.AjustarLabelFormDown(LB_Name, new Point(51, 120));
            Funciones.AjustarLabelFormDown(LB_Apellido, new Point(51, 181));
            Funciones.AjustarLabelFormDown(LB_Telefono, new Point(51, 247));
            Funciones.AjustarLabelFormDown(LB_Edad, new Point(51, 317));
            Funciones.AjustarLabelFormDown(LB_Estatura, new Point(51, 376));
            Funciones.AjustarLabelFormUp(LB_Name, new Point(51, 140));
            Funciones.AjustarLabelFormUp(LB_Apellido, new Point(51, 201));
            Funciones.AjustarLabelFormUp(LB_Telefono, new Point(51, 267));
            Funciones.AjustarLabelFormUp(LB_Edad, new Point(51, 327));
            Funciones.AjustarLabelFormUp(LB_Estatura, new Point(51, 396));
        }
    }

}
