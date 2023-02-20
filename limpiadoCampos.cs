using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPRN3_U2_A1_MAZM
{
    class limpiadoCampos
    {
        public void limpiar(Control control, GroupBox gb, GroupBox gb2)
        {
            foreach(var txt in control.Controls)
            {
                if(txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if(txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = 0;
                } 
            }


            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Clear();
                }
                else if (combo is PictureBox)
                {
                    ((PictureBox)combo).Visible = true;
                }
            }


            foreach (var combo in gb2.Controls)
            {
                if (combo is RadioButton)
                {
                    ((RadioButton)combo).Checked = false;
                }
            }



        }

    }
}
