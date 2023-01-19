
namespace ProyectoDintNuno
{
    partial class VistaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpConjunto = new System.Windows.Forms.FlowLayoutPanel();
            this.flpElemento = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.flpConjunto.SuspendLayout();
            this.flpElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.vistaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // vistaToolStripMenuItem
            // 
            this.vistaToolStripMenuItem.Name = "vistaToolStripMenuItem";
            this.vistaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.vistaToolStripMenuItem.Text = "Vista";
            // 
            // flpConjunto
            // 
            this.flpConjunto.Controls.Add(this.flpElemento);
            this.flpConjunto.Location = new System.Drawing.Point(0, 24);
            this.flpConjunto.Name = "flpConjunto";
            this.flpConjunto.Size = new System.Drawing.Size(800, 375);
            this.flpConjunto.TabIndex = 2;
            // 
            // flpElemento
            // 
            this.flpElemento.Controls.Add(this.pictureBox1);
            this.flpElemento.Controls.Add(this.textBox1);
            this.flpElemento.Location = new System.Drawing.Point(3, 3);
            this.flpElemento.Name = "flpElemento";
            this.flpElemento.Size = new System.Drawing.Size(113, 133);
            this.flpElemento.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 95);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 23);
            this.textBox1.TabIndex = 1;
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAnadir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAnadir.FlatAppearance.BorderSize = 0;
            this.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadir.Location = new System.Drawing.Point(713, 405);
            this.btnAnadir.Margin = new System.Windows.Forms.Padding(0);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 42);
            this.btnAnadir.TabIndex = 3;
            this.btnAnadir.Text = "Nuevo";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.flpConjunto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VistaPrincipal";
            this.Text = "Gestor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flpConjunto.ResumeLayout(false);
            this.flpElemento.ResumeLayout(false);
            this.flpElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistaToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpConjunto;
        private System.Windows.Forms.FlowLayoutPanel flpElemento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAnadir;
    }
}

