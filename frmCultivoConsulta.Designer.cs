namespace pryBaldovinoSP1H1
{
    partial class frmCultivoConsulta
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
            this.dgvConsultaCultivos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdListar2 = new System.Windows.Forms.Button();
            this.cmdSalir2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCultivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaCultivos
            // 
            this.dgvConsultaCultivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCultivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvConsultaCultivos.Location = new System.Drawing.Point(12, 12);
            this.dgvConsultaCultivos.Name = "dgvConsultaCultivos";
            this.dgvConsultaCultivos.Size = new System.Drawing.Size(240, 150);
            this.dgvConsultaCultivos.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cultivo";
            this.Column2.Name = "Column2";
            // 
            // cmdListar2
            // 
            this.cmdListar2.Location = new System.Drawing.Point(81, 168);
            this.cmdListar2.Name = "cmdListar2";
            this.cmdListar2.Size = new System.Drawing.Size(75, 23);
            this.cmdListar2.TabIndex = 5;
            this.cmdListar2.Text = "Listar";
            this.cmdListar2.UseVisualStyleBackColor = true;
            this.cmdListar2.Click += new System.EventHandler(this.cmdListar2_Click);
            // 
            // cmdSalir2
            // 
            this.cmdSalir2.Location = new System.Drawing.Point(177, 168);
            this.cmdSalir2.Name = "cmdSalir2";
            this.cmdSalir2.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir2.TabIndex = 4;
            this.cmdSalir2.Text = "Salir";
            this.cmdSalir2.UseVisualStyleBackColor = true;
            this.cmdSalir2.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmCultivoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 198);
            this.Controls.Add(this.cmdListar2);
            this.Controls.Add(this.cmdSalir2);
            this.Controls.Add(this.dgvConsultaCultivos);
            this.Name = "frmCultivoConsulta";
            this.Text = "Consulta de cultivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCultivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaCultivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button cmdListar2;
        private System.Windows.Forms.Button cmdSalir2;
    }
}