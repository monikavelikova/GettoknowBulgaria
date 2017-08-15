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
    public partial class FormMap : Form
    {
        public FormMap()
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

        private void buttonPazardhik_Click(object sender, EventArgs e)
        {
            FormPazardzhik f = new FormPazardzhik();
            f.Show();
            this.Hide();
        }

        private void buttonRuse_Click(object sender, EventArgs e)
        {
            FormRuse f = new FormRuse();
            f.Show();
            this.Hide();
        }

        private void buttonSofia_Click(object sender, EventArgs e)
        {
            FormSofiaProvince f = new FormSofiaProvince();
            f.Show();
            this.Hide();
        }

        private void buttonDobrich_Click(object sender, EventArgs e)
        {
            FormDobrich f = new FormDobrich();
            f.Show();
            this.Hide();
        }

        private void buttonSilistra_Click(object sender, EventArgs e)
        {
            FormSilistraProvince f = new FormSilistraProvince();
            f.Show();
            this.Hide();
        }

        private void buttonVarna_Click(object sender, EventArgs e)
        {
            FormVarna f = new FormVarna();
            f.Show();
            this.Hide();
        }

        private void buttonVelikoTarnovo_Click(object sender, EventArgs e)
        {
            FormVelikoTurnovoProvince f = new FormVelikoTurnovoProvince();
            f.Show();
            this.Hide();
        }

        private void buttonPleven_Click(object sender, EventArgs e)
        {
            FormPlevenProvince f = new FormPlevenProvince();
            f.Show();
            this.Hide();
        }

        private void buttonLovech_Click(object sender, EventArgs e)
        {
            FormLovechProvince f = new FormLovechProvince();
            f.Show();
            this.Hide();
        }

        private void buttonGabrovo_Click(object sender, EventArgs e)
        {
            FormGabrovoProvince f = new FormGabrovoProvince();
            f.Show();
            this.Hide();
        }

        private void buttonVratsa_Click(object sender, EventArgs e)
        {
            FormVratsaProvince f = new FormVratsaProvince();
            f.Show();
            this.Hide();
        }

        private void buttonMontana_Click(object sender, EventArgs e)
        {
            FormMontana f = new FormMontana();
            f.Show();
            this.Hide();
        }

        private void buttonVidin_Click(object sender, EventArgs e)
        {
            FormVidinProvince f = new FormVidinProvince();
            f.Show();
            this.Hide();
        }

        private void buttonPernik_Click(object sender, EventArgs e)
        {
            FormPernik f = new FormPernik();
            f.Show();
            this.Hide();
        }

        private void buttonKyustendil_Click(object sender, EventArgs e)
        {
            FormKyustendilProvince f = new FormKyustendilProvince();
            f.Show();
            this.Hide();
        }

        private void buttonBlagoevgrad_Click(object sender, EventArgs e)
        {
            FormBlagoevgradProvince f = new FormBlagoevgradProvince();
            f.Show();
            this.Hide();
        }

        private void buttonSmolyan_Click(object sender, EventArgs e)
        {
            FormSmolyanProvince f = new FormSmolyanProvince();
            f.Show();
            this.Hide();
        }

        private void buttonKardzhali_Click(object sender, EventArgs e)
        {
            FormKardzhaliProvince f = new FormKardzhaliProvince();
            f.Show();
            this.Hide();
        }

        private void buttonHaskovo_Click(object sender, EventArgs e)
        {
            FormHaskovoProvince f = new FormHaskovoProvince();
            f.Show();
            this.Hide();
        }

        private void buttonStaraZagora_Click(object sender, EventArgs e)
        {
            FormStaraZagora f = new FormStaraZagora();
            f.Show();
            this.Hide();
        }

        private void buttonSliven_Click(object sender, EventArgs e)
        {
            FormSlivenProvince f = new FormSlivenProvince();
            f.Show();
            this.Hide();
        }

        private void buttonYambol_Click(object sender, EventArgs e)
        {
            FormYambol f = new FormYambol();
            f.Show();
            this.Hide();
        }

        private void buttonPlovdiv_Click(object sender, EventArgs e)
        {
            FormPlovdivProvince f = new FormPlovdivProvince();
            f.Show();
            this.Hide();
        }

        private void buttonRazgrad_Click(object sender, EventArgs e)
        {
            FormRazgradProvince f = new FormRazgradProvince();
            f.Show();
            this.Hide();
        }

        private void buttonShumen_Click(object sender, EventArgs e)
        {
            FormShumen f = new FormShumen();
            f.Show();
            this.Hide();
        }

        private void buttonTargovishte_Click(object sender, EventArgs e)
        {
            FormTargovishteProvince f = new FormTargovishteProvince();
            f.Show();
            this.Hide();
        }

        private void buttonKazanlak_Click(object sender, EventArgs e)
        {

        }

        private void buttonBurgas_Click(object sender, EventArgs e)
        {

        }

        private void buttonDupnitsa_Click(object sender, EventArgs e)
        {

        }

    }
}
