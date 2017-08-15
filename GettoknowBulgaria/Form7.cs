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
    public partial class FormThePathOfTheHeroes : Form
    {
        public FormThePathOfTheHeroes()
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

        private void buttonMap_Click(object sender, EventArgs e)
        {
            FormTheHeroesPathMap f = new FormTheHeroesPathMap();
            f.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormPazrdzhikEcoPaths f = new FormPazrdzhikEcoPaths();
            f.Show();
            this.Hide();
        }
    }
}
