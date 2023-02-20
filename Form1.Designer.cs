
namespace DPRN3_U2_A1_MAZM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbVerificacionNo = new System.Windows.Forms.RadioButton();
            this.rdbVerificacionSi = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEnviaInformacion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.datosTable = new System.Windows.Forms.DataGridView();
            this.txtConsultaInformacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(6, 19);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(284, 183);
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo_Vehiculo";
            // 
            // cboTipoVehiculo
            // 
            this.cboTipoVehiculo.FormattingEnabled = true;
            this.cboTipoVehiculo.Items.AddRange(new object[] {
            "Seleccione Vehiculo",
            "Sedan",
            "Pick-Up",
            "Motocicleta"});
            this.cboTipoVehiculo.Location = new System.Drawing.Point(125, 13);
            this.cboTipoVehiculo.Name = "cboTipoVehiculo";
            this.cboTipoVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cboTipoVehiculo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "No. Serie";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(125, 53);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(216, 20);
            this.txtSerie.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha_Adquisición";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(125, 92);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 8;
            // 
            // cboModelo
            // 
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Items.AddRange(new object[] {
            "Seleccione Modelo",
            "Aveo",
            "Onix",
            "Cavalier",
            "Chevy",
            "Spark",
            "Sonic",
            "Cruze",
            "Corsa",
            "Malibu",
            "Cavalier",
            "Astra",
            "Matiz",
            "Jetta",
            "Vento",
            "Jetta Clasico",
            "Beetle",
            "Gol",
            "Pointer",
            "Golf",
            "Bora",
            "Sedan",
            "Passat"});
            this.cboModelo.Location = new System.Drawing.Point(125, 133);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(156, 21);
            this.cboModelo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Modelo";
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Items.AddRange(new object[] {
            "Selecciona Marca",
            "Chevrolet",
            "Volkswagen",
            "Nissan",
            "Ford",
            "Honda",
            "Toyota",
            "Dodge",
            "Mazda",
            "Seat",
            "BMW"});
            this.cboMarca.Location = new System.Drawing.Point(125, 178);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 11;
            // 
            // cboAnio
            // 
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Items.AddRange(new object[] {
            "Seleccione Año",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cboAnio.Location = new System.Drawing.Point(125, 219);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(121, 21);
            this.cboAnio.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Año";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbVerificacionNo);
            this.groupBox1.Controls.Add(this.rdbVerificacionSi);
            this.groupBox1.Location = new System.Drawing.Point(16, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 70);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verificación";
            // 
            // rdbVerificacionNo
            // 
            this.rdbVerificacionNo.AutoSize = true;
            this.rdbVerificacionNo.Location = new System.Drawing.Point(152, 29);
            this.rdbVerificacionNo.Name = "rdbVerificacionNo";
            this.rdbVerificacionNo.Size = new System.Drawing.Size(89, 17);
            this.rdbVerificacionNo.TabIndex = 1;
            this.rdbVerificacionNo.TabStop = true;
            this.rdbVerificacionNo.Text = "No Realizada";
            this.rdbVerificacionNo.UseVisualStyleBackColor = true;
            // 
            // rdbVerificacionSi
            // 
            this.rdbVerificacionSi.AutoSize = true;
            this.rdbVerificacionSi.Location = new System.Drawing.Point(15, 29);
            this.rdbVerificacionSi.Name = "rdbVerificacionSi";
            this.rdbVerificacionSi.Size = new System.Drawing.Size(72, 17);
            this.rdbVerificacionSi.TabIndex = 0;
            this.rdbVerificacionSi.TabStop = true;
            this.rdbVerificacionSi.Text = "Realizada";
            this.rdbVerificacionSi.UseVisualStyleBackColor = true;
            this.rdbVerificacionSi.CheckedChanged += new System.EventHandler(this.rdbVerificacionSi_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Color";
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Items.AddRange(new object[] {
            "Seleccione Color",
            "Rojo",
            "Negro",
            "Amarillo",
            "Gris",
            "Azul"});
            this.cboColor.Location = new System.Drawing.Point(125, 263);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(121, 21);
            this.cboColor.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnEnviaInformacion);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(367, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 144);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(284, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEnviaInformacion
            // 
            this.btnEnviaInformacion.Location = new System.Drawing.Point(6, 66);
            this.btnEnviaInformacion.Name = "btnEnviaInformacion";
            this.btnEnviaInformacion.Size = new System.Drawing.Size(284, 32);
            this.btnEnviaInformacion.TabIndex = 1;
            this.btnEnviaInformacion.Text = "Guardar Informacion ";
            this.btnEnviaInformacion.UseVisualStyleBackColor = true;
            this.btnEnviaInformacion.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Seleccionar Imagen Automovil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbImagen);
            this.groupBox3.Location = new System.Drawing.Point(373, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 208);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Despliege De Resultados";
            // 
            // datosTable
            // 
            this.datosTable.AllowUserToAddRows = false;
            this.datosTable.AllowUserToDeleteRows = false;
            this.datosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosTable.Location = new System.Drawing.Point(675, 12);
            this.datosTable.Name = "datosTable";
            this.datosTable.ReadOnly = true;
            this.datosTable.Size = new System.Drawing.Size(362, 201);
            this.datosTable.TabIndex = 20;
            // 
            // txtConsultaInformacion
            // 
            this.txtConsultaInformacion.Location = new System.Drawing.Point(707, 238);
            this.txtConsultaInformacion.Name = "txtConsultaInformacion";
            this.txtConsultaInformacion.Size = new System.Drawing.Size(281, 27);
            this.txtConsultaInformacion.TabIndex = 21;
            this.txtConsultaInformacion.Text = "Consultar Informacion";
            this.txtConsultaInformacion.UseVisualStyleBackColor = true;
            this.txtConsultaInformacion.Click += new System.EventHandler(this.txtConsultaInformacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 376);
            this.Controls.Add(this.txtConsultaInformacion);
            this.Controls.Add(this.datosTable);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboAnio);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboModelo);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTipoVehiculo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SISTEMA ALTA DE VEHICULOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datosTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbVerificacionNo;
        private System.Windows.Forms.RadioButton rdbVerificacionSi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEnviaInformacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button txtConsultaInformacion;
        private System.Windows.Forms.DataGridView datosTable;
        public System.Windows.Forms.PictureBox pbImagen;
        public System.Windows.Forms.ComboBox cboTipoVehiculo;
    }
}

