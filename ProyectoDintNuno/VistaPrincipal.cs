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
            FlowLayoutPanel panel = new FlowLayoutPanel();
            PictureBox pb = new PictureBox();
            TextBox tb = new TextBox();
            panel.Controls.Add(pb);
            panel.Controls.Add(tb);
             

            flpConjunto.Controls.Add(panel);
        }
    }
}
