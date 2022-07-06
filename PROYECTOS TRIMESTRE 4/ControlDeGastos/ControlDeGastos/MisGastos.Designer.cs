namespace ControlDeGastos
{
    partial class MisGastos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMisGastos = new System.Windows.Forms.Label();
            this.gbIngresosGastos = new System.Windows.Forms.GroupBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.bttnMetodoPago = new System.Windows.Forms.Button();
            this.cbMetodoPago = new System.Windows.Forms.ComboBox();
            this.txtboxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnMore = new System.Windows.Forms.Button();
            this.lblGasto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txtboxCantidad = new System.Windows.Forms.TextBox();
            this.txtboxDescrip = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbConcepto = new System.Windows.Forms.ComboBox();
            this.bttAgregar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.dtgGastos = new System.Windows.Forms.DataGridView();
            this.bttnClose = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.gbIngresosGastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMisGastos
            // 
            this.lblMisGastos.AutoSize = true;
            this.lblMisGastos.Font = new System.Drawing.Font("Montserrat Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMisGastos.Location = new System.Drawing.Point(259, 14);
            this.lblMisGastos.Name = "lblMisGastos";
            this.lblMisGastos.Size = new System.Drawing.Size(222, 51);
            this.lblMisGastos.TabIndex = 0;
            this.lblMisGastos.Text = "Mis Gastos";
            // 
            // gbIngresosGastos
            // 
            this.gbIngresosGastos.Controls.Add(this.lblMonto);
            this.gbIngresosGastos.Controls.Add(this.txtMonto);
            this.gbIngresosGastos.Controls.Add(this.lblMetodoPago);
            this.gbIngresosGastos.Controls.Add(this.bttnMetodoPago);
            this.gbIngresosGastos.Controls.Add(this.cbMetodoPago);
            this.gbIngresosGastos.Controls.Add(this.txtboxID);
            this.gbIngresosGastos.Controls.Add(this.label1);
            this.gbIngresosGastos.Controls.Add(this.bttnMore);
            this.gbIngresosGastos.Controls.Add(this.lblGasto);
            this.gbIngresosGastos.Controls.Add(this.lblCantidad);
            this.gbIngresosGastos.Controls.Add(this.txtGasto);
            this.gbIngresosGastos.Controls.Add(this.lblDescrip);
            this.gbIngresosGastos.Controls.Add(this.lblConcepto);
            this.gbIngresosGastos.Controls.Add(this.txtboxCantidad);
            this.gbIngresosGastos.Controls.Add(this.txtboxDescrip);
            this.gbIngresosGastos.Controls.Add(this.dtpFecha);
            this.gbIngresosGastos.Controls.Add(this.cbConcepto);
            this.gbIngresosGastos.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIngresosGastos.Location = new System.Drawing.Point(12, 72);
            this.gbIngresosGastos.Name = "gbIngresosGastos";
            this.gbIngresosGastos.Size = new System.Drawing.Size(323, 330);
            this.gbIngresosGastos.TabIndex = 1;
            this.gbIngresosGastos.TabStop = false;
            this.gbIngresosGastos.Text = "Ingresos y Gastos";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(154, 191);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(50, 18);
            this.lblMonto.TabIndex = 19;
            this.lblMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonto.Location = new System.Drawing.Point(157, 212);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(151, 16);
            this.txtMonto.TabIndex = 18;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Location = new System.Drawing.Point(6, 235);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(115, 18);
            this.lblMetodoPago.TabIndex = 17;
            this.lblMetodoPago.Text = "Metodo de pago";
            // 
            // bttnMetodoPago
            // 
            this.bttnMetodoPago.BackColor = System.Drawing.Color.DarkGray;
            this.bttnMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMetodoPago.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnMetodoPago.Location = new System.Drawing.Point(278, 256);
            this.bttnMetodoPago.Name = "bttnMetodoPago";
            this.bttnMetodoPago.Size = new System.Drawing.Size(30, 26);
            this.bttnMetodoPago.TabIndex = 16;
            this.bttnMetodoPago.Text = "...";
            this.bttnMetodoPago.UseVisualStyleBackColor = false;
            this.bttnMetodoPago.Click += new System.EventHandler(this.bttnMetodoPago_Click);
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMetodoPago.FormattingEnabled = true;
            this.cbMetodoPago.Location = new System.Drawing.Point(6, 256);
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.Size = new System.Drawing.Size(266, 26);
            this.cbMetodoPago.TabIndex = 15;
            this.cbMetodoPago.Click += new System.EventHandler(this.cbMetodoPago_Click);
            // 
            // txtboxID
            // 
            this.txtboxID.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtboxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxID.Enabled = false;
            this.txtboxID.Location = new System.Drawing.Point(255, 22);
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.ReadOnly = true;
            this.txtboxID.Size = new System.Drawing.Size(53, 16);
            this.txtboxID.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // bttnMore
            // 
            this.bttnMore.BackColor = System.Drawing.Color.DarkGray;
            this.bttnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnMore.Location = new System.Drawing.Point(278, 108);
            this.bttnMore.Name = "bttnMore";
            this.bttnMore.Size = new System.Drawing.Size(30, 26);
            this.bttnMore.TabIndex = 12;
            this.bttnMore.Text = "...";
            this.bttnMore.UseVisualStyleBackColor = false;
            this.bttnMore.Click += new System.EventHandler(this.bttnMore_Click);
            // 
            // lblGasto
            // 
            this.lblGasto.AutoSize = true;
            this.lblGasto.Location = new System.Drawing.Point(3, 33);
            this.lblGasto.Name = "lblGasto";
            this.lblGasto.Size = new System.Drawing.Size(46, 18);
            this.lblGasto.TabIndex = 9;
            this.lblGasto.Text = "Gasto";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(6, 191);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(69, 18);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtGasto
            // 
            this.txtGasto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtGasto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGasto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGasto.Location = new System.Drawing.Point(6, 56);
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.Size = new System.Drawing.Size(302, 16);
            this.txtGasto.TabIndex = 8;
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(6, 140);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(87, 18);
            this.lblDescrip.TabIndex = 6;
            this.lblDescrip.Text = "Descripcion";
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(3, 83);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(71, 18);
            this.lblConcepto.TabIndex = 5;
            this.lblConcepto.Text = "Concepto";
            // 
            // txtboxCantidad
            // 
            this.txtboxCantidad.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtboxCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxCantidad.Location = new System.Drawing.Point(6, 212);
            this.txtboxCantidad.Name = "txtboxCantidad";
            this.txtboxCantidad.Size = new System.Drawing.Size(145, 16);
            this.txtboxCantidad.TabIndex = 4;
            // 
            // txtboxDescrip
            // 
            this.txtboxDescrip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtboxDescrip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxDescrip.Location = new System.Drawing.Point(6, 165);
            this.txtboxDescrip.Name = "txtboxDescrip";
            this.txtboxDescrip.Size = new System.Drawing.Size(302, 16);
            this.txtboxDescrip.TabIndex = 3;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarForeColor = System.Drawing.Color.IndianRed;
            this.dtpFecha.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dtpFecha.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpFecha.Location = new System.Drawing.Point(6, 298);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(302, 23);
            this.dtpFecha.TabIndex = 2;
            // 
            // cbConcepto
            // 
            this.cbConcepto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbConcepto.FormattingEnabled = true;
            this.cbConcepto.Location = new System.Drawing.Point(6, 108);
            this.cbConcepto.Name = "cbConcepto";
            this.cbConcepto.Size = new System.Drawing.Size(266, 26);
            this.cbConcepto.TabIndex = 0;
            this.cbConcepto.Click += new System.EventHandler(this.cbConcepto_Click);
            // 
            // bttAgregar
            // 
            this.bttAgregar.BackColor = System.Drawing.Color.OrangeRed;
            this.bttAgregar.FlatAppearance.BorderSize = 0;
            this.bttAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAgregar.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttAgregar.Location = new System.Drawing.Point(203, 408);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(178, 40);
            this.bttAgregar.TabIndex = 11;
            this.bttAgregar.Text = "Agregar";
            this.bttAgregar.UseVisualStyleBackColor = false;
            this.bttAgregar.Click += new System.EventHandler(this.bttAgregar_Click);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.bttnCancelar.FlatAppearance.BorderSize = 0;
            this.bttnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCancelar.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnCancelar.Location = new System.Drawing.Point(12, 408);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(185, 40);
            this.bttnCancelar.TabIndex = 10;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = false;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // dtgGastos
            // 
            this.dtgGastos.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dtgGastos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgGastos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgGastos.GridColor = System.Drawing.Color.Black;
            this.dtgGastos.Location = new System.Drawing.Point(341, 80);
            this.dtgGastos.Name = "dtgGastos";
            this.dtgGastos.Size = new System.Drawing.Size(418, 322);
            this.dtgGastos.TabIndex = 2;
            this.dtgGastos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgGastos_CellDoubleClick);
            // 
            // bttnClose
            // 
            this.bttnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnClose.FlatAppearance.BorderSize = 0;
            this.bttnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnClose.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttnClose.Location = new System.Drawing.Point(730, 0);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(41, 28);
            this.bttnClose.TabIndex = 15;
            this.bttnClose.Text = "x";
            this.bttnClose.UseVisualStyleBackColor = false;
            this.bttnClose.BackColorChanged += new System.EventHandler(this.bttnClose_Click);
            this.bttnClose.Click += new System.EventHandler(this.bttnClose_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.bttnEliminar.FlatAppearance.BorderSize = 0;
            this.bttnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEliminar.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnEliminar.Location = new System.Drawing.Point(387, 408);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(186, 40);
            this.bttnEliminar.TabIndex = 16;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = false;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.BackColor = System.Drawing.Color.OrangeRed;
            this.bttnGuardar.FlatAppearance.BorderSize = 0;
            this.bttnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGuardar.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnGuardar.Location = new System.Drawing.Point(579, 408);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(180, 40);
            this.bttnGuardar.TabIndex = 17;
            this.bttnGuardar.Text = "Guardar";
            this.bttnGuardar.UseVisualStyleBackColor = false;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // MisGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 460);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.bttnClose);
            this.Controls.Add(this.dtgGastos);
            this.Controls.Add(this.gbIngresosGastos);
            this.Controls.Add(this.lblMisGastos);
            this.Controls.Add(this.bttAgregar);
            this.Controls.Add(this.bttnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(474, 450);
            this.Name = "MisGastos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar";
            this.TransparencyKey = System.Drawing.Color.YellowGreen;
            this.gbIngresosGastos.ResumeLayout(false);
            this.gbIngresosGastos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMisGastos;
        private System.Windows.Forms.GroupBox gbIngresosGastos;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.TextBox txtboxCantidad;
        private System.Windows.Forms.TextBox txtboxDescrip;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbConcepto;
        private System.Windows.Forms.Label lblGasto;
        private System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.DataGridView dtgGastos;
        private System.Windows.Forms.Button bttnMore;
        private System.Windows.Forms.TextBox txtboxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnClose;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Button bttnMetodoPago;
        private System.Windows.Forms.ComboBox cbMetodoPago;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Button bttnGuardar;
    }
}

