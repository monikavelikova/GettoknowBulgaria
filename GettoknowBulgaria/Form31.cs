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
    public partial class FormSlivenProvince : Form
    {
        public FormSlivenProvince()
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

        private void buttonEcoPaths_Click(object sender, EventArgs e)
        {
            FormSlivenProvinceEcoPathsEn f = new FormSlivenProvinceEcoPathsEn();
            f.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMap f = new FormMap();
            f.Show();
            this.Hide();
        }
    }
}
