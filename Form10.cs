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
    public partial class Form10 : Form
    {
        OleDbConnection baglan = new OleDbConnection("provider=Microsoft.jet.oledb.4.0; Data Source=Dukkan1.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbCommand komut2 = new OleDbCommand();
        OleDbDataReader dr2;
        public Form10()
        {
            InitializeComponent();
            baglan.Open();
        }

        public void yukle()
        {
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from GIDERLER", baglan);
            DataSet ds = new DataSet();
            ds.Clear();
            adaptor.Fill(ds, "GIDERLER");
            dataGridView1.DataSource = ds.Tables["GIDERLER"];
            adaptor.Dispose();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Today.ToString();
            yukle();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtPara.Text == "")
            {
                MessageBox.Show("Boş Olan Bölümleri Doldurunuz!");
            }
            else
            {
                komut.Connection = baglan;
                komut.CommandText = "insert into GIDERLER(firma_ad, odenen_tutar, odeme_tarih) values('" + txtAd.Text + "','" + txtPara.Text + "','" + dateTimePicker1.Value + "')";
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Yapıldı");
                txtAd.Text = "";
                txtPara.Text = "";
                txtAd.Focus();
                yukle();
            }
        }

        private void txtFirmaAra_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adaptor2 = new OleDbDataAdapter("Select * from GIDERLER where firma_ad like '%" + txtFirmaAra.Text + "%'", baglan);
            DataSet ds2 = new DataSet();
            ds2.Clear();
            adaptor2.Fill(ds2, "GIDERLER");
            dataGridView1.DataSource = ds2.Tables["GIDERLER"];
            adaptor2.Dispose();

            int totalborc = 0;
            if (txtFirmaAra.Text != "")
            {
                string ad = txtFirmaAra.Text;
                komut2.Connection = baglan;
                komut2.CommandText = "select * from GIDERLER where firma_ad like '%" + ad + "%'";
                dr2 = komut2.ExecuteReader();

                while (dr2.Read())
                {
                    totalborc = totalborc + Convert.ToInt32(dr2["odenen_tutar"]);
                }
                dr2.Close();
                txtFirmaOdenen.Text = totalborc.ToString();
            }
            else
            {
                MessageBox.Show("Firma Adı Giriniz:");
                txtFirmaOdenen.Text = "";
            }
        }
    }
}
