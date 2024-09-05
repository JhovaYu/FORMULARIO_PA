using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMULARIO_PA
{
    public static class Funciones
    {
        public static void AjustarLabelFormDown(Label label, Point ubicacion)
        {
            if (label != null)
            {
                label.Location = ubicacion;
                label.ForeColor = SystemColors.WindowFrame;
            }
        }

        public static void AjustarLabelFormUp(Label label, Point ubicacion)
        {
            if (label != null)
            {
                label.Location = ubicacion;
                label.ForeColor = SystemColors.GradientActiveCaption;
            }
        }

        public static void LimpiarPaneles(TextBox Nombre, TextBox Apellido, TextBox Telefono, TextBox Edad, TextBox Estatura)
        {
            Nombre.Clear();
            Apellido.Clear();
            Telefono.Clear();
            Edad.Clear();
            Estatura.Clear();
        }

        public static void ComprobarStrings(Label LB, KeyPressEventArgs KeyPressEvent)
        {

            if (!char.IsLetter(KeyPressEvent.KeyChar) && !char.IsControl(KeyPressEvent.KeyChar))
            {
                LB.Visible = true;
                KeyPressEvent.Handled = true;
            }
            else
            {
                LB.Visible = false;


            }
        }

        public static void ComprobarInts(Label LB, KeyPressEventArgs KeyPressEvent)
        {

            if (!char.IsNumber(KeyPressEvent.KeyChar) && !char.IsControl(KeyPressEvent.KeyChar))
            {
                LB.Visible = true;
                KeyPressEvent.Handled = true;
            }
            else
            {
                LB.Visible = false;


            }
        }

        public static void OcultarAdvertencia(TextBox TB, Label LB)
        {
            LB.Visible = false;
        }
    }

    
}
