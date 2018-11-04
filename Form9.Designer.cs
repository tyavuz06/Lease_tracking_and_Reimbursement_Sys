namespace DukkanDeneme1
{
    partial class Form9
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
            this.btnMusteri = new System.Windows.Forms.Button();
            this.btnUrun = new System.Windows.Forms.Button();
            this.btnVeresiye = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMusteri
            // 
            this.btnMusteri.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnMusteri.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusteri.ForeColor = System.Drawing.SystemColors.Info;
            this.btnMusteri.Location = new System.Drawing.Point(92, 274);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(245, 143);
            this.btnMusteri.TabIndex = 7;
            this.btnMusteri.Text = "Musteri Kayıt";
            this.btnMusteri.UseVisualStyleBackColor = false;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnUrun
            // 
            this.btnUrun.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnUrun.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrun.ForeColor = System.Drawing.SystemColors.Info;
            this.btnUrun.Location = new System.Drawing.Point(388, 273);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(221, 145);
            this.btnUrun.TabIndex = 8;
            this.btnUrun.Text = "Ürün Kayıt";
            this.btnUrun.UseVisualStyleBackColor = false;
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // btnVeresiye
            // 
            this.btnVeresiye.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnVeresiye.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeresiye.ForeColor = System.Drawing.SystemColors.Info;
            this.btnVeresiye.Location = new System.Drawing.Point(684, 275);
            this.btnVeresiye.Name = "btnVeresiye";
            this.btnVeresiye.Size = new System.Drawing.Size(211, 143);
            this.btnVeresiye.TabIndex = 9;
            this.btnVeresiye.Text = "Veresiye";
            this.btnVeresiye.UseVisualStyleBackColor = false;
            this.btnVeresiye.Click += new System.EventHandler(this.btnVeresiye_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCikis.Font = new System.Drawing.Font("Viner Hand ITC", 20F, System.Drawing.FontStyle.Bold);
            this.btnCikis.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCikis.Location = new System.Drawing.Point(388, 445);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(221, 127);
            this.btnCikis.TabIndex = 10;
            this.btnCikis.Text = "Çıkıs";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Viner Hand ITC", 50F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(261, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(578, 108);
            this.label6.TabIndex = 27;
            this.label6.Text = "ÜNLÜ MARKET";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnVeresiye);
            this.Controls.Add(this.btnUrun);
            this.Controls.Add(this.btnMusteri);
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DÜKKAN İŞLEMLERİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Button btnVeresiye;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label6;
    }
}