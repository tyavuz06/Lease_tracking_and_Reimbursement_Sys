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
    public partial class Form6 : Form
    {
        OleDbDataReader dr;
        OleDbDataReader dr2;


        public Form6()
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


        void borc_hesaplama()
        {
            for (int j = 0; j < 1; j++)
            {
                komut.Connection = baglan;
                komut.CommandText = "SELECT * FROM KIRACI";
                dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    string ad = dr["adsoyad"].ToString();
                    komut2.Connection = baglan;
                    komut2.CommandText = "select * from KIRACI where adsoyad like '" + ad + "%'";
                    dr2 = komut2.ExecuteReader();

                    while (dr2.Read())
                    {
                        int kira = Convert.ToInt32(dr2["kirabedeli"]);
                        int borc = Convert.ToInt32(dr2["borc"]);
                        string ktarih = dr2["kayittarihi"].ToString();
                        int guncelleme = Convert.ToInt32(dr2["guncelleme"]);
                        DateTime tarih;
                        tarih = Convert.ToDateTime(ktarih);
                        DateTime tarih2 = DateTime.Today;

                        for (int i = 1; i < 100; i++)
                        {
                            if (tarih.Month == tarih2.AddMonths(-i).Month)
                            {
                                if (tarih.Day <= tarih2.Day)
                                {
                                    if (borc > 0)
                                    {
                                        MessageBox.Show(ad + " isimli kiracının " + borc + " TL miktaronda borcu vardır.");
                                        break;
                                    }
                                }
                            }
                        }

                    }
                    dr2.Close();
                }
                dr.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7;
            f7 = new Form7();
            f7.ShowDialog();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            Form8 f8;
            f8 = new Form8();
            f8.ShowDialog();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            borc_hesaplama();
        }
    }
}
