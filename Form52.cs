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
    public partial class FormPlovdivProvinceEcoPathsEn : Form
    {
        public FormPlovdivProvinceEcoPathsEn()
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

        private void buttonOne_Click(object sender, EventArgs e)
        {
            FormTheWhiteRiverEcoPath f = new FormTheWhiteRiverEcoPath();
            f.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormPlovdivProvince f = new FormPlovdivProvince();
            f.Show();
            this.Hide();
        }
    }
}
