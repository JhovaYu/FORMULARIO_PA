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


namespace FORMULARIO_PA
{
    public partial class Form1 : Form
    {
        private PanelInformation PI;

        String Nombre, Apellido, Telefono;

        int  Edad, Estatura;

        Boolean isClose, Genero;

        private bool _actualizandoTexto = false;

        HashSet<char> valoresPermitidos = new HashSet<char>
{
    '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.'
};

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

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
            if(TB_Nombre.Text == "" )
            {
                Funciones.AjustarLabelFormUp(LB_Name, new Point(51, 140));
            }

            Nombre = TB_Nombre.Text;
            //Cancel = false;
        }

        private void TB_Apellido_Leave(object sender, EventArgs e)
        {
            if (TB_Apellido.Text == "")
            {
                Funciones.AjustarLabelFormUp(LB_Apellido, new Point(51, 201));
            }
            Apellido = TB_Apellido.Text;
        }

            private void TB_Telefono_Leave(object sender, EventArgs e)
            {
                if (TB_Telefono.Text == "")
                {
                    Funciones.AjustarLabelFormUp(LB_Telefono, new Point(51, 267));
                }

            
                
                {
                    Telefono = (TB_Telefono.Text);
                }
                
           

        }

        private void TB_Edad_Leave(object sender, EventArgs e)
        {
            if (TB_Edad.Text == "")
            {
                Funciones.AjustarLabelFormUp(LB_Edad, new Point(51, 327));
            }
            if (TB_Edad.Text != "")
            {
                Edad = int.Parse(TB_Edad.Text);
            }
        }

        private void TB_Estatura_Leave(object sender, EventArgs e)
        {
            if (TB_Estatura.Text == "" | MainPanel.Focus() == true)
            {
                Funciones.AjustarLabelFormUp(LB_Estatura, new Point(51, 396));
            }
            if (TB_Estatura.Text != "")
            {
                Estatura = int.Parse(TB_Estatura.Text);
            }
        }

        public void BTN_Cancelar_Click(object sender, EventArgs e)
        {
    
            Funciones.LimpiarPaneles(TB_Nombre, TB_Apellido, TB_Telefono, TB_Edad, TB_Estatura);
 
            ReordenarFormulario();
        }

        private void PB_Male_Click(object sender, EventArgs e)
        {
            Genero = true;
        }

        private void PB_Female_Click(object sender, EventArgs e)
        {
            Genero = false;
        }

        private void TB_Estatura_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
        {
            KeyPressEvent.Handled = !char.IsDigit(KeyPressEvent.KeyChar);
        }

        private void TB_Nombre_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
        {
            KeyPressEvent.Handled = char.IsDigit(KeyPressEvent.KeyChar);
        }

        private void TB_Apellido_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
        {
            KeyPressEvent.Handled = char.IsDigit(KeyPressEvent.KeyChar);
        }

        private void PB_Male_MouseEnter(object sender, EventArgs e)
        {
            PB_Male.Size = new Size(54, 51);
        }

        private void PB_Male_MouseLeave(object sender, EventArgs e)
        {
            PB_Male.Size = new Size(43, 43);
        }

        private void PB_Female_MouseEnter(object sender, EventArgs e)
        {
            PB_Female.Size = new Size(54, 51);
        }

        private void PB_Female_MouseLeave(object sender, EventArgs e)
        {
            PB_Female.Size = new Size(46, 46);
        }

        private void LB_Telefono_Click_1(object sender, EventArgs e)
        {
            Funciones.AjustarLabelFormDown(LB_Telefono, new Point(51, 251));
            TB_Telefono.Focus();
        }
    

        private void TB_Edad_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
        {
            KeyPressEvent.Handled = !char.IsDigit(KeyPressEvent.KeyChar);
        }

        private void TB_Telefono_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
        {
            KeyPressEvent.Handled = !char.IsDigit(KeyPressEvent.KeyChar);
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
