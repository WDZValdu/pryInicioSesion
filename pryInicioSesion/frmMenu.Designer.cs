﻿namespace pryInicioSesion
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cargarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarUsuariosToolStripMenuItem,
            this.verReportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cargarUsuariosToolStripMenuItem
            // 
            this.cargarUsuariosToolStripMenuItem.Name = "cargarUsuariosToolStripMenuItem";
            this.cargarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.cargarUsuariosToolStripMenuItem.Text = "Cargar Usuarios";
            this.cargarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.cargarUsuariosToolStripMenuItem_Click);
            // 
            // verReportesToolStripMenuItem
            // 
            this.verReportesToolStripMenuItem.Name = "verReportesToolStripMenuItem";
            this.verReportesToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.verReportesToolStripMenuItem.Text = "Ver Reportes";
            this.verReportesToolStripMenuItem.Click += new System.EventHandler(this.verReportesToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cargarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verReportesToolStripMenuItem;
    }
}