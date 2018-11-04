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
    public partial class Form5 : Form
    {
       
        public Form5()
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
        OleDbDataReader dr;
        OleDbDataReader dr2;

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
                                if (tarih.Day < tarih2.Day)
                                {
                                    if (guncelleme == 0)
                                    {
                                        int guncel = 1;
                                        borc = borc + kira;
                                        komut3.Connection = baglan;
                                        string sorgu = "update KIRACI set borc='" + borc + "', guncelleme='" + guncel + "' where adsoyad like  '" + ad + "%'";
                                        OleDbCommand com = new OleDbCommand(sorgu, baglan);
                                        com.ExecuteNonQuery();
                                        break;
                                    }
                                }

                                if (tarih.Day == tarih2.Day)
                                {
                                    int guncel = 0;
                                    komut3.Connection = baglan;
                                    string sorgu = "update KIRACI set guncelleme='" + guncel + "' where adsoyad like  '" + ad + "%'";
                                    OleDbCommand com = new OleDbCommand(sorgu, baglan);
                                    com.ExecuteNonQuery();
                                    break;
                                }
                            }
                        }

                    }
                    dr2.Close();
                }
                dr.Close();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            borc_hesaplama();
        }


        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKira_Click(object sender, EventArgs e)
        {
            Form6 f6;
            f6 = new Form6();
            f6.ShowDialog();
        }

        private void btnDukkanIslem_Click(object sender, EventArgs e)
        {
            Form9 f9;
            f9 = new Form9();
            f9.ShowDialog();
        }

        private void btnGider_Click(object sender, EventArgs e)
        {
            Form10 f10;
            f10 = new Form10();
            f10.ShowDialog();
        }
    }
}
