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

        
    }

    
}
