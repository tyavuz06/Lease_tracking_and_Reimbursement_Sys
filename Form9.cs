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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            Form2 f2;
            f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            Form3 f3;
            f3 = new Form3();
            f3.ShowDialog();
        }

        private void btnVeresiye_Click(object sender, EventArgs e)
        {
            Form4 f4;
            f4 = new Form4();
            f4.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
