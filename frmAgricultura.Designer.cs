namespace pryBaldovinoSP1H1
{
    partial class frmAgricultura
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgricultura));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cultivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.localidadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cultivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localidadesToolStripMenuItem,
            this.cultivosToolStripMenuItem,
            this.produccionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // localidadesToolStripMenuItem
            // 
            this.localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            this.localidadesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.localidadesToolStripMenuItem.Text = "Localidades";
            this.localidadesToolStripMenuItem.Click += new System.EventHandler(this.localidadesToolStripMenuItem_Click);
            // 
            // cultivosToolStripMenuItem
            // 
            this.cultivosToolStripMenuItem.Name = "cultivosToolStripMenuItem";
            this.cultivosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cultivosToolStripMenuItem.Text = "Cultivos";
            this.cultivosToolStripMenuItem.Click += new System.EventHandler(this.cultivosToolStripMenuItem_Click);
            // 
            // produccionToolStripMenuItem
            // 
            this.produccionToolStripMenuItem.Name = "produccionToolStripMenuItem";
            this.produccionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produccionToolStripMenuItem.Text = "Produccion";
            this.produccionToolStripMenuItem.Click += new System.EventHandler(this.produccionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localidadesToolStripMenuItem1,
            this.cultivoToolStripMenuItem,
            this.producciónToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // localidadesToolStripMenuItem1
            // 
            this.localidadesToolStripMenuItem1.Name = "localidadesToolStripMenuItem1";
            this.localidadesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.localidadesToolStripMenuItem1.Text = "Localidades";
            this.localidadesToolStripMenuItem1.Click += new System.EventHandler(this.localidadesToolStripMenuItem1_Click);
            // 
            // cultivoToolStripMenuItem
            // 
            this.cultivoToolStripMenuItem.Name = "cultivoToolStripMenuItem";
            this.cultivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cultivoToolStripMenuItem.Text = "Cultivos";
            this.cultivoToolStripMenuItem.Click += new System.EventHandler(this.cultivoToolStripMenuItem_Click);
            // 
            // producciónToolStripMenuItem
            // 
            this.producciónToolStripMenuItem.Name = "producciónToolStripMenuItem";
            this.producciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.producciónToolStripMenuItem.Text = "Producción";
            this.producciónToolStripMenuItem.Click += new System.EventHandler(this.producciónToolStripMenuItem_Click);
            // 
            // frmAgricultura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 28);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAgricultura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agricultura";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cultivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cultivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producciónToolStripMenuItem;
    }
}

