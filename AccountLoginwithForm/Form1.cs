using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountLoginwithForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int girishakkı = 3;
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullanıcıadı = "mtlcan";
            string sifre = "123";
            string gelenkullanıcıadı = txtKullanıcıAdı.Text;
            string gelensifre = txtSifre.Text;

            if (kullanıcıadı==gelenkullanıcıadı&&sifre==gelensifre)
            {
                Hesap H1 = new Hesap();
                H1.Show();
            }
            else
            {
                girishakkı--;
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı\n" +
                    "Kalan Giriş Yapma Hakkınız: " + girishakkı,"Bilgilendirme",MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                if (girishakkı==0)
                {
                    MessageBox.Show("Kullanıcı Sistemine Giriş Hakkınız Dolmuştur", "Bilgilendirme",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void txtKullanıcıAdı_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.Aqua;
        }

        private void txtKullanıcıAdı_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.White;
        }
    }
}
