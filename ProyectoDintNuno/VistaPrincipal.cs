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
                
                panel.Controls.Add(pb);
                panel.Controls.Add(lblName);
                panel.Controls.Add(lblArtist);

                lblName.Text = form.Name;
                lblName.Font = new Font("Segoe UI", 9);
                lblArtist.Text = form.PArtist;
                lblArtist.Font = new Font("Segoe UI", 6);

                flpConjunto.Controls.Add(panel);
            }

            
        }
    }
}
