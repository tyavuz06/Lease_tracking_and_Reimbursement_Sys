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
    public partial class Form8 : Form
    {
        OleDbDataReader dr;
        OleDbDataReader dr3;
        OleDbDataReader dr5;
        public Form8()
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
        OleDbCommand komut6 = new OleDbCommand();


        private void Form8_Load(object sender, EventArgs e)
        {
            komut.Connection = baglan;
            komut.CommandText = "SELECT * FROM KIRACI";
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                lstIsim.Items.Add(dr["adsoyad"]);
            }
            yukle();
        }
     
        void yukle()
        {
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from KIRACI", baglan);
            DataSet ds = new DataSet();
            ds.Clear();
            adaptor.Fill(ds, "KIRACI");
            dataGridView1.DataSource = ds.Tables["KIRACI"];
            adaptor.Dispose();
  
        }
        private void btnBorcDus_Click(object sender, EventArgs e)
        {
            
            if (lstIsim.SelectedItem!=null)
            {
                string ad = lstIsim.SelectedItem.ToString();
                komut3.Connection = baglan;
                komut3.CommandText = "select * from KIRACI where adsoyad like '" + ad + "%'";
                dr3 = komut3.ExecuteReader();
                DateTime tarih = DateTime.Today;

                while (dr3.Read())
                {
                    int borc = Convert.ToInt32(dr3["borc"]);
                    int dusulcekmiktar = Convert.ToInt32(txtDus.Text);
                    borc = borc - dusulcekmiktar;
                    komut4.Connection = baglan;
                    string sorgu = "update KIRACI set borc='" + borc + "', odemetarihi='" + tarih + "' where adsoyad like  '" + ad + "%'";
                    OleDbCommand com = new OleDbCommand(sorgu, baglan);
                    com.ExecuteNonQuery();
                }
                dr3.Close();
            }
            else
                MessageBox.Show("Listeden Birini Seçiniz");
            
            yukle();
                     
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int totalborc = 0;
            for (int j = 0; j < lstIsim.Items.Count; j++)
            {
                string ad = lstIsim.Items[j].ToString();
                komut6.Connection = baglan;
                komut6.CommandText = "select * from KIRACI where adsoyad like '" + ad + "%'";
                dr5 = komut6.ExecuteReader();

                while (dr5.Read())
                {
                    int borc = Convert.ToInt32(dr5["borc"]);
                    totalborc = totalborc + borc;
                }
                dr5.Close();
            }
            txtToplamBorc.Text = totalborc.ToString();
        }
    }
}
