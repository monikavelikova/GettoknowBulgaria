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
    public partial class FormPazrdzhikEcoPaths : Form
    {
        public FormPazrdzhikEcoPaths()
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
            FormThePathOfTheHeroes f = new FormThePathOfTheHeroes();
            f.Show();
            this.Hide();
        }
    }
}
