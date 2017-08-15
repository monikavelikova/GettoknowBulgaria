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
    public partial class FormSofiaProvinceEcoPathsEn : Form
    {
        public FormSofiaProvinceEcoPathsEn()
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
            FormVazovaEcoPath f = new FormVazovaEcoPath();
            f.Show();
            this.Hide();
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            FormTheWhiteIskarEcoPath f = new FormTheWhiteIskarEcoPath();
            f.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormSofiaProvince f = new FormSofiaProvince();
            f.Show();
            this.Hide();
        }
    }
}
