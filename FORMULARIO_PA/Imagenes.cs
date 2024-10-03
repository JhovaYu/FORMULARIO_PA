using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMULARIO_PA
{

    public class ImageManager
    {
        public static async Task CambiarImagen(Form form, PictureBox pictureBox, bool genero, Bitmap imagenTemporal, Bitmap imagenDefecto)
        {
            if (form is Form1 form1)
            {
                form1.Genero = genero;
            }

            pictureBox.Image = imagenTemporal;

            await Task.Delay(1000);

            pictureBox.Image = imagenDefecto;

        }
    }
}
