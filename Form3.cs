using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DukkanDeneme1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            baglan.Open();
        }

        OleDbConnection baglan = new OleDbConnection("provider=Microsoft.jet.oledb.4.0; Data Source=Dukkan1.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbCommand komut2 = new OleDbCommand();
        public void yukle()
        {
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from URUN", baglan);
            DataSet ds = new DataSet();
            ds.Clear();
            adaptor.Fill(ds, "URUN");
            dataGridView1.DataSource = ds.Tables["URUN"];
            adaptor.Dispose();
        }

 
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dukkan1DataSet2.URUN' table. You can move, or remove it, as needed.
            //this.uRUNTableAdapter.Fill(this.dukkan1DataSet2.URUN);
            // TODO: This line of code loads data into the 'dukkan1DataSet1.URUN' table. You can move, or remove it, as needed.
            //this.uRUNTableAdapter.Fill(this.dukkan1DataSet1.URUN);
            yukle();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUrunAd.Text != "" && txtUrunFiyat.Text != "")
            {
                komut.Connection = baglan;
                komut.CommandText = "insert into URUN(ad , fiyat) values('" + txtUrunAd.Text + "','" + txtUrunFiyat.Text + "')";
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Yapıldı");
                txtUrunAd.Text = "";
                txtUrunFiyat.Text = "";
                txtUrunAd.Focus();
                yukle();
            }
            else if (txtUrunAd.Text == "" && txtUrunFiyat.Text == "")
                MessageBox.Show("Alanları Doldurunuz.");
            else if (txtUrunFiyat.Text == "" && txtUrunAd.Text != "")
                MessageBox.Show("Ürün Fiyatını Giriniz.");
            else
                MessageBox.Show("Ürün Adını Giriniz.");
        }

        private void btnUrunAra_Click(object sender, EventArgs e)
        {
            if (txtUrunAd.Text != "" && txtUrunFiyat.Text != "")
            {
                komut2.Connection = baglan;
                komut2.CommandText = "update URUN set fiyat='" + txtUrunFiyat.Text + "' where ad Like '" + txtUrunAd.Text + "%'";
                komut2.ExecuteNonQuery();
                MessageBox.Show("Düzenleme Yapıldı!");
                txtUrunAd.Text = "";
                txtUrunFiyat.Text = "";
                txtUrunAd.Focus();
                yukle();
            }
            else if (txtUrunAd.Text == "" && txtUrunFiyat.Text == "")
                MessageBox.Show("Alanları Doldurunuz.");
            else if (txtUrunFiyat.Text == "" && txtUrunAd.Text != "")
                MessageBox.Show("Ürün Fiyatını Giriniz.");
            else
                MessageBox.Show("Ürün Adını Giriniz.");
                
        }
    }
}
