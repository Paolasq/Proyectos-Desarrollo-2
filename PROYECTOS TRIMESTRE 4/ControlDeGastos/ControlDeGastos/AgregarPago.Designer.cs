namespace ControlDeGastos
{
    partial class AgregarPago
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
            this.bttnClose = new System.Windows.Forms.Button();
            this.lblGestionDeGastos = new System.Windows.Forms.Label();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttNuevo = new System.Windows.Forms.Button();
            this.dgvMetodos = new System.Windows.Forms.DataGridView();
            this.gbAgregarMetodo = new System.Windows.Forms.GroupBox();
            this.chkIsEnabled = new System.Windows.Forms.CheckBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.txtboxMetodo = new System.Windows.Forms.TextBox();
            this.txtboxID = new System.Windows.Forms.TextBox();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.bttnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodos)).BeginInit();
            this.gbAgregarMetodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnClose
            // 
            this.bttnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnClose.FlatAppearance.BorderSize = 0;
            this.bttnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnClose.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttnClose.Location = new System.Drawing.Point(730, 0);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(41, 28);
            this.bttnClose.TabIndex = 33;
            this.bttnClose.Text = "x";
            this.bttnClose.UseVisualStyleBackColor = false;
            this.bttnClose.Click += new System.EventHandler(this.bttnClose_Click);
            // 
            // lblGestionDeGastos
            // 
            this.lblGestionDeGastos.AutoSize = true;
            this.lblGestionDeGastos.Font = new System.Drawing.Font("Montserrat Medium", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblGestionDeGastos.Location = new System.Drawing.Point(138, 20);
            this.lblGestionDeGastos.Name = "lblGestionDeGastos";
            this.lblGestionDeGastos.Size = new System.Drawing.Size(496, 51);
            this.lblGestionDeGastos.TabIndex = 32;
            this.lblGestionDeGastos.Text = "Agregar metodo de pago";
            this.lblGestionDeGastos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.BackColor = System.Drawing.Color.OrangeRed;
            this.bttnGuardar.Enabled = false;
            this.bttnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGuardar.Font = new System.Drawing.Font("Montserrat Medium", 9.999999F, System.Drawing.FontStyle.Bold);
            this.bttnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnGuardar.Location = new System.Drawing.Point(565, 401);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(188, 39);
            this.bttnGuardar.TabIndex = 31;
            this.bttnGuardar.Text = "Guardar";
            this.bttnGuardar.UseVisualStyleBackColor = false;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.bttnCancelar.Enabled = false;
            this.bttnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCancelar.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnCancelar.Location = new System.Drawing.Point(195, 401);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(179, 39);
            this.bttnCancelar.TabIndex = 30;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = false;
            // 
            // bttNuevo
            // 
            this.bttNuevo.BackColor = System.Drawing.Color.OrangeRed;
            this.bttNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttNuevo.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttNuevo.Location = new System.Drawing.Point(22, 401);
            this.bttNuevo.Name = "bttNuevo";
            this.bttNuevo.Size = new System.Drawing.Size(167, 39);
            this.bttNuevo.TabIndex = 29;
            this.bttNuevo.Text = "Nuevo";
            this.bttNuevo.UseVisualStyleBackColor = false;
            this.bttNuevo.Click += new System.EventHandler(this.bttNuevo_Click);
            // 
            // dgvMetodos
            // 
            this.dgvMetodos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMetodos.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvMetodos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMetodos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMetodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMetodos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMetodos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvMetodos.Location = new System.Drawing.Point(21, 190);
            this.dgvMetodos.Name = "dgvMetodos";
            this.dgvMetodos.Size = new System.Drawing.Size(731, 205);
            this.dgvMetodos.TabIndex = 28;
            this.dgvMetodos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMetodos_CellDoubleClick);
            // 
            // gbAgregarMetodo
            // 
            this.gbAgregarMetodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgregarMetodo.Controls.Add(this.chkIsEnabled);
            this.gbAgregarMetodo.Controls.Add(this.lblMetodo);
            this.gbAgregarMetodo.Controls.Add(this.txtboxMetodo);
            this.gbAgregarMetodo.Controls.Add(this.txtboxID);
            this.gbAgregarMetodo.Controls.Add(this.lblDescrip);
            this.gbAgregarMetodo.Enabled = false;
            this.gbAgregarMetodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbAgregarMetodo.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.gbAgregarMetodo.Location = new System.Drawing.Point(22, 83);
            this.gbAgregarMetodo.Name = "gbAgregarMetodo";
            this.gbAgregarMetodo.Size = new System.Drawing.Size(730, 101);
            this.gbAgregarMetodo.TabIndex = 27;
            this.gbAgregarMetodo.TabStop = false;
            this.gbAgregarMetodo.Text = "Agregar metodo de pago";
            // 
            // chkIsEnabled
            // 
            this.chkIsEnabled.AutoSize = true;
            this.chkIsEnabled.Location = new System.Drawing.Point(6, 69);
            this.chkIsEnabled.Name = "chkIsEnabled";
            this.chkIsEnabled.Size = new System.Drawing.Size(127, 20);
            this.chkIsEnabled.TabIndex = 15;
            this.chkIsEnabled.Text = "Visible al Público";
            this.chkIsEnabled.UseVisualStyleBackColor = true;
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(3, 21);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(61, 16);
            this.lblMetodo.TabIndex = 13;
            this.lblMetodo.Text = "Nombre ";
            // 
            // txtboxMetodo
            // 
            this.txtboxMetodo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtboxMetodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxMetodo.Location = new System.Drawing.Point(6, 40);
            this.txtboxMetodo.Name = "txtboxMetodo";
            this.txtboxMetodo.Size = new System.Drawing.Size(343, 15);
            this.txtboxMetodo.TabIndex = 10;
            // 
            // txtboxID
            // 
            this.txtboxID.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtboxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxID.Enabled = false;
            this.txtboxID.Location = new System.Drawing.Point(357, 40);
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.ReadOnly = true;
            this.txtboxID.Size = new System.Drawing.Size(368, 15);
            this.txtboxID.TabIndex = 12;
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(354, 18);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(21, 16);
            this.lblDescrip.TabIndex = 11;
            this.lblDescrip.Text = "ID";
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.bttnEliminar.Enabled = false;
            this.bttnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEliminar.Font = new System.Drawing.Font("Montserrat Medium", 9.999999F, System.Drawing.FontStyle.Bold);
            this.bttnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnEliminar.Location = new System.Drawing.Point(379, 401);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(179, 39);
            this.bttnEliminar.TabIndex = 34;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = false;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // AgregarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(771, 460);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.bttnClose);
            this.Controls.Add(this.lblGestionDeGastos);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttNuevo);
            this.Controls.Add(this.dgvMetodos);
            this.Controls.Add(this.gbAgregarMetodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarPago";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodos)).EndInit();
            this.gbAgregarMetodo.ResumeLayout(false);
            this.gbAgregarMetodo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnClose;
        private System.Windows.Forms.Label lblGestionDeGastos;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttNuevo;
        private System.Windows.Forms.DataGridView dgvMetodos;
        private System.Windows.Forms.GroupBox gbAgregarMetodo;
        private System.Windows.Forms.CheckBox chkIsEnabled;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.TextBox txtboxMetodo;
        private System.Windows.Forms.TextBox txtboxID;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Button bttnEliminar;
    }
}