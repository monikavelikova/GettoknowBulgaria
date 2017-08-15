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
    public partial class FormEzik : Form
    {
        public FormEzik()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxEnglish_Click(object sender, EventArgs e)
        {
            FormDescription f = new FormDescription();
            f.Show();
            this.Hide();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxBulgaria_Click(object sender, EventArgs e)
        {
            FormDescriptionBG f = new FormDescriptionBG();
            f.Show();
            this.Hide();
        }
    }
}
