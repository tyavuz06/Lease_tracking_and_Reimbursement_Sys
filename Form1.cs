using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DukkanDeneme1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciadi = "UNLUHOLDING";
            string kullanicisifre = "714741";
            if (txtKullaniciAd.Text == "")
                MessageBox.Show("Kullanıcı Adını Giriniz.");
            else if (txtKullaniciSifre.Text == "")
                MessageBox.Show("Şifre Kısmını Giriniz.");
            else if (kullaniciadi == txtKullaniciAd.Text && kullanicisifre == txtKullaniciSifre.Text)
            {
                MessageBox.Show("Kullanıcı Adı ve Şifresi Onaylandı.");
                Form5 f5;
                f5 = new Form5();
                f5.ShowDialog();
                
                //txtKullaniciAd.Text = "";
                //txtKullaniciSifre.Text = "";
                
            }
            else
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKullaniciAd.Text = "UNLUHOLDING";
            txtKullaniciSifre.Text = "714741";
        }
    }
}
