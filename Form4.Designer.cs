namespace DukkanDeneme1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstIsim = new System.Windows.Forms.ListBox();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lstUrun = new System.Windows.Forms.ListBox();
            this.btnİslemYap = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBakiyeDus = new System.Windows.Forms.Button();
            this.btnBakiyeGuncelle = new System.Windows.Forms.Button();
            this.txtBakiyeDus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.btnCikar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lstIsim
            // 
            this.lstIsim.BackColor = System.Drawing.Color.SaddleBrown;
            this.lstIsim.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstIsim.ForeColor = System.Drawing.SystemColors.Window;
            this.lstIsim.FormattingEnabled = true;
            this.lstIsim.ItemHeight = 31;
            this.lstIsim.Location = new System.Drawing.Point(98, 79);
            this.lstIsim.Name = "lstIsim";
            this.lstIsim.Size = new System.Drawing.Size(453, 190);
            this.lstIsim.TabIndex = 0;
            this.lstIsim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstIsim_MouseClick);
            // 
            // txtBakiye
            // 
            this.txtBakiye.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBakiye.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtBakiye.Location = new System.Drawing.Point(211, 297);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(175, 38);
            this.txtBakiye.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Viner Hand ITC", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 474);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 250);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(12, 638);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 5;
            // 
            // lstUrun
            // 
            this.lstUrun.BackColor = System.Drawing.Color.SaddleBrown;
            this.lstUrun.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUrun.ForeColor = System.Drawing.SystemColors.Info;
            this.lstUrun.FormattingEnabled = true;
            this.lstUrun.ItemHeight = 31;
            this.lstUrun.Location = new System.Drawing.Point(596, 79);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(451, 190);
            this.lstUrun.TabIndex = 6;
            this.lstUrun.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstUrun_MouseClick);
            // 
            // btnİslemYap
            // 
            this.btnİslemYap.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnİslemYap.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnİslemYap.ForeColor = System.Drawing.SystemColors.Info;
            this.btnİslemYap.Location = new System.Drawing.Point(1013, 345);
            this.btnİslemYap.Name = "btnİslemYap";
            this.btnİslemYap.Size = new System.Drawing.Size(203, 52);
            this.btnİslemYap.TabIndex = 7;
            this.btnİslemYap.Text = "EKLE";
            this.btnİslemYap.UseVisualStyleBackColor = false;
            this.btnİslemYap.Click += new System.EventHandler(this.btnİslemYap_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Viner Hand ITC", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(596, 474);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(620, 250);
            this.dataGridView2.TabIndex = 9;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(12, 595);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAd.TabIndex = 10;
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrunFiyat.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtUrunFiyat.Location = new System.Drawing.Point(787, 358);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(175, 38);
            this.txtUrunFiyat.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(660, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 44);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fiyat:";
            // 
            // btnBakiyeDus
            // 
            this.btnBakiyeDus.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnBakiyeDus.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBakiyeDus.ForeColor = System.Drawing.SystemColors.Info;
            this.btnBakiyeDus.Location = new System.Drawing.Point(1013, 409);
            this.btnBakiyeDus.Name = "btnBakiyeDus";
            this.btnBakiyeDus.Size = new System.Drawing.Size(203, 51);
            this.btnBakiyeDus.TabIndex = 13;
            this.btnBakiyeDus.Text = "Bakiye Düzenle";
            this.btnBakiyeDus.UseVisualStyleBackColor = false;
            this.btnBakiyeDus.Click += new System.EventHandler(this.btnBakiyeDus_Click);
            // 
            // btnBakiyeGuncelle
            // 
            this.btnBakiyeGuncelle.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnBakiyeGuncelle.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBakiyeGuncelle.ForeColor = System.Drawing.SystemColors.Info;
            this.btnBakiyeGuncelle.Location = new System.Drawing.Point(401, 309);
            this.btnBakiyeGuncelle.Name = "btnBakiyeGuncelle";
            this.btnBakiyeGuncelle.Size = new System.Drawing.Size(150, 123);
            this.btnBakiyeGuncelle.TabIndex = 14;
            this.btnBakiyeGuncelle.Text = "Bakiye Güncelle";
            this.btnBakiyeGuncelle.UseVisualStyleBackColor = false;
            this.btnBakiyeGuncelle.Click += new System.EventHandler(this.btnBakiyeGuncelle_Click);
            // 
            // txtBakiyeDus
            // 
            this.txtBakiyeDus.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBakiyeDus.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtBakiyeDus.Location = new System.Drawing.Point(787, 422);
            this.txtBakiyeDus.Name = "txtBakiyeDus";
            this.txtBakiyeDus.Size = new System.Drawing.Size(175, 38);
            this.txtBakiyeDus.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(638, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 44);
            this.label3.TabIndex = 17;
            this.label3.Text = "Miktar:";
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAra.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtAra.Location = new System.Drawing.Point(787, 291);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(175, 38);
            this.txtAra.TabIndex = 18;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(643, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 44);
            this.label4.TabIndex = 19;
            this.label4.Text = "Arama:";
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTutar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtTutar.Location = new System.Drawing.Point(211, 376);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(175, 38);
            this.txtTutar.TabIndex = 20;
            // 
            // btnCikar
            // 
            this.btnCikar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCikar.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCikar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCikar.Location = new System.Drawing.Point(1013, 283);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(203, 52);
            this.btnCikar.TabIndex = 22;
            this.btnCikar.Text = "ÇIKAR";
            this.btnCikar.UseVisualStyleBackColor = false;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(67, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 44);
            this.label7.TabIndex = 3;
            this.label7.Text = "Bakiye:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(90, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 44);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tutar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Viner Hand ITC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(460, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(351, 65);
            this.label6.TabIndex = 23;
            this.label6.Text = "ÜNLÜ MARKET";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1286, 729);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBakiyeDus);
            this.Controls.Add(this.btnBakiyeGuncelle);
            this.Controls.Add(this.btnBakiyeDus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunFiyat);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnİslemYap);
            this.Controls.Add(this.lstUrun);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.lstIsim);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veresiye";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstIsim;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.ListBox lstUrun;
        private System.Windows.Forms.Button btnİslemYap;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.TextBox txtUrunFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBakiyeDus;
        private System.Windows.Forms.Button btnBakiyeGuncelle;
        private System.Windows.Forms.TextBox txtBakiyeDus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
    }
}