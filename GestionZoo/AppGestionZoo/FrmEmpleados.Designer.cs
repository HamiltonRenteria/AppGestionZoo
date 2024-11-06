namespace AppGestionZoo
{
    partial class FrmEmpleados
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
            this.gbxEmpleado = new System.Windows.Forms.GroupBox();
            this.cboSector = new System.Windows.Forms.ComboBox();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.txtNumeroSeguroMedico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeroEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.gboReportes = new System.Windows.Forms.GroupBox();
            this.btnReporteProductividad = new System.Windows.Forms.Button();
            this.gboTareas = new System.Windows.Forms.GroupBox();
            this.btnLimpiarBebederoAves = new System.Windows.Forms.Button();
            this.btnLimpiarPasilloVisitantes = new System.Windows.Forms.Button();
            this.btnAlimentarFelinos = new System.Windows.Forms.Button();
            this.btnLimpiarJaula = new System.Windows.Forms.Button();
            this.btnLiberarFelinos = new System.Windows.Forms.Button();
            this.btnEnjaularFelinos = new System.Windows.Forms.Button();
            this.btnAlimentarPeces = new System.Windows.Forms.Button();
            this.btnLimpiarEstanque = new System.Windows.Forms.Button();
            this.gbxEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.gboReportes.SuspendLayout();
            this.gboTareas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxEmpleado
            // 
            this.gbxEmpleado.Controls.Add(this.cboSector);
            this.gbxEmpleado.Controls.Add(this.btnAgregarEmpleado);
            this.gbxEmpleado.Controls.Add(this.txtNumeroSeguroMedico);
            this.gbxEmpleado.Controls.Add(this.label5);
            this.gbxEmpleado.Controls.Add(this.label6);
            this.gbxEmpleado.Controls.Add(this.txtNumeroEmpleado);
            this.gbxEmpleado.Controls.Add(this.label3);
            this.gbxEmpleado.Controls.Add(this.txtApellidos);
            this.gbxEmpleado.Controls.Add(this.label2);
            this.gbxEmpleado.Controls.Add(this.txtNombres);
            this.gbxEmpleado.Controls.Add(this.label1);
            this.gbxEmpleado.Location = new System.Drawing.Point(12, 12);
            this.gbxEmpleado.Name = "gbxEmpleado";
            this.gbxEmpleado.Size = new System.Drawing.Size(305, 198);
            this.gbxEmpleado.TabIndex = 0;
            this.gbxEmpleado.TabStop = false;
            this.gbxEmpleado.Text = "Datos Empleado";
            // 
            // cboSector
            // 
            this.cboSector.FormattingEnabled = true;
            this.cboSector.Location = new System.Drawing.Point(146, 114);
            this.cboSector.Name = "cboSector";
            this.cboSector.Size = new System.Drawing.Size(147, 21);
            this.cboSector.TabIndex = 1;
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(146, 167);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(147, 23);
            this.btnAgregarEmpleado.TabIndex = 10;
            this.btnAgregarEmpleado.Text = "Agregar Empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // txtNumeroSeguroMedico
            // 
            this.txtNumeroSeguroMedico.Location = new System.Drawing.Point(146, 141);
            this.txtNumeroSeguroMedico.Name = "txtNumeroSeguroMedico";
            this.txtNumeroSeguroMedico.Size = new System.Drawing.Size(147, 20);
            this.txtNumeroSeguroMedico.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "N° Seguro Medico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sector";
            // 
            // txtNumeroEmpleado
            // 
            this.txtNumeroEmpleado.Location = new System.Drawing.Point(146, 88);
            this.txtNumeroEmpleado.Name = "txtNumeroEmpleado";
            this.txtNumeroEmpleado.Size = new System.Drawing.Size(147, 20);
            this.txtNumeroEmpleado.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "N° Empleado";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(146, 62);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(147, 20);
            this.txtApellidos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(146, 36);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(147, 20);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(323, 12);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(465, 198);
            this.dgvEmpleados.TabIndex = 1;
            // 
            // gboReportes
            // 
            this.gboReportes.Controls.Add(this.btnReporteProductividad);
            this.gboReportes.Location = new System.Drawing.Point(12, 216);
            this.gboReportes.Name = "gboReportes";
            this.gboReportes.Size = new System.Drawing.Size(305, 198);
            this.gboReportes.TabIndex = 11;
            this.gboReportes.TabStop = false;
            this.gboReportes.Text = "Reportes";
            // 
            // btnReporteProductividad
            // 
            this.btnReporteProductividad.Location = new System.Drawing.Point(10, 19);
            this.btnReporteProductividad.Name = "btnReporteProductividad";
            this.btnReporteProductividad.Size = new System.Drawing.Size(283, 63);
            this.btnReporteProductividad.TabIndex = 10;
            this.btnReporteProductividad.Text = "Reporte Productividad";
            this.btnReporteProductividad.UseVisualStyleBackColor = true;
            this.btnReporteProductividad.Click += new System.EventHandler(this.btnReporteProductividad_Click);
            // 
            // gboTareas
            // 
            this.gboTareas.Controls.Add(this.btnLimpiarBebederoAves);
            this.gboTareas.Controls.Add(this.btnLimpiarPasilloVisitantes);
            this.gboTareas.Controls.Add(this.btnAlimentarFelinos);
            this.gboTareas.Controls.Add(this.btnLimpiarJaula);
            this.gboTareas.Controls.Add(this.btnLiberarFelinos);
            this.gboTareas.Controls.Add(this.btnEnjaularFelinos);
            this.gboTareas.Controls.Add(this.btnAlimentarPeces);
            this.gboTareas.Controls.Add(this.btnLimpiarEstanque);
            this.gboTareas.Location = new System.Drawing.Point(323, 216);
            this.gboTareas.Name = "gboTareas";
            this.gboTareas.Size = new System.Drawing.Size(465, 198);
            this.gboTareas.TabIndex = 12;
            this.gboTareas.TabStop = false;
            this.gboTareas.Text = "Tareas";
            // 
            // btnLimpiarBebederoAves
            // 
            this.btnLimpiarBebederoAves.Location = new System.Drawing.Point(243, 107);
            this.btnLimpiarBebederoAves.Name = "btnLimpiarBebederoAves";
            this.btnLimpiarBebederoAves.Size = new System.Drawing.Size(216, 30);
            this.btnLimpiarBebederoAves.TabIndex = 17;
            this.btnLimpiarBebederoAves.Text = "Limpiar Bebedero Aves";
            this.btnLimpiarBebederoAves.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarPasilloVisitantes
            // 
            this.btnLimpiarPasilloVisitantes.Location = new System.Drawing.Point(243, 153);
            this.btnLimpiarPasilloVisitantes.Name = "btnLimpiarPasilloVisitantes";
            this.btnLimpiarPasilloVisitantes.Size = new System.Drawing.Size(216, 30);
            this.btnLimpiarPasilloVisitantes.TabIndex = 16;
            this.btnLimpiarPasilloVisitantes.Text = "Limpiar Pasillo Visitantes";
            this.btnLimpiarPasilloVisitantes.UseVisualStyleBackColor = true;
            // 
            // btnAlimentarFelinos
            // 
            this.btnAlimentarFelinos.Location = new System.Drawing.Point(6, 153);
            this.btnAlimentarFelinos.Name = "btnAlimentarFelinos";
            this.btnAlimentarFelinos.Size = new System.Drawing.Size(216, 30);
            this.btnAlimentarFelinos.TabIndex = 15;
            this.btnAlimentarFelinos.Text = "Alimentar Felinos";
            this.btnAlimentarFelinos.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarJaula
            // 
            this.btnLimpiarJaula.Location = new System.Drawing.Point(6, 107);
            this.btnLimpiarJaula.Name = "btnLimpiarJaula";
            this.btnLimpiarJaula.Size = new System.Drawing.Size(216, 30);
            this.btnLimpiarJaula.TabIndex = 14;
            this.btnLimpiarJaula.Text = "Limpiar Jaula Felinos";
            this.btnLimpiarJaula.UseVisualStyleBackColor = true;
            // 
            // btnLiberarFelinos
            // 
            this.btnLiberarFelinos.Location = new System.Drawing.Point(243, 19);
            this.btnLiberarFelinos.Name = "btnLiberarFelinos";
            this.btnLiberarFelinos.Size = new System.Drawing.Size(216, 30);
            this.btnLiberarFelinos.TabIndex = 13;
            this.btnLiberarFelinos.Text = "Liberar Felinos";
            this.btnLiberarFelinos.UseVisualStyleBackColor = true;
            // 
            // btnEnjaularFelinos
            // 
            this.btnEnjaularFelinos.Location = new System.Drawing.Point(243, 65);
            this.btnEnjaularFelinos.Name = "btnEnjaularFelinos";
            this.btnEnjaularFelinos.Size = new System.Drawing.Size(216, 30);
            this.btnEnjaularFelinos.TabIndex = 12;
            this.btnEnjaularFelinos.Text = "Enjaular Felinos";
            this.btnEnjaularFelinos.UseVisualStyleBackColor = true;
            // 
            // btnAlimentarPeces
            // 
            this.btnAlimentarPeces.Location = new System.Drawing.Point(6, 65);
            this.btnAlimentarPeces.Name = "btnAlimentarPeces";
            this.btnAlimentarPeces.Size = new System.Drawing.Size(216, 30);
            this.btnAlimentarPeces.TabIndex = 11;
            this.btnAlimentarPeces.Text = "Alimentar Peces Estanque";
            this.btnAlimentarPeces.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarEstanque
            // 
            this.btnLimpiarEstanque.Location = new System.Drawing.Point(6, 19);
            this.btnLimpiarEstanque.Name = "btnLimpiarEstanque";
            this.btnLimpiarEstanque.Size = new System.Drawing.Size(216, 30);
            this.btnLimpiarEstanque.TabIndex = 10;
            this.btnLimpiarEstanque.Text = "Limpiar Estanque";
            this.btnLimpiarEstanque.UseVisualStyleBackColor = true;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.gboTareas);
            this.Controls.Add(this.gboReportes);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.gbxEmpleado);
            this.Name = "FrmEmpleados";
            this.Text = "Form1";
            this.gbxEmpleado.ResumeLayout(false);
            this.gbxEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.gboReportes.ResumeLayout(false);
            this.gboTareas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEmpleado;
        private System.Windows.Forms.TextBox txtNumeroSeguroMedico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumeroEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.ComboBox cboSector;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.GroupBox gboReportes;
        private System.Windows.Forms.Button btnReporteProductividad;
        private System.Windows.Forms.GroupBox gboTareas;
        private System.Windows.Forms.Button btnLimpiarEstanque;
        private System.Windows.Forms.Button btnLimpiarBebederoAves;
        private System.Windows.Forms.Button btnLimpiarPasilloVisitantes;
        private System.Windows.Forms.Button btnAlimentarFelinos;
        private System.Windows.Forms.Button btnLimpiarJaula;
        private System.Windows.Forms.Button btnLiberarFelinos;
        private System.Windows.Forms.Button btnEnjaularFelinos;
        private System.Windows.Forms.Button btnAlimentarPeces;
    }
}

