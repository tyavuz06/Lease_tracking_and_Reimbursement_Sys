namespace DukkanDeneme1
{
    partial class Form5
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
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKira = new System.Windows.Forms.Button();
            this.btnDukkanIslem = new System.Windows.Forms.Button();
            this.btnGider = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCikis.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCikis.Location = new System.Drawing.Point(362, 513);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(289, 135);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.Text = "Çıkıs";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnKira
            // 
            this.btnKira.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnKira.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKira.ForeColor = System.Drawing.SystemColors.Info;
            this.btnKira.Location = new System.Drawing.Point(362, 295);
            this.btnKira.Name = "btnKira";
            this.btnKira.Size = new System.Drawing.Size(289, 142);
            this.btnKira.TabIndex = 11;
            this.btnKira.Text = "Kira Islemleri";
            this.btnKira.UseVisualStyleBackColor = false;
            this.btnKira.Click += new System.EventHandler(this.btnKira_Click);
            // 
            // btnDukkanIslem
            // 
            this.btnDukkanIslem.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnDukkanIslem.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDukkanIslem.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDukkanIslem.Location = new System.Drawing.Point(12, 295);
            this.btnDukkanIslem.Name = "btnDukkanIslem";
            this.btnDukkanIslem.Size = new System.Drawing.Size(282, 142);
            this.btnDukkanIslem.TabIndex = 12;
            this.btnDukkanIslem.Text = "Dükkan Islemleri";
            this.btnDukkanIslem.UseVisualStyleBackColor = false;
            this.btnDukkanIslem.Click += new System.EventHandler(this.btnDukkanIslem_Click);
            // 
            // btnGider
            // 
            this.btnGider.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnGider.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGider.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGider.Location = new System.Drawing.Point(708, 295);
            this.btnGider.Name = "btnGider";
            this.btnGider.Size = new System.Drawing.Size(265, 142);
            this.btnGider.TabIndex = 13;
            this.btnGider.Text = "Giderler";
            this.btnGider.UseVisualStyleBackColor = false;
            this.btnGider.Click += new System.EventHandler(this.btnGider_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 50F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(216, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(582, 108);
            this.label3.TabIndex = 14;
            this.label3.Text = "ÜNLÜ HOLDING";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGider);
            this.Controls.Add(this.btnDukkanIslem);
            this.Controls.Add(this.btnKira);
            this.Controls.Add(this.btnCikis);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnKira;
        private System.Windows.Forms.Button btnDukkanIslem;
        private System.Windows.Forms.Button btnGider;
        private System.Windows.Forms.Label label3;
    }
}