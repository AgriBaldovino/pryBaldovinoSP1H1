namespace pryBaldovinoSP1H1
{
    partial class frmProduccion
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSeleccioneLocalidad = new System.Windows.Forms.Label();
            this.lblSeleccioneCultivo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdAceptar4 = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.lstLocalidad = new System.Windows.Forms.ComboBox();
            this.lstCultivo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 19);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // lblSeleccioneLocalidad
            // 
            this.lblSeleccioneLocalidad.AutoSize = true;
            this.lblSeleccioneLocalidad.Location = new System.Drawing.Point(12, 48);
            this.lblSeleccioneLocalidad.Name = "lblSeleccioneLocalidad";
            this.lblSeleccioneLocalidad.Size = new System.Drawing.Size(105, 13);
            this.lblSeleccioneLocalidad.TabIndex = 1;
            this.lblSeleccioneLocalidad.Text = "Seleccione localidad";
            // 
            // lblSeleccioneCultivo
            // 
            this.lblSeleccioneCultivo.AutoSize = true;
            this.lblSeleccioneCultivo.Location = new System.Drawing.Point(12, 77);
            this.lblSeleccioneCultivo.Name = "lblSeleccioneCultivo";
            this.lblSeleccioneCultivo.Size = new System.Drawing.Size(94, 13);
            this.lblSeleccioneCultivo.TabIndex = 2;
            this.lblSeleccioneCultivo.Text = "Seleccione cultivo";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 106);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(233, 16);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(75, 23);
            this.cmdBorrar.TabIndex = 8;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdAceptar4
            // 
            this.cmdAceptar4.Location = new System.Drawing.Point(233, 57);
            this.cmdAceptar4.Name = "cmdAceptar4";
            this.cmdAceptar4.Size = new System.Drawing.Size(75, 23);
            this.cmdAceptar4.TabIndex = 10;
            this.cmdAceptar4.Text = "Aceptar";
            this.cmdAceptar4.UseVisualStyleBackColor = true;
            this.cmdAceptar4.Click += new System.EventHandler(this.cmdCrear_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(67, 103);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(140, 20);
            this.txtCantidad.TabIndex = 11;
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(233, 100);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpiar.TabIndex = 12;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(55, 16);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(152, 20);
            this.txtFecha.TabIndex = 13;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // lstLocalidad
            // 
            this.lstLocalidad.FormattingEnabled = true;
            this.lstLocalidad.Location = new System.Drawing.Point(123, 45);
            this.lstLocalidad.Name = "lstLocalidad";
            this.lstLocalidad.Size = new System.Drawing.Size(84, 21);
            this.lstLocalidad.TabIndex = 14;
            this.lstLocalidad.SelectedIndexChanged += new System.EventHandler(this.lstLocalidad_SelectedIndexChanged);
            // 
            // lstCultivo
            // 
            this.lstCultivo.FormattingEnabled = true;
            this.lstCultivo.Location = new System.Drawing.Point(112, 73);
            this.lstCultivo.Name = "lstCultivo";
            this.lstCultivo.Size = new System.Drawing.Size(95, 21);
            this.lstCultivo.TabIndex = 15;
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 137);
            this.Controls.Add(this.lstCultivo);
            this.Controls.Add(this.lstLocalidad);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cmdAceptar4);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblSeleccioneCultivo);
            this.Controls.Add(this.lblSeleccioneLocalidad);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmProduccion";
            this.Text = "Produccion";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSeleccioneLocalidad;
        private System.Windows.Forms.Label lblSeleccioneCultivo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdAceptar4;
        private System.Windows.Forms.MaskedTextBox txtCantidad;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.ComboBox lstLocalidad;
        private System.Windows.Forms.ComboBox lstCultivo;
    }
}