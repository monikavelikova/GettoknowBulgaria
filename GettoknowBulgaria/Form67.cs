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
    public partial class FormVelikoTarnovoEcoPathsEn : Form
    {
        public FormVelikoTarnovoEcoPathsEn()
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormEmenskiCanyonEcoPath f = new FormEmenskiCanyonEcoPath();
            f.Show();
            this.Hide();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            FormEmenskiCanyonEcoPath f = new FormEmenskiCanyonEcoPath();
            f.Show();
            this.Hide();
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            FormHotnitsaEcoPath f = new FormHotnitsaEcoPath();
            f.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormVelikoTurnovoProvince f = new FormVelikoTurnovoProvince();
            f.Show();
            this.Hide();
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            FormNegovanskaEcoPath f = new FormNegovanskaEcoPath();
            f.Show();
            this.Hide();
        }
    }
}
