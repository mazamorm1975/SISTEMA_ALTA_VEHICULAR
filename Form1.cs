using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPRN3_U2_A1_MAZM
{
    public partial class Form1 : Form
    {
        //variable que contendra el tipo de automovil
        public String tipoAutomovil;

        private clsAltaVehiculo tblVehiculo = new clsAltaVehiculo();

        public Form1()
        {
            InitializeComponent();

            if (clsConexion.CheckConexion())
            {
                Console.WriteLine("Conexion en linea con base de datos.");
                clsConexion.GetConexionClient();
            }
            else
            {
                Console.WriteLine("Ocurrio un error al establecer conexion con base de datos");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsAltaVehiculo alta = new clsAltaVehiculo();
            alta.consultarVehiculo();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tipoAutomovil = cboTipoVehiculo.Text;
            //Las siguientes 4 lineas de codigo son para enviar informacion de un combo box a otro componente en 
            //otro formulario
            Form2 form2 = new Form2();
            form2.Visible = true;
            form2.cboVehiculo.Text = tipoAutomovil;
            //form2.txtRecibe.Text = tipoAutomovil;
            
            DateTime fecha = dtFecha.Value;
            String serie = txtSerie.Text;
            String marca = cboMarca.Text;
            String modelo = cboModelo.Text;
            String verificacion="";
            String anio = cboAnio.Text;
            String color = cboColor.Text;


            if (rdbVerificacionSi.Checked.Equals(true))
            {
                verificacion = rdbVerificacionSi.Text;
            }
            else 
            {
                verificacion = rdbVerificacionNo.Text;
            }

            try
            {
                //Boolean Guardar = tblVehiculo.insertarDatosVehiculo(tipoAutomovil, fecha, marca, modelo, anio, pbImagen, serie, color, verificacion);
                Boolean Guardar = tblVehiculo.insertarDatosVehiculo(tipoAutomovil, fecha, marca, modelo, anio, pbImagen, serie, color, verificacion);
                MessageBox.Show("Información Ingresada Exitosamente en la Base de datos.");
                limpiadoCampos limpiar = new limpiadoCampos();
                limpiar.limpiar(this, groupBox3, groupBox1);

                }
                catch(Exception ex)
                {
                  Console.WriteLine("No fue posible ingresar la informacion en la base de datos. "+ex.Message);
                }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog visualizarVehiculo = new OpenFileDialog();
            visualizarVehiculo.Title = "Seleccione la imagen del tipo de vehiculo";
            visualizarVehiculo.Filter = "*.jpg|*.jpg";
            visualizarVehiculo.InitialDirectory = "C:\\Users\\Dell\\Documents\\Materias UNADM\\7mo. Semestre UNADM\\Unidad 2. Programación .NET III\\Imagenes_Actividad_U2";

            if (visualizarVehiculo.ShowDialog() == DialogResult.OK)
            {
                pbImagen.ImageLocation = visualizarVehiculo.FileName;
            } else
            {
                MessageBox.Show("No fue posible cargar la imagen");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void rdbVerificacionSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtConsultaInformacion_Click(object sender, EventArgs e)
        {
            
            FillGridView();
        }

        private void FillGridView()
        {
            datosTable.DataSource = tblVehiculo.consultarVehiculo();
            DataGridViewImageColumn columnaImagen = (DataGridViewImageColumn)datosTable.Columns[6];
            columnaImagen.ImageLayout = DataGridViewImageCellLayout.Stretch;
            datosTable.Columns[1].Visible = false;
        }
    }
}
