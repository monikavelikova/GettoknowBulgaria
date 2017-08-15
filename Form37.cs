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
    public partial class FormSmolyanProvinceEcoPaths : Form
    {
        public FormSmolyanProvinceEcoPaths()
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
            FormCanyonOfTheWaterfalls f = new FormCanyonOfTheWaterfalls();
            f.Show();
            this.Hide();
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            FormZagrajdenEcoPath f = new FormZagrajdenEcoPath();
            f.Show();
            this.Hide();
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            FormNeviastataEcoPath f = new FormNeviastataEcoPath();
            f.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMap f = new FormMap ();
            f.Show();
            this.Hide();
        }
    }
}
