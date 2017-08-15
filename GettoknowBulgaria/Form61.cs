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
    public partial class FormSlivenProvinceEcoPathsEn : Form
    {
        public FormSlivenProvinceEcoPathsEn()
        {
            InitializeComponent();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormSlivenProvince f = new FormSlivenProvince();
            f.Show();
            this.Hide();
        }
    }
}
