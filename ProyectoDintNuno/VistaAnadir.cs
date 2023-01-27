using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoDintNuno
{
    public partial class VistaAnadir : Form
    {
        public string Name;
        public string PArtist;
        public string SArtist;
        public string Genre;
        public string Format;
        public string Type;
        public DateTime AdDate;
        public DateTime EdDate;
        public string Description;
        public Image Image;

        public VistaAnadir()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Name = tbName.Text;
            PArtist = tbArtist.Text;
            SArtist = tbSecArtist.Text;
            Genre = tbGenre.Text;
            Format = cbFormat.Text;
            Type = cbType.Text;
            AdDate = dtpAdquisition.Value;
            EdDate = dtpEdition.Value;
            Description = tbDescription.Text;
            Image = pbImage.Image;
            bool valido;
            if (String.IsNullOrEmpty(Name) || String.IsNullOrEmpty(PArtist))
            {
                valido = false;
            }
            else
            {
                valido = true;
            }
            if (String.IsNullOrEmpty(Name))
            {
                tbName.BackColor = Color.Red;
            }
            else
            {
                tbName.BackColor = Color.White;
            }
            if (String.IsNullOrEmpty(PArtist))
            {
                tbArtist.BackColor = Color.Red;
            }
            else
            {
                tbArtist.BackColor = Color.White;
            }
            
            if (valido)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if(of.ShowDialog() == DialogResult.OK)
            {
                if (of.CheckFileExists)
                {
                    Image = Image.FromFile(of.FileName);
                    pbImage.Image = Image;
                }                
            }
        }
    }
}
