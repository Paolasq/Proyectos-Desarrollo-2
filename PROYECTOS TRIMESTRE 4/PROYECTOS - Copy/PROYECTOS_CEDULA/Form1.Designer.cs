namespace PROYECTOS_CEDULA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbRD = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtBoxCedula = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.dtpExpiracion = new System.Windows.Forms.DateTimePicker();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblexp = new System.Windows.Forms.Label();
            this.cbSangre = new System.Windows.Forms.ComboBox();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.txtBoxNacionalidad = new System.Windows.Forms.TextBox();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.txtBoxOcupacion = new System.Windows.Forms.TextBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.txtBoxEstadoCivil = new System.Windows.Forms.TextBox();
            this.lblSangre = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtboxLugarNaci = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNaci = new System.Windows.Forms.Label();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnCrear = new System.Windows.Forms.Button();
            this.lblJCE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCiudadanos = new System.Windows.Forms.DataGridView();
            this.bttnSubirFoto = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.gbDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudadanos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRD
            // 
            this.lbRD.AutoSize = true;
            this.lbRD.Font = new System.Drawing.Font("Montserrat ExtraBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbRD.Location = new System.Drawing.Point(369, 9);
            this.lbRD.Name = "lbRD";
            this.lbRD.Size = new System.Drawing.Size(301, 29);
            this.lbRD.TabIndex = 1;
            this.lbRD.Text = "REPÚBLICA DOMINICANA";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(14, 38);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(47, 15);
            this.lblCedula.TabIndex = 2;
            this.lblCedula.Text = "Cédula";
            // 
            // txtBoxCedula
            // 
            this.txtBoxCedula.Location = new System.Drawing.Point(63, 35);
            this.txtBoxCedula.Name = "txtBoxCedula";
            this.txtBoxCedula.Size = new System.Drawing.Size(337, 21);
            this.txtBoxCedula.TabIndex = 3;
            // 
            // pbFoto
            // 
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFoto.InitialImage")));
            this.pbFoto.Location = new System.Drawing.Point(21, 98);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(185, 264);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Controls.Add(this.dtpExpiracion);
            this.gbDatosPersonales.Controls.Add(this.dtpNacimiento);
            this.gbDatosPersonales.Controls.Add(this.label2);
            this.gbDatosPersonales.Controls.Add(this.lblexp);
            this.gbDatosPersonales.Controls.Add(this.cbSangre);
            this.gbDatosPersonales.Controls.Add(this.rbFemenino);
            this.gbDatosPersonales.Controls.Add(this.rbMasculino);
            this.gbDatosPersonales.Controls.Add(this.txtBoxNacionalidad);
            this.gbDatosPersonales.Controls.Add(this.lblOcupacion);
            this.gbDatosPersonales.Controls.Add(this.txtBoxOcupacion);
            this.gbDatosPersonales.Controls.Add(this.lblEstadoCivil);
            this.gbDatosPersonales.Controls.Add(this.txtBoxEstadoCivil);
            this.gbDatosPersonales.Controls.Add(this.lblSangre);
            this.gbDatosPersonales.Controls.Add(this.lblSexo);
            this.gbDatosPersonales.Controls.Add(this.txtboxLugarNaci);
            this.gbDatosPersonales.Controls.Add(this.label4);
            this.gbDatosPersonales.Controls.Add(this.lblNaci);
            this.gbDatosPersonales.Controls.Add(this.txtBoxCedula);
            this.gbDatosPersonales.Controls.Add(this.lblCedula);
            this.gbDatosPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbDatosPersonales.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosPersonales.Location = new System.Drawing.Point(212, 98);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(419, 300);
            this.gbDatosPersonales.TabIndex = 4;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos Personales";
            // 
            // dtpExpiracion
            // 
            this.dtpExpiracion.Location = new System.Drawing.Point(139, 266);
            this.dtpExpiracion.Name = "dtpExpiracion";
            this.dtpExpiracion.Size = new System.Drawing.Size(260, 21);
            this.dtpExpiracion.TabIndex = 24;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(16, 137);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(383, 21);
            this.dtpNacimiento.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fecha de Nacimiento";
            // 
            // lblexp
            // 
            this.lblexp.AutoSize = true;
            this.lblexp.Location = new System.Drawing.Point(13, 266);
            this.lblexp.Name = "lblexp";
            this.lblexp.Size = new System.Drawing.Size(120, 15);
            this.lblexp.TabIndex = 21;
            this.lblexp.Text = "Fecha de expiración";
            // 
            // cbSangre
            // 
            this.cbSangre.FormattingEnabled = true;
            this.cbSangre.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.cbSangre.Location = new System.Drawing.Point(178, 200);
            this.cbSangre.Name = "cbSangre";
            this.cbSangre.Size = new System.Drawing.Size(46, 23);
            this.cbSangre.TabIndex = 20;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbFemenino.Location = new System.Drawing.Point(97, 200);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(31, 19);
            this.rbFemenino.TabIndex = 19;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "F";
            this.rbFemenino.UseVisualStyleBackColor = true;
            this.rbFemenino.CheckedChanged += new System.EventHandler(this.rbFemenino_CheckedChanged);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbMasculino.Location = new System.Drawing.Point(55, 200);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(35, 19);
            this.rbMasculino.TabIndex = 18;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "M";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtBoxNacionalidad
            // 
            this.txtBoxNacionalidad.Location = new System.Drawing.Point(99, 170);
            this.txtBoxNacionalidad.Name = "txtBoxNacionalidad";
            this.txtBoxNacionalidad.Size = new System.Drawing.Size(301, 21);
            this.txtBoxNacionalidad.TabIndex = 17;
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Location = new System.Drawing.Point(14, 233);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(67, 15);
            this.lblOcupacion.TabIndex = 15;
            this.lblOcupacion.Text = "Ocupacion";
            // 
            // txtBoxOcupacion
            // 
            this.txtBoxOcupacion.Location = new System.Drawing.Point(86, 230);
            this.txtBoxOcupacion.Name = "txtBoxOcupacion";
            this.txtBoxOcupacion.Size = new System.Drawing.Size(313, 21);
            this.txtBoxOcupacion.TabIndex = 14;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(228, 204);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(73, 15);
            this.lblEstadoCivil.TabIndex = 13;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // txtBoxEstadoCivil
            // 
            this.txtBoxEstadoCivil.Location = new System.Drawing.Point(307, 201);
            this.txtBoxEstadoCivil.Name = "txtBoxEstadoCivil";
            this.txtBoxEstadoCivil.Size = new System.Drawing.Size(92, 21);
            this.txtBoxEstadoCivil.TabIndex = 12;
            // 
            // lblSangre
            // 
            this.lblSangre.AutoSize = true;
            this.lblSangre.Location = new System.Drawing.Point(129, 202);
            this.lblSangre.Name = "lblSangre";
            this.lblSangre.Size = new System.Drawing.Size(48, 15);
            this.lblSangre.TabIndex = 11;
            this.lblSangre.Text = "Sangre";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(14, 202);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 15);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Sexo";
            // 
            // txtboxLugarNaci
            // 
            this.txtboxLugarNaci.Location = new System.Drawing.Point(17, 85);
            this.txtboxLugarNaci.Name = "txtboxLugarNaci";
            this.txtboxLugarNaci.Size = new System.Drawing.Size(382, 21);
            this.txtboxLugarNaci.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nacionalidad";
            // 
            // lblNaci
            // 
            this.lblNaci.AutoSize = true;
            this.lblNaci.Location = new System.Drawing.Point(14, 67);
            this.lblNaci.Name = "lblNaci";
            this.lblNaci.Size = new System.Drawing.Size(128, 15);
            this.lblNaci.TabIndex = 5;
            this.lblNaci.Text = "Lugar de Nacimiento";
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.BackColor = System.Drawing.Color.Red;
            this.bttnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnEliminar.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEliminar.ForeColor = System.Drawing.Color.Maroon;
            this.bttnEliminar.Location = new System.Drawing.Point(324, 404);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(93, 23);
            this.bttnEliminar.TabIndex = 28;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = false;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // bttnCrear
            // 
            this.bttnCrear.BackColor = System.Drawing.Color.Lime;
            this.bttnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnCrear.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCrear.ForeColor = System.Drawing.Color.DarkGreen;
            this.bttnCrear.Location = new System.Drawing.Point(212, 404);
            this.bttnCrear.Name = "bttnCrear";
            this.bttnCrear.Size = new System.Drawing.Size(106, 23);
            this.bttnCrear.TabIndex = 26;
            this.bttnCrear.Text = "Crear";
            this.bttnCrear.UseVisualStyleBackColor = false;
            this.bttnCrear.Click += new System.EventHandler(this.bttnCrear_Click);
            // 
            // lblJCE
            // 
            this.lblJCE.AutoSize = true;
            this.lblJCE.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblJCE.Location = new System.Drawing.Point(398, 35);
            this.lblJCE.Name = "lblJCE";
            this.lblJCE.Size = new System.Drawing.Size(241, 21);
            this.lblJCE.TabIndex = 6;
            this.lblJCE.Text = "JUNTA CENTRAL ELECTORAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 7.749996F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(403, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "CÉDULA DE IDENTIDAD Y ELECTORAL";
            // 
            // dgvCiudadanos
            // 
            this.dgvCiudadanos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCiudadanos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCiudadanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCiudadanos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCiudadanos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvCiudadanos.Location = new System.Drawing.Point(637, 98);
            this.dgvCiudadanos.Name = "dgvCiudadanos";
            this.dgvCiudadanos.Size = new System.Drawing.Size(444, 329);
            this.dgvCiudadanos.TabIndex = 8;
            this.dgvCiudadanos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCiudadanos_CellDoubleClick);
            // 
            // bttnSubirFoto
            // 
            this.bttnSubirFoto.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSubirFoto.Location = new System.Drawing.Point(21, 368);
            this.bttnSubirFoto.Name = "bttnSubirFoto";
            this.bttnSubirFoto.Size = new System.Drawing.Size(185, 23);
            this.bttnSubirFoto.TabIndex = 24;
            this.bttnSubirFoto.Text = "Subir Foto";
            this.bttnSubirFoto.UseVisualStyleBackColor = true;
            this.bttnSubirFoto.Click += new System.EventHandler(this.bttnSubirFoto_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(18, 408);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 15);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.Text = "Nombre";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(70, 404);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(136, 20);
            this.txtBoxNombre.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1002, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.BackColor = System.Drawing.Color.DarkOrange;
            this.bttnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnGuardar.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGuardar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bttnGuardar.Location = new System.Drawing.Point(423, 404);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(109, 23);
            this.bttnGuardar.TabIndex = 29;
            this.bttnGuardar.Text = "Guardar";
            this.bttnGuardar.UseVisualStyleBackColor = false;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.BackColor = System.Drawing.Color.Turquoise;
            this.bttnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnCancelar.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancelar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bttnCancelar.Location = new System.Drawing.Point(538, 404);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(93, 23);
            this.bttnCancelar.TabIndex = 30;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = false;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1093, 454);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bttnCrear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.bttnSubirFoto);
            this.Controls.Add(this.dgvCiudadanos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJCE);
            this.Controls.Add(this.gbDatosPersonales);
            this.Controls.Add(this.lbRD);
            this.Controls.Add(this.pbFoto);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudadanos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRD;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtBoxCedula;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.Label lblNaci;
        private System.Windows.Forms.Label lblOcupacion;
        private System.Windows.Forms.TextBox txtBoxOcupacion;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.TextBox txtBoxEstadoCivil;
        private System.Windows.Forms.Label lblSangre;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtboxLugarNaci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblJCE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNacionalidad;
        private System.Windows.Forms.ComboBox cbSangre;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label lblexp;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Button bttnCrear;
        private System.Windows.Forms.DateTimePicker dtpExpiracion;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCiudadanos;
        private System.Windows.Forms.Button bttnSubirFoto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.Button bttnCancelar;
    }
}

