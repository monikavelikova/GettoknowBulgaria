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
    public partial class FormLovechProvince : Form
    {
        public FormLovechProvince()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            FormLovechProvinceEcoPathsEn f = new FormLovechProvinceEcoPathsEn();
            f.Show();
            this.Hide();
        }
    }
}
