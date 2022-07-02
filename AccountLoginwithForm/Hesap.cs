using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccountLoginwithForm
{
    public partial class Hesap : Form
    {
        public Hesap()
        {
            InitializeComponent();
        }

        private void Hesap_Load(object sender, EventArgs e)
        {
            txtAd.Text = "Mutlucan";
            txtAd.Enabled = false;

            txtSoyad.Text = "Gökçukur";
            txtSoyad.Enabled = false;

            txtOkul.Text = "Kocaeli Üniversitesi";
            txtOkul.Enabled = false;

            ComboBoxSınıf.SelectedIndex = 1;
            ComboBoxSınıf.Enabled = false;

            checkBox1.Checked = true;
            checkBox1.Enabled = false;

            txtYabancıDil.Text = "Bilişim Sistemleri";
            txtYabancıDil.Enabled = false;

            txtMail.Text = "mtlcangokcukur@hotmail.com";
            txtMail.Enabled = false;
        }

        private void btnCık_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
