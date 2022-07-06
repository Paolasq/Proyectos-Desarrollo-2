namespace ControlDeGastos
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
            this.bttnMore = new System.Windows.Forms.Button();
            this.dtgGastos = new System.Windows.Forms.DataGridView();
            this.gbIngresosGastos = new System.Windows.Forms.GroupBox();
            this.bttAgregar = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.lblGasto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtboxGasto = new System.Windows.Forms.TextBox();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txtboxCantidad = new System.Windows.Forms.TextBox();
            this.txtboxDescrip = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbConcepto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGastos)).BeginInit();
            this.gbIngresosGastos.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnMore
            // 
            this.bttnMore.BackColor = System.Drawing.Color.DarkGray;
            this.bttnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnMore.Location = new System.Drawing.Point(310, 194);
            this.bttnMore.Name = "bttnMore";
            this.bttnMore.Size = new System.Drawing.Size(30, 26);
            this.bttnMore.TabIndex = 16;
            this.bttnMore.Text = "...";
            this.bttnMore.UseVisualStyleBackColor = false;
            // 
            // dtgGastos
            // 
            this.dtgGastos.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dtgGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGastos.Location = new System.Drawing.Point(361, 87);
            this.dtgGastos.Name = "dtgGastos";
            this.dtgGastos.Size = new System.Drawing.Size(408, 349);
            this.dtgGastos.TabIndex = 15;
            // 
            // gbIngresosGastos
            // 
            this.gbIngresosGastos.Controls.Add(this.bttAgregar);
            this.gbIngresosGastos.Controls.Add(this.bttCancelar);
            this.gbIngresosGastos.Controls.Add(this.lblGasto);
            this.gbIngresosGastos.Controls.Add(this.lblCantidad);
            this.gbIngresosGastos.Controls.Add(this.txtboxGasto);
            this.gbIngresosGastos.Controls.Add(this.lblDescrip);
            this.gbIngresosGastos.Controls.Add(this.lblConcepto);
            this.gbIngresosGastos.Controls.Add(this.txtboxCantidad);
            this.gbIngresosGastos.Controls.Add(this.txtboxDescrip);
            this.gbIngresosGastos.Controls.Add(this.dtpFecha);
            this.gbIngresosGastos.Controls.Add(this.cbConcepto);
            this.gbIngresosGastos.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIngresosGastos.Location = new System.Drawing.Point(32, 87);
            this.gbIngresosGastos.Name = "gbIngresosGastos";
            this.gbIngresosGastos.Size = new System.Drawing.Size(323, 349);
            this.gbIngresosGastos.TabIndex = 14;
            this.gbIngresosGastos.TabStop = false;
            this.gbIngresosGastos.Text = "Ingresos y Gastos";
            // 
            // bttAgregar
            // 
            this.bttAgregar.BackColor = System.Drawing.Color.OrangeRed;
            this.bttAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttAgregar.Location = new System.Drawing.Point(167, 293);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(141, 39);
            this.bttAgregar.TabIndex = 11;
            this.bttAgregar.Text = "Agregar";
            this.bttAgregar.UseVisualStyleBackColor = false;
            // 
            // bttCancelar
            // 
            this.bttCancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.bttCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttCancelar.Location = new System.Drawing.Point(6, 293);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(145, 39);
            this.bttCancelar.TabIndex = 10;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = false;
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
            // txtboxGasto
            // 
            this.txtboxGasto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtboxGasto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxGasto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtboxGasto.Location = new System.Drawing.Point(6, 56);
            this.txtboxGasto.Name = "txtboxGasto";
            this.txtboxGasto.Size = new System.Drawing.Size(302, 16);
            this.txtboxGasto.TabIndex = 8;
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
            this.txtboxCantidad.Size = new System.Drawing.Size(302, 16);
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
            this.dtpFecha.Location = new System.Drawing.Point(6, 253);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(302, 23);
            this.dtpFecha.TabIndex = 2;
            // 
            // cbConcepto
            // 
            this.cbConcepto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbConcepto.FormattingEnabled = true;
            this.cbConcepto.Location = new System.Drawing.Point(6, 107);
            this.cbConcepto.Name = "cbConcepto";
            this.cbConcepto.Size = new System.Drawing.Size(266, 26);
            this.cbConcepto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 51);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mis Gastos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnMore);
            this.Controls.Add(this.dtgGastos);
            this.Controls.Add(this.gbIngresosGastos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgGastos)).EndInit();
            this.gbIngresosGastos.ResumeLayout(false);
            this.gbIngresosGastos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnMore;
        private System.Windows.Forms.DataGridView dtgGastos;
        private System.Windows.Forms.GroupBox gbIngresosGastos;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.Label lblGasto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtboxGasto;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.TextBox txtboxCantidad;
        private System.Windows.Forms.TextBox txtboxDescrip;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbConcepto;
        private System.Windows.Forms.Label label1;
    }
}