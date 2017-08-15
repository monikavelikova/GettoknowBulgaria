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
    public partial class FormBurgasProvinceEcoPathsEn : Form
    {
        public FormBurgasProvinceEcoPathsEn()
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
            FormBurgasProvince f = new FormBurgasProvince();
            f.Show();
            this.Hide();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            FormTheCaveEcoPath f = new FormTheCaveEcoPath();
            f.Show();
            this.Hide();
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            FormMarinaRekaEcoPath f = new FormMarinaRekaEcoPath();
            f.Show();
            this.Hide();
        }
    }
}
