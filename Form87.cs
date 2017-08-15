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
    public partial class FormNeviastataEcoPath : Form
    {
        public FormNeviastataEcoPath()
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

        private void buttoBack_Click(object sender, EventArgs e)
        {
            FormSmolyanProvinceEcoPaths f = new FormSmolyanProvinceEcoPaths();
            f.Show();
            this.Hide();
        }
    }
}
