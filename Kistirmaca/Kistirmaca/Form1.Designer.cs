namespace Kistirmaca
{
    partial class Form1
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
            this.lblKucukSayi = new System.Windows.Forms.Label();
            this.lblBuyukSayi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblKucukSayi
            // 
            this.lblKucukSayi.AutoSize = true;
            this.lblKucukSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKucukSayi.ForeColor = System.Drawing.Color.Tomato;
            this.lblKucukSayi.Location = new System.Drawing.Point(47, 57);
            this.lblKucukSayi.Name = "lblKucukSayi";
            this.lblKucukSayi.Size = new System.Drawing.Size(42, 46);
            this.lblKucukSayi.TabIndex = 0;
            this.lblKucukSayi.Text = "0";
            // 
            // lblBuyukSayi
            // 
            this.lblBuyukSayi.AutoSize = true;
            this.lblBuyukSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBuyukSayi.ForeColor = System.Drawing.Color.Tomato;
            this.lblBuyukSayi.Location = new System.Drawing.Point(176, 57);
            this.lblBuyukSayi.Name = "lblBuyukSayi";
            this.lblBuyukSayi.Size = new System.Drawing.Size(86, 46);
            this.lblBuyukSayi.TabIndex = 1;
            this.lblBuyukSayi.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Küçük Değer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(161, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Büyük Değer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(128, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 46);
            this.label5.TabIndex = 4;
            this.label5.Text = "-";
            // 
            // txtSayi
            // 
            this.txtSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi.Location = new System.Drawing.Point(108, 119);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(65, 38);
            this.txtSayi.TabIndex = 5;
            // 
            // btnTahmin
            // 
            this.btnTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTahmin.Location = new System.Drawing.Point(39, 163);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(199, 38);
            this.btnTahmin.TabIndex = 6;
            this.btnTahmin.Text = "Tahmin Et";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.BtnTahmin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(34, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sıra : ";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.Color.Tomato;
            this.lblKullanici.Location = new System.Drawing.Point(95, 224);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(100, 24);
            this.lblKullanici.TabIndex = 8;
            this.lblKullanici.Text = "1. Kullanıcı";
            // 
            // lstSonuc
            // 
            this.lstSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.ItemHeight = 20;
            this.lstSonuc.Location = new System.Drawing.Point(288, 26);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(241, 224);
            this.lstSonuc.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 267);
            this.Controls.Add(this.lstSonuc);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBuyukSayi);
            this.Controls.Add(this.lblKucukSayi);
            this.Name = "Form1";
            this.Text = "W";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKucukSayi;
        private System.Windows.Forms.Label lblBuyukSayi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.ListBox lstSonuc;
    }
}

