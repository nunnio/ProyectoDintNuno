using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDintNuno
{
    public partial class VistaPrincipal : Form
    {
        public VistaPrincipal()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            VistaAnadir form = new VistaAnadir();
            if(form.ShowDialog() == DialogResult.OK)
            {
                FlowLayoutPanel panel = new FlowLayoutPanel();
                PictureBox pb = new PictureBox();
                Label lblName = new Label();
                Label lblArtist = new Label();

                lblName.Text = form.Name;
                lblName.Font = new Font("Segoe UI", 16);
                lblName.TextAlign = ContentAlignment.MiddleCenter;
                lblArtist.Text = form.PArtist;
                lblArtist.Font = new Font("Segoe UI", 13);
                lblArtist.TextAlign = ContentAlignment.MiddleCenter;


                panel.Controls.Add(pb);
                panel.Controls.Add(lblName);
                panel.Controls.Add(lblArtist);
                panel.Size = new Size(210, 320);
                

                pb.Image = form.Image;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Size = new Size(180, 260);
                flpConjunto.Controls.Add(panel);
            }            
        }
    }
}
