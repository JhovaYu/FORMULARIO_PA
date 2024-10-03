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
            bool esValido = char.IsLetter(KeyPressEvent.KeyChar) ||
                    KeyPressEvent.KeyChar == (char)Keys.Space ||
                    KeyPressEvent.KeyChar == (char)Keys.Back;

            KeyPressEvent.Handled = !esValido;

            LB.Visible = !esValido;
        }

        public static void ComprobarInts(Label LB, KeyPressEventArgs KeyPressEvent)
        {
            bool esValido = char.IsDigit(KeyPressEvent.KeyChar) || char.IsControl(KeyPressEvent.KeyChar);
            KeyPressEvent.Handled = !esValido;
            LB.Visible = !esValido;
        }

        public static void OcultarAdvertencia(TextBox TB, Label LB)
        {
            LB.Visible = false;
        }
    }

    
}
