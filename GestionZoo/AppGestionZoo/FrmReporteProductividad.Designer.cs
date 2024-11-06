namespace AppGestionZoo
{
    partial class FrmReporteProductividad
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
            this.gbvReporteProductividad = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gbvReporteProductividad)).BeginInit();
            this.SuspendLayout();
            // 
            // gbvReporteProductividad
            // 
            this.gbvReporteProductividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gbvReporteProductividad.Location = new System.Drawing.Point(12, 52);
            this.gbvReporteProductividad.Name = "gbvReporteProductividad";
            this.gbvReporteProductividad.Size = new System.Drawing.Size(776, 386);
            this.gbvReporteProductividad.TabIndex = 0;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(673, 12);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(115, 34);
            this.btnExportar.TabIndex = 1;
            this.btnExportar.Text = "Exportar Reporte";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // FrmReporteProductividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.gbvReporteProductividad);
            this.Name = "FrmReporteProductividad";
            this.Text = "FrmRegistroTareas";
            ((System.ComponentModel.ISupportInitialize)(this.gbvReporteProductividad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gbvReporteProductividad;
        private System.Windows.Forms.Button btnExportar;
    }
}