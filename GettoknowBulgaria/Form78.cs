using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GettoknowBulgaria
{
    public partial class FormVitataStenaEcoPath : Form
    {
        public FormVitataStenaEcoPath()
        {
            InitializeComponent();
        }

        private void pictureBoxClosew_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormGabrovoProvinceEcoPaths f = new FormGabrovoProvinceEcoPaths();
            f.Show();
            this.Hide();
        }
    }
}
