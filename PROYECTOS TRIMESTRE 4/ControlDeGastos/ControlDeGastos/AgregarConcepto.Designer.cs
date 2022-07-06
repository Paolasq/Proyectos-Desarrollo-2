namespace ControlDeGastos
{
    partial class AgregarConcepto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblGestionDeGastos = new System.Windows.Forms.Label();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttNuevo = new System.Windows.Forms.Button();
            this.dgvConceptos = new System.Windows.Forms.DataGridView();
            this.gbAgregarConceptos = new System.Windows.Forms.GroupBox();
            this.chkIsEnabled = new System.Windows.Forms.CheckBox();
            this.lblGasto = new System.Windows.Forms.Label();
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.txtboxID = new System.Windows.Forms.TextBox();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.bttnClose = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptos)).BeginInit();
            this.gbAgregarConceptos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGestionDeGastos
            // 
            this.lblGestionDeGastos.AutoSize = true;
            this.lblGestionDeGastos.Font = new System.Drawing.Font("Montserrat Medium", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblGestionDeGastos.Location = new System.Drawing.Point(184, 16);
            this.lblGestionDeGastos.Name = "lblGestionDeGastos";
            this.lblGestionDeGastos.Size = new System.Drawing.Size(384, 51);
            this.lblGestionDeGastos.TabIndex = 25;
            this.lblGestionDeGastos.Text = "Agregar Conceptos";
            this.lblGestionDeGastos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.BackColor = System.Drawing.Color.OrangeRed;
            this.bttnGuardar.Enabled = false;
            this.bttnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGuardar.Font = new System.Drawing.Font("Montserrat Medium", 9.999999F, System.Drawing.FontStyle.Bold);
            this.bttnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnGuardar.Location = new System.Drawing.Point(574, 403);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(173, 39);
            this.bttnGuardar.TabIndex = 24;
            this.bttnGuardar.Text = "Guardar";
            this.bttnGuardar.UseVisualStyleBackColor = false;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click_1);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.bttnCancelar.Enabled = false;
            this.bttnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCancelar.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnCancelar.Location = new System.Drawing.Point(204, 403);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(179, 39);
            this.bttnCancelar.TabIndex = 23;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = false;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // bttNuevo
            // 
            this.bttNuevo.BackColor = System.Drawing.Color.OrangeRed;
            this.bttNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttNuevo.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttNuevo.Location = new System.Drawing.Point(16, 403);
            this.bttNuevo.Name = "bttNuevo";
            this.bttNuevo.Size = new System.Drawing.Size(182, 39);
            this.bttNuevo.TabIndex = 22;
            this.bttNuevo.Text = "Nuevo";
            this.bttNuevo.UseVisualStyleBackColor = false;
            this.bttNuevo.Click += new System.EventHandler(this.bttNuevo_Click_1);
            // 
            // dgvConceptos
            // 
            this.dgvConceptos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConceptos.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvConceptos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConceptos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConceptos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConceptos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConceptos.Location = new System.Drawing.Point(16, 181);
            this.dgvConceptos.MultiSelect = false;
            this.dgvConceptos.Name = "dgvConceptos";
            this.dgvConceptos.ReadOnly = true;
            this.dgvConceptos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConceptos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvConceptos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConceptos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConceptos.Size = new System.Drawing.Size(731, 216);
            this.dgvConceptos.TabIndex = 21;
            this.dgvConceptos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConceptos_CellDoubleClick);
            // 
            // gbAgregarConceptos
            // 
            this.gbAgregarConceptos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgregarConceptos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbAgregarConceptos.Controls.Add(this.chkIsEnabled);
            this.gbAgregarConceptos.Controls.Add(this.lblGasto);
            this.gbAgregarConceptos.Controls.Add(this.txtboxNombre);
            this.gbAgregarConceptos.Controls.Add(this.txtboxID);
            this.gbAgregarConceptos.Controls.Add(this.lblDescrip);
            this.gbAgregarConceptos.Enabled = false;
            this.gbAgregarConceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAgregarConceptos.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.gbAgregarConceptos.Location = new System.Drawing.Point(17, 70);
            this.gbAgregarConceptos.Name = "gbAgregarConceptos";
            this.gbAgregarConceptos.Size = new System.Drawing.Size(728, 105);
            this.gbAgregarConceptos.TabIndex = 20;
            this.gbAgregarConceptos.TabStop = false;
            this.gbAgregarConceptos.Text = "Gestion de Conceptos";
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
            // lblGasto
            // 
            this.lblGasto.AutoSize = true;
            this.lblGasto.Location = new System.Drawing.Point(3, 21);
            this.lblGasto.Name = "lblGasto";
            this.lblGasto.Size = new System.Drawing.Size(61, 16);
            this.lblGasto.TabIndex = 13;
            this.lblGasto.Text = "Nombre ";
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtboxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxNombre.Location = new System.Drawing.Point(6, 40);
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.Size = new System.Drawing.Size(319, 15);
            this.txtboxNombre.TabIndex = 10;
            // 
            // txtboxID
            // 
            this.txtboxID.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtboxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxID.Enabled = false;
            this.txtboxID.Location = new System.Drawing.Point(331, 40);
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.ReadOnly = true;
            this.txtboxID.Size = new System.Drawing.Size(394, 15);
            this.txtboxID.TabIndex = 12;
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(328, 18);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(21, 16);
            this.lblDescrip.TabIndex = 11;
            this.lblDescrip.Text = "ID";
            // 
            // bttnClose
            // 
            this.bttnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnClose.FlatAppearance.BorderSize = 0;
            this.bttnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnClose.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttnClose.Location = new System.Drawing.Point(730, -1);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(41, 28);
            this.bttnClose.TabIndex = 26;
            this.bttnClose.Text = "x";
            this.bttnClose.UseVisualStyleBackColor = false;
            this.bttnClose.Click += new System.EventHandler(this.bttnClose_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.bttnEliminar.Enabled = false;
            this.bttnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEliminar.Font = new System.Drawing.Font("Montserrat Medium", 9.999999F, System.Drawing.FontStyle.Bold);
            this.bttnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnEliminar.Location = new System.Drawing.Point(389, 403);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(179, 39);
            this.bttnEliminar.TabIndex = 28;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = false;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // AgregarConcepto
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(771, 453);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.bttnClose);
            this.Controls.Add(this.lblGestionDeGastos);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttNuevo);
            this.Controls.Add(this.dgvConceptos);
            this.Controls.Add(this.gbAgregarConceptos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarConcepto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarConcepto";
            this.TransparencyKey = System.Drawing.Color.Lavender;
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptos)).EndInit();
            this.gbAgregarConceptos.ResumeLayout(false);
            this.gbAgregarConceptos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionDeGastos;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttNuevo;
        private System.Windows.Forms.DataGridView dgvConceptos;
        private System.Windows.Forms.GroupBox gbAgregarConceptos;
        private System.Windows.Forms.CheckBox chkIsEnabled;
        private System.Windows.Forms.Label lblGasto;
        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.TextBox txtboxID;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Button bttnClose;
        private System.Windows.Forms.Button bttnEliminar;
    }
}