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
    public partial class FormGabrovoProvinceEcoPaths : Form
    {
        public FormGabrovoProvinceEcoPaths()
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
            FormVitataStenaEcoPath f = new FormVitataStenaEcoPath();
            f.Show();
            this.Hide();
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            FormViaFerataEcoPath f = new FormViaFerataEcoPath();
            f.Show();
            this.Hide();
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            FormDrqnovskaEcoPath f = new FormDrqnovskaEcoPath();
            f.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormGabrovoProvince f = new FormGabrovoProvince();
            f.Show();
            this.Hide();
        }
    }
}
