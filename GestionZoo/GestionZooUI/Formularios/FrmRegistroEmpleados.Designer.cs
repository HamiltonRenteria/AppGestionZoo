namespace GestionZooUI.Formularios
{
    partial class FrmRegistroEmpleados
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
            this.gboEmpleado = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblSegMedico = new System.Windows.Forms.Label();
            this.txtNumeroSeguro = new System.Windows.Forms.TextBox();
            this.cboSector = new System.Windows.Forms.ComboBox();
            this.txtNumeroEmpleado = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.gboTareas = new System.Windows.Forms.GroupBox();
            this.btnLimpiarPasillo = new System.Windows.Forms.Button();
            this.btnAlimentarFelinos = new System.Windows.Forms.Button();
            this.btnLimpiarBebederos = new System.Windows.Forms.Button();
            this.btnLimpiarJaula = new System.Windows.Forms.Button();
            this.btnEnjaularFelinos = new System.Windows.Forms.Button();
            this.btnAlimentarPeces = new System.Windows.Forms.Button();
            this.btnLiberarFelinos = new System.Windows.Forms.Button();
            this.btnLimpiarEstanque = new System.Windows.Forms.Button();
            this.dboReportes = new System.Windows.Forms.GroupBox();
            this.btnReportes = new System.Windows.Forms.Button();
            this.gboEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.gboTareas.SuspendLayout();
            this.dboReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboEmpleado
            // 
            this.gboEmpleado.Controls.Add(this.label3);
            this.gboEmpleado.Controls.Add(this.label2);
            this.gboEmpleado.Controls.Add(this.label1);
            this.gboEmpleado.Controls.Add(this.btnAgregar);
            this.gboEmpleado.Controls.Add(this.lblSegMedico);
            this.gboEmpleado.Controls.Add(this.txtNumeroSeguro);
            this.gboEmpleado.Controls.Add(this.cboSector);
            this.gboEmpleado.Controls.Add(this.txtNumeroEmpleado);
            this.gboEmpleado.Controls.Add(this.txtApellido);
            this.gboEmpleado.Controls.Add(this.txtNombre);
            this.gboEmpleado.Controls.Add(this.lblNombre);
            this.gboEmpleado.Location = new System.Drawing.Point(12, 12);
            this.gboEmpleado.Name = "gboEmpleado";
            this.gboEmpleado.Size = new System.Drawing.Size(318, 182);
            this.gboEmpleado.TabIndex = 0;
            this.gboEmpleado.TabStop = false;
            this.gboEmpleado.Text = "Datos Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "N° Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Apellido";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(137, 150);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar Empleado";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblSegMedico
            // 
            this.lblSegMedico.AutoSize = true;
            this.lblSegMedico.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegMedico.Location = new System.Drawing.Point(6, 123);
            this.lblSegMedico.Name = "lblSegMedico";
            this.lblSegMedico.Size = new System.Drawing.Size(125, 19);
            this.lblSegMedico.TabIndex = 6;
            this.lblSegMedico.Text = "N° Seguro Medico";
            // 
            // txtNumeroSeguro
            // 
            this.txtNumeroSeguro.Location = new System.Drawing.Point(137, 124);
            this.txtNumeroSeguro.Name = "txtNumeroSeguro";
            this.txtNumeroSeguro.Size = new System.Drawing.Size(160, 20);
            this.txtNumeroSeguro.TabIndex = 5;
            // 
            // cboSector
            // 
            this.cboSector.FormattingEnabled = true;
            this.cboSector.Location = new System.Drawing.Point(137, 97);
            this.cboSector.Name = "cboSector";
            this.cboSector.Size = new System.Drawing.Size(160, 21);
            this.cboSector.TabIndex = 4;
            // 
            // txtNumeroEmpleado
            // 
            this.txtNumeroEmpleado.Location = new System.Drawing.Point(137, 71);
            this.txtNumeroEmpleado.Name = "txtNumeroEmpleado";
            this.txtNumeroEmpleado.Size = new System.Drawing.Size(160, 20);
            this.txtNumeroEmpleado.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(137, 47);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(160, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(71, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(337, 12);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(543, 182);
            this.dgvEmpleados.TabIndex = 1;
            this.dgvEmpleados.SelectionChanged += new System.EventHandler(this.dgvEmpleados_SelectionChanged);
            // 
            // gboTareas
            // 
            this.gboTareas.Controls.Add(this.btnLimpiarPasillo);
            this.gboTareas.Controls.Add(this.btnAlimentarFelinos);
            this.gboTareas.Controls.Add(this.btnLimpiarBebederos);
            this.gboTareas.Controls.Add(this.btnLimpiarJaula);
            this.gboTareas.Controls.Add(this.btnEnjaularFelinos);
            this.gboTareas.Controls.Add(this.btnAlimentarPeces);
            this.gboTareas.Controls.Add(this.btnLiberarFelinos);
            this.gboTareas.Controls.Add(this.btnLimpiarEstanque);
            this.gboTareas.Location = new System.Drawing.Point(336, 200);
            this.gboTareas.Name = "gboTareas";
            this.gboTareas.Size = new System.Drawing.Size(543, 142);
            this.gboTareas.TabIndex = 2;
            this.gboTareas.TabStop = false;
            this.gboTareas.Text = "Tareas";
            // 
            // btnLimpiarPasillo
            // 
            this.btnLimpiarPasillo.Location = new System.Drawing.Point(277, 106);
            this.btnLimpiarPasillo.Name = "btnLimpiarPasillo";
            this.btnLimpiarPasillo.Size = new System.Drawing.Size(260, 23);
            this.btnLimpiarPasillo.TabIndex = 18;
            this.btnLimpiarPasillo.Text = "Limpiar Pasillo Visitantes";
            this.btnLimpiarPasillo.UseVisualStyleBackColor = true;
            this.btnLimpiarPasillo.Click += new System.EventHandler(this.btnLimpiarPasillo_Click);
            // 
            // btnAlimentarFelinos
            // 
            this.btnAlimentarFelinos.Location = new System.Drawing.Point(6, 106);
            this.btnAlimentarFelinos.Name = "btnAlimentarFelinos";
            this.btnAlimentarFelinos.Size = new System.Drawing.Size(260, 23);
            this.btnAlimentarFelinos.TabIndex = 17;
            this.btnAlimentarFelinos.Text = "Alimentar Felinos";
            this.btnAlimentarFelinos.UseVisualStyleBackColor = true;
            this.btnAlimentarFelinos.Click += new System.EventHandler(this.btnAlimentarFelinos_Click);
            // 
            // btnLimpiarBebederos
            // 
            this.btnLimpiarBebederos.Location = new System.Drawing.Point(277, 77);
            this.btnLimpiarBebederos.Name = "btnLimpiarBebederos";
            this.btnLimpiarBebederos.Size = new System.Drawing.Size(260, 23);
            this.btnLimpiarBebederos.TabIndex = 16;
            this.btnLimpiarBebederos.Text = "Limpiar Bebedero Aves";
            this.btnLimpiarBebederos.UseVisualStyleBackColor = true;
            this.btnLimpiarBebederos.Click += new System.EventHandler(this.btnLimpiarBebederos_Click);
            // 
            // btnLimpiarJaula
            // 
            this.btnLimpiarJaula.Location = new System.Drawing.Point(6, 77);
            this.btnLimpiarJaula.Name = "btnLimpiarJaula";
            this.btnLimpiarJaula.Size = new System.Drawing.Size(260, 23);
            this.btnLimpiarJaula.TabIndex = 15;
            this.btnLimpiarJaula.Text = "Limpiar Jaula Felinos";
            this.btnLimpiarJaula.UseVisualStyleBackColor = true;
            this.btnLimpiarJaula.Click += new System.EventHandler(this.btnLimpiarJaula_Click);
            // 
            // btnEnjaularFelinos
            // 
            this.btnEnjaularFelinos.Location = new System.Drawing.Point(277, 48);
            this.btnEnjaularFelinos.Name = "btnEnjaularFelinos";
            this.btnEnjaularFelinos.Size = new System.Drawing.Size(260, 23);
            this.btnEnjaularFelinos.TabIndex = 14;
            this.btnEnjaularFelinos.Text = "Enjaular Felinos";
            this.btnEnjaularFelinos.UseVisualStyleBackColor = true;
            this.btnEnjaularFelinos.Click += new System.EventHandler(this.btnEnjaularFelinos_Click);
            // 
            // btnAlimentarPeces
            // 
            this.btnAlimentarPeces.Location = new System.Drawing.Point(6, 48);
            this.btnAlimentarPeces.Name = "btnAlimentarPeces";
            this.btnAlimentarPeces.Size = new System.Drawing.Size(260, 23);
            this.btnAlimentarPeces.TabIndex = 13;
            this.btnAlimentarPeces.Text = "Alimentar Peces Estanque";
            this.btnAlimentarPeces.UseVisualStyleBackColor = true;
            this.btnAlimentarPeces.Click += new System.EventHandler(this.btnAlimentarPeces_Click);
            // 
            // btnLiberarFelinos
            // 
            this.btnLiberarFelinos.Location = new System.Drawing.Point(277, 19);
            this.btnLiberarFelinos.Name = "btnLiberarFelinos";
            this.btnLiberarFelinos.Size = new System.Drawing.Size(260, 23);
            this.btnLiberarFelinos.TabIndex = 12;
            this.btnLiberarFelinos.Text = "Liberar Felinos";
            this.btnLiberarFelinos.UseVisualStyleBackColor = true;
            this.btnLiberarFelinos.Click += new System.EventHandler(this.btnLiberarFelinos_Click);
            // 
            // btnLimpiarEstanque
            // 
            this.btnLimpiarEstanque.Location = new System.Drawing.Point(6, 19);
            this.btnLimpiarEstanque.Name = "btnLimpiarEstanque";
            this.btnLimpiarEstanque.Size = new System.Drawing.Size(260, 23);
            this.btnLimpiarEstanque.TabIndex = 11;
            this.btnLimpiarEstanque.Text = "Limpiar Estanque";
            this.btnLimpiarEstanque.UseVisualStyleBackColor = true;
            this.btnLimpiarEstanque.Click += new System.EventHandler(this.btnLimpiarEstanque_Click);
            // 
            // dboReportes
            // 
            this.dboReportes.Controls.Add(this.btnReportes);
            this.dboReportes.Location = new System.Drawing.Point(12, 200);
            this.dboReportes.Name = "dboReportes";
            this.dboReportes.Size = new System.Drawing.Size(318, 142);
            this.dboReportes.TabIndex = 3;
            this.dboReportes.TabStop = false;
            this.dboReportes.Text = "Reportes";
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(62, 63);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(160, 23);
            this.btnReportes.TabIndex = 11;
            this.btnReportes.Text = "Reporte Productividad";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // FrmRegistroEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 354);
            this.Controls.Add(this.dboReportes);
            this.Controls.Add(this.gboTareas);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.gboEmpleado);
            this.Name = "FrmRegistroEmpleados";
            this.Text = "Zoologico";
            this.Load += new System.EventHandler(this.FrmRegistroEmpleados_Load);
            this.gboEmpleado.ResumeLayout(false);
            this.gboEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.gboTareas.ResumeLayout(false);
            this.dboReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboEmpleado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblSegMedico;
        private System.Windows.Forms.TextBox txtNumeroSeguro;
        private System.Windows.Forms.ComboBox cboSector;
        private System.Windows.Forms.TextBox txtNumeroEmpleado;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox gboTareas;
        private System.Windows.Forms.Button btnLimpiarPasillo;
        private System.Windows.Forms.Button btnAlimentarFelinos;
        private System.Windows.Forms.Button btnLimpiarBebederos;
        private System.Windows.Forms.Button btnLimpiarJaula;
        private System.Windows.Forms.Button btnEnjaularFelinos;
        private System.Windows.Forms.Button btnAlimentarPeces;
        private System.Windows.Forms.Button btnLiberarFelinos;
        private System.Windows.Forms.Button btnLimpiarEstanque;
        private System.Windows.Forms.GroupBox dboReportes;
        private System.Windows.Forms.Button btnReportes;
    }
}