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
    public partial class FormPlovdivProvince : Form
    {
        public FormPlovdivProvince()
        {
            InitializeComponent();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMap f = new FormMap();
            f.Show();
            this.Hide();
        }

        private void buttonEcoPaths_Click(object sender, EventArgs e)
        {
            FormPlovdivProvinceEcoPathsEn f = new FormPlovdivProvinceEcoPathsEn();
            f.Show();
            this.Hide();
        }
    }
}
