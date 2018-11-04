namespace DukkanDeneme1
{
    partial class Form8
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
            this.lstIsim = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBorcDus = new System.Windows.Forms.Button();
            this.txtDus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToplamBorc = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstIsim
            // 
            this.lstIsim.BackColor = System.Drawing.SystemColors.Info;
            this.lstIsim.Font = new System.Drawing.Font("Viner Hand ITC", 15F, System.Drawing.FontStyle.Bold);
            this.lstIsim.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lstIsim.FormattingEnabled = true;
            this.lstIsim.ItemHeight = 32;
            this.lstIsim.Location = new System.Drawing.Point(151, 211);
            this.lstIsim.Name = "lstIsim";
            this.lstIsim.Size = new System.Drawing.Size(281, 388);
            this.lstIsim.TabIndex = 0;
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
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(476, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(601, 234);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnBorcDus
            // 
            this.btnBorcDus.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnBorcDus.Font = new System.Drawing.Font("Viner Hand ITC", 15F, System.Drawing.FontStyle.Bold);
            this.btnBorcDus.ForeColor = System.Drawing.SystemColors.Info;
            this.btnBorcDus.Location = new System.Drawing.Point(935, 199);
            this.btnBorcDus.Name = "btnBorcDus";
            this.btnBorcDus.Size = new System.Drawing.Size(142, 52);
            this.btnBorcDus.TabIndex = 7;
            this.btnBorcDus.Text = "Borç Düs";
            this.btnBorcDus.UseVisualStyleBackColor = false;
            this.btnBorcDus.Click += new System.EventHandler(this.btnBorcDus_Click);
            // 
            // txtDus
            // 
            this.txtDus.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDus.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtDus.Location = new System.Drawing.Point(709, 213);
            this.txtDus.Name = "txtDus";
            this.txtDus.Size = new System.Drawing.Size(189, 38);
            this.txtDus.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(470, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 34);
            this.label4.TabIndex = 12;
            this.label4.Text = "Düsülecek Miktar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(533, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "Toplam Borç:";
            // 
            // txtToplamBorc
            // 
            this.txtToplamBorc.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToplamBorc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtToplamBorc.Location = new System.Drawing.Point(709, 261);
            this.txtToplamBorc.Name = "txtToplamBorc";
            this.txtToplamBorc.Size = new System.Drawing.Size(189, 38);
            this.txtToplamBorc.TabIndex = 15;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnHesapla.Font = new System.Drawing.Font("Viner Hand ITC", 15F, System.Drawing.FontStyle.Bold);
            this.btnHesapla.ForeColor = System.Drawing.SystemColors.Info;
            this.btnHesapla.Location = new System.Drawing.Point(935, 257);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(142, 52);
            this.btnHesapla.TabIndex = 16;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(25, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kiracılar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Viner Hand ITC", 40F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(331, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(553, 87);
            this.label6.TabIndex = 27;
            this.label6.Text = "ÜNLÜ APARTMAN";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1134, 729);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtToplamBorc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDus);
            this.Controls.Add(this.btnBorcDus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lstIsim);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kira İşlemleri";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstIsim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBorcDus;
        private System.Windows.Forms.TextBox txtDus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToplamBorc;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}