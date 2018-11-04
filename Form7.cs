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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            baglan.Open();
        }
        OleDbConnection baglan = new OleDbConnection("provider=Microsoft.jet.oledb.4.0; Data Source=Dukkan1.mdb");
        OleDbCommand komut = new OleDbCommand();

        public void yukle()
        {
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from KIRACI", baglan);
            DataSet ds = new DataSet();
            ds.Clear();
            adaptor.Fill(ds, "KIRACI");
            dataGridView1.DataSource = ds.Tables["KIRACI"];
            adaptor.Dispose();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Today.ToString();
            yukle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            komut.Connection = baglan;
            komut.CommandText = "insert into KIRACI(adsoyad, kirabedeli, borc,  kayittarihi) values('" + txtAd.Text + "','"+txtKiraBedeli.Text+"','"+txtBorc.Text+"','"+ dateTimePicker1.Value+"')";
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Yapıldı");
            txtAd.Text = "";
            txtKiraBedeli.Text = "";
            txtBorc.Text = "";
            txtAd.Focus();
            yukle();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
