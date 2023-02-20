using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;


namespace DPRN3_U2_A1_MAZM
{
    class ClaseImagen
    {
        //Convierte una imagen a byte
        public static MemoryStream ByteAImagen(byte[] array)
        {
            MemoryStream ms = new MemoryStream((byte[]) array);
            return ms;

        }

        //Se realiza el proceso inverso, convierte un array de bytes a imageg
        public static byte[] ImagenAByte(Image imagen)
        {
            MemoryStream ms2 = new MemoryStream();
            imagen.Save(ms2, ImageFormat.Jpeg);

            return ms2.ToArray();
        }


    }
}
