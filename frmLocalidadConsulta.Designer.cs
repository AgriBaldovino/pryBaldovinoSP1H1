namespace pryBaldovinoSP1H1
{
    partial class frmLocalidadConsulta
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
            this.dgvConsultaLocalidad = new System.Windows.Forms.DataGridView();
            this.cmdListar3 = new System.Windows.Forms.Button();
            this.cmdSalir3 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLocalidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaLocalidad
            // 
            this.dgvConsultaLocalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaLocalidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvConsultaLocalidad.Location = new System.Drawing.Point(12, 12);
            this.dgvConsultaLocalidad.Name = "dgvConsultaLocalidad";
            this.dgvConsultaLocalidad.Size = new System.Drawing.Size(240, 150);
            this.dgvConsultaLocalidad.TabIndex = 0;
            // 
            // cmdListar3
            // 
            this.cmdListar3.Location = new System.Drawing.Point(81, 168);
            this.cmdListar3.Name = "cmdListar3";
            this.cmdListar3.Size = new System.Drawing.Size(75, 23);
            this.cmdListar3.TabIndex = 5;
            this.cmdListar3.Text = "Listar";
            this.cmdListar3.UseVisualStyleBackColor = true;
            this.cmdListar3.Click += new System.EventHandler(this.cmdListar3_Click);
            // 
            // cmdSalir3
            // 
            this.cmdSalir3.Location = new System.Drawing.Point(177, 168);
            this.cmdSalir3.Name = "cmdSalir3";
            this.cmdSalir3.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir3.TabIndex = 4;
            this.cmdSalir3.Text = "Salir";
            this.cmdSalir3.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Identificador";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Localidad";
            this.Column2.Name = "Column2";
            // 
            // frmLocalidadConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 199);
            this.Controls.Add(this.cmdListar3);
            this.Controls.Add(this.cmdSalir3);
            this.Controls.Add(this.dgvConsultaLocalidad);
            this.Name = "frmLocalidadConsulta";
            this.Text = "Consulta localidad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLocalidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaLocalidad;
        private System.Windows.Forms.Button cmdListar3;
        private System.Windows.Forms.Button cmdSalir3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}