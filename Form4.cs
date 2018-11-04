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
    public partial class Form4 : Form
    {
        OleDbDataReader dr;
        OleDbDataReader dr2;
        OleDbDataReader dr3;
        OleDbDataReader dr4;
        OleDbDataReader dr5;
        public Form4()
        {
            InitializeComponent();
            baglan.Open();
        }

        OleDbConnection baglan = new OleDbConnection("provider=Microsoft.jet.oledb.4.0; Data Source=Dukkan1.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbCommand komut2 = new OleDbCommand();
        OleDbCommand komut3 = new OleDbCommand();
        OleDbCommand komut4 = new OleDbCommand();
        OleDbCommand komut5 = new OleDbCommand();
        double tutar;
        private void Form4_Load(object sender, EventArgs e)
        {
            komut.Connection = baglan;
            komut.CommandText = "SELECT * FROM MUSTERI";
            dr = komut.ExecuteReader();
            komut3.Connection = baglan;
            komut3.CommandText = "select * from URUN";
            dr3 = komut3.ExecuteReader();

            while(dr.Read())
            {
                lstIsim.Items.Add(dr["adsoyad"]);
            }

            while (dr3.Read())
            {
                lstUrun.Items.Add(dr3["ad"]);
            }
            yukle();
            txtAd.Visible = false;
            txtUrunAd.Visible = false;
                   
        }
        void yukle()
        {
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from VERESIYE", baglan);
            DataSet ds = new DataSet();
            ds.Clear();
            adaptor.Fill(ds, "VERESIYE");
            dataGridView1.DataSource = ds.Tables["VERESIYE"];
            adaptor.Dispose();

            tutar = 0;

            OleDbDataAdapter adaptor2 = new OleDbDataAdapter("Select * from URUN", baglan);
            DataSet ds2 = new DataSet();
            ds2.Clear();
            adaptor2.Fill(ds2, "URUN");
            dataGridView2.DataSource = ds2.Tables["URUN"];
            adaptor2.Dispose();
        }

        private void btnİslemYap_Click(object sender, EventArgs e)
        {
            if (txtUrunFiyat.Text != "")
            {
                double fiyat = Convert.ToDouble(txtUrunFiyat.Text);
                tutar = fiyat + tutar;
                txtTutar.Text = tutar.ToString();
            }
            else
                MessageBox.Show("Listeden Ürün Seçiniz.");

        }

        private void btnBakiyeGuncelle_Click(object sender, EventArgs e)
        {
            if (txtBakiye.Text != "")
            {
                double bakiye = Convert.ToDouble(txtBakiye.Text);
                bakiye = bakiye + tutar;
                txtBakiye.Text = bakiye.ToString();
                string sorgu = "update VERESIYE set bakiye='" + txtBakiye.Text + "' where musteri_ad like  '" + txtAd.Text + "%'";
                OleDbCommand com = new OleDbCommand(sorgu, baglan);
                com.ExecuteNonQuery();
                txtTutar.Text = "";
                txtBakiyeDus.Text = "";
                yukle();
                MessageBox.Show("Bakiye Güncellemiştir.");
            }
            else
                MessageBox.Show("Listeden Müşteri Seçili Değil!");
        }

        private void btnBakiyeDus_Click(object sender, EventArgs e)
        {
            if (txtBakiyeDus.Text != "")
            {
                double ayar = Convert.ToDouble(txtBakiyeDus.Text);
                double bakiye = Convert.ToDouble(txtBakiye.Text);
                bakiye = bakiye + ayar;
                txtBakiye.Text = bakiye.ToString();
            }
            else
                MessageBox.Show("Öncelikle  Miktarı Giriniz!");
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            komut5.Connection = baglan;
            komut5.CommandText = "select * from URUN where ad like '%" + txtAra.Text + "%'";
            dr5 = komut5.ExecuteReader();
            lstUrun.Items.Clear();
            while (dr5.Read())
            {
                lstUrun.Items.Add(dr5["ad"]);
            }
            dr5.Close();
        }

        private void lstUrun_MouseClick(object sender, MouseEventArgs e)
        {
            txtUrunAd.Text = lstUrun.SelectedItem.ToString();
            komut4.Connection = baglan;
            komut4.CommandText = "select * from URUN where ad like '" + txtUrunAd.Text + "%'";
            dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                txtUrunFiyat.Text = dr4["fiyat"].ToString();
            }
            dr4.Close();
        }

        private void lstIsim_MouseClick(object sender, MouseEventArgs e)
        {
            txtAd.Text = lstIsim.SelectedItem.ToString();
            komut2.Connection = baglan;
            komut2.CommandText = "select * from VERESIYE where musteri_ad like '" + txtAd.Text + "%'";
            dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                txtBakiye.Text = dr2["bakiye"].ToString();
            }
            dr2.Close();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (txtUrunFiyat.Text != "")
            {
                double fiyat = Convert.ToDouble(txtUrunFiyat.Text);
                tutar = tutar - fiyat;
                txtTutar.Text = tutar.ToString();
            }
            else
                MessageBox.Show("Listeden Ürün Seçiniz.");
        }

    

     
    }
}
