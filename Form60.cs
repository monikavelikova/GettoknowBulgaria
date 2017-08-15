﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GettoknowBulgaria
{
    public partial class FormMontanaProvinceEcoPathsEn : Form
    {
        public FormMontanaProvinceEcoPathsEn()
        {
            InitializeComponent();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMontana f = new FormMontana();
            f.Show();
            this.Hide();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            FormTheKoprenEcoPath f = new FormTheKoprenEcoPath();
            f.Show();
            this.Hide();
        }
    }
}