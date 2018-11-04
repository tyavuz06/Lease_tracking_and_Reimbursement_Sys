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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            baglan.Open();
        }

        OleDbConnection baglan = new OleDbConnection("provider=Microsoft.jet.oledb.4.0; Data Source=Dukkan1.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbCommand komut2 = new OleDbCommand();

        public void yukle()
        {
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from MUSTERI", baglan);
            DataSet ds = new DataSet();
            ds.Clear();
            adaptor.Fill(ds, "MUSTERI");
            dataGridView1.DataSource = ds.Tables["MUSTERI"];
            adaptor.Dispose();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dukkan1DataSet.MUSTERI' table. You can move, or remove it, as needed.
            //this.mUSTERITableAdapter.Fill(this.dukkan1DataSet.MUSTERI);
            yukle();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();    
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            komut.Connection = baglan;
            komut2.Connection = baglan;
            komut.CommandText = "insert into MUSTERI(adsoyad) values('" + txtAd.Text + "')";
            komut2.CommandText = "insert into VERESIYE(musteri_ad) values('" + txtAd.Text + "')";
            komut.ExecuteNonQuery();
            komut2.ExecuteNonQuery();
            MessageBox.Show("Kayıt Yapıldı");
            txtAd.Text = "";
            txtAd.Focus();
            yukle();
        }
    }
}
