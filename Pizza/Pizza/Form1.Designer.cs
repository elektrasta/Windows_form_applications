
namespace Pizza
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbEbatKucuk = new System.Windows.Forms.RadioButton();
            this.rbEbatOrta = new System.Windows.Forms.RadioButton();
            this.rbEbatBuyuk = new System.Windows.Forms.RadioButton();
            this.rbKenarInce = new System.Windows.Forms.RadioButton();
            this.rbKenarKalin = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lstPizzalar = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSusam = new System.Windows.Forms.CheckBox();
            this.cbSosis = new System.Windows.Forms.CheckBox();
            this.cbJambon = new System.Windows.Forms.CheckBox();
            this.cbMantar = new System.Windows.Forms.CheckBox();
            this.cbSiyahZeytin = new System.Windows.Forms.CheckBox();
            this.cbPeynir = new System.Windows.Forms.CheckBox();
            this.cbDomates = new System.Windows.Forms.CheckBox();
            this.cbKozBiber = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnSiparisOnayla = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ebat";
            // 
            // rbEbatKucuk
            // 
            this.rbEbatKucuk.AutoSize = true;
            this.rbEbatKucuk.Checked = true;
            this.rbEbatKucuk.Location = new System.Drawing.Point(6, 23);
            this.rbEbatKucuk.Name = "rbEbatKucuk";
            this.rbEbatKucuk.Size = new System.Drawing.Size(56, 17);
            this.rbEbatKucuk.TabIndex = 2;
            this.rbEbatKucuk.TabStop = true;
            this.rbEbatKucuk.Text = "Küçük";
            this.rbEbatKucuk.UseVisualStyleBackColor = true;
            // 
            // rbEbatOrta
            // 
            this.rbEbatOrta.AutoSize = true;
            this.rbEbatOrta.Location = new System.Drawing.Point(68, 23);
            this.rbEbatOrta.Name = "rbEbatOrta";
            this.rbEbatOrta.Size = new System.Drawing.Size(45, 17);
            this.rbEbatOrta.TabIndex = 3;
            this.rbEbatOrta.Text = "Orta";
            this.rbEbatOrta.UseVisualStyleBackColor = true;
            // 
            // rbEbatBuyuk
            // 
            this.rbEbatBuyuk.AutoSize = true;
            this.rbEbatBuyuk.Location = new System.Drawing.Point(119, 23);
            this.rbEbatBuyuk.Name = "rbEbatBuyuk";
            this.rbEbatBuyuk.Size = new System.Drawing.Size(55, 17);
            this.rbEbatBuyuk.TabIndex = 4;
            this.rbEbatBuyuk.Text = "Büyük";
            this.rbEbatBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbKenarInce
            // 
            this.rbKenarInce.AutoSize = true;
            this.rbKenarInce.Checked = true;
            this.rbKenarInce.Location = new System.Drawing.Point(7, 26);
            this.rbKenarInce.Name = "rbKenarInce";
            this.rbKenarInce.Size = new System.Drawing.Size(77, 17);
            this.rbKenarInce.TabIndex = 5;
            this.rbKenarInce.TabStop = true;
            this.rbKenarInce.Text = "İnce Kenar";
            this.rbKenarInce.UseVisualStyleBackColor = true;
            // 
            // rbKenarKalin
            // 
            this.rbKenarKalin.AutoSize = true;
            this.rbKenarKalin.Location = new System.Drawing.Point(98, 26);
            this.rbKenarKalin.Name = "rbKenarKalin";
            this.rbKenarKalin.Size = new System.Drawing.Size(79, 17);
            this.rbKenarKalin.TabIndex = 6;
            this.rbKenarKalin.Text = "Kalın Kenar";
            this.rbKenarKalin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbEbatKucuk);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbEbatOrta);
            this.panel1.Controls.Add(this.rbEbatBuyuk);
            this.panel1.Location = new System.Drawing.Point(18, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 52);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pizzalar";
            // 
            // lstPizzalar
            // 
            this.lstPizzalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstPizzalar.FormattingEnabled = true;
            this.lstPizzalar.ItemHeight = 15;
            this.lstPizzalar.Items.AddRange(new object[] {
            "Süperos",
            "Sucuk Sever",
            "Margarita",
            "Bol Malzemos",
            "Karışık"});
            this.lstPizzalar.Location = new System.Drawing.Point(18, 30);
            this.lstPizzalar.Name = "lstPizzalar";
            this.lstPizzalar.Size = new System.Drawing.Size(200, 79);
            this.lstPizzalar.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rbKenarKalin);
            this.panel2.Controls.Add(this.rbKenarInce);
            this.panel2.Location = new System.Drawing.Point(18, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 53);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kenar";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbKozBiber);
            this.panel3.Controls.Add(this.cbDomates);
            this.panel3.Controls.Add(this.cbPeynir);
            this.panel3.Controls.Add(this.cbSiyahZeytin);
            this.panel3.Controls.Add(this.cbMantar);
            this.panel3.Controls.Add(this.cbJambon);
            this.panel3.Controls.Add(this.cbSosis);
            this.panel3.Controls.Add(this.cbSusam);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(18, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 129);
            this.panel3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ekstra Malzemeler";
            // 
            // cbSusam
            // 
            this.cbSusam.AutoSize = true;
            this.cbSusam.Location = new System.Drawing.Point(7, 29);
            this.cbSusam.Name = "cbSusam";
            this.cbSusam.Size = new System.Drawing.Size(58, 17);
            this.cbSusam.TabIndex = 6;
            this.cbSusam.Text = "Susam";
            this.cbSusam.UseVisualStyleBackColor = true;
            // 
            // cbSosis
            // 
            this.cbSosis.AutoSize = true;
            this.cbSosis.Location = new System.Drawing.Point(6, 52);
            this.cbSosis.Name = "cbSosis";
            this.cbSosis.Size = new System.Drawing.Size(51, 17);
            this.cbSosis.TabIndex = 7;
            this.cbSosis.Text = "Sosis";
            this.cbSosis.UseVisualStyleBackColor = true;
            // 
            // cbJambon
            // 
            this.cbJambon.AutoSize = true;
            this.cbJambon.Location = new System.Drawing.Point(6, 75);
            this.cbJambon.Name = "cbJambon";
            this.cbJambon.Size = new System.Drawing.Size(63, 17);
            this.cbJambon.TabIndex = 8;
            this.cbJambon.Text = "Jambon";
            this.cbJambon.UseVisualStyleBackColor = true;
            // 
            // cbMantar
            // 
            this.cbMantar.AutoSize = true;
            this.cbMantar.Location = new System.Drawing.Point(6, 98);
            this.cbMantar.Name = "cbMantar";
            this.cbMantar.Size = new System.Drawing.Size(59, 17);
            this.cbMantar.TabIndex = 9;
            this.cbMantar.Text = "Mantar";
            this.cbMantar.UseVisualStyleBackColor = true;
            // 
            // cbSiyahZeytin
            // 
            this.cbSiyahZeytin.AutoSize = true;
            this.cbSiyahZeytin.Location = new System.Drawing.Point(93, 29);
            this.cbSiyahZeytin.Name = "cbSiyahZeytin";
            this.cbSiyahZeytin.Size = new System.Drawing.Size(84, 17);
            this.cbSiyahZeytin.TabIndex = 10;
            this.cbSiyahZeytin.Text = "Siyah Zeytin";
            this.cbSiyahZeytin.UseVisualStyleBackColor = true;
            // 
            // cbPeynir
            // 
            this.cbPeynir.AutoSize = true;
            this.cbPeynir.Location = new System.Drawing.Point(92, 52);
            this.cbPeynir.Name = "cbPeynir";
            this.cbPeynir.Size = new System.Drawing.Size(55, 17);
            this.cbPeynir.TabIndex = 11;
            this.cbPeynir.Text = "Peynir";
            this.cbPeynir.UseVisualStyleBackColor = true;
            // 
            // cbDomates
            // 
            this.cbDomates.AutoSize = true;
            this.cbDomates.Location = new System.Drawing.Point(92, 75);
            this.cbDomates.Name = "cbDomates";
            this.cbDomates.Size = new System.Drawing.Size(68, 17);
            this.cbDomates.TabIndex = 12;
            this.cbDomates.Text = "Domates";
            this.cbDomates.UseVisualStyleBackColor = true;
            // 
            // cbKozBiber
            // 
            this.cbKozBiber.AutoSize = true;
            this.cbKozBiber.Location = new System.Drawing.Point(92, 98);
            this.cbKozBiber.Name = "cbKozBiber";
            this.cbKozBiber.Size = new System.Drawing.Size(71, 17);
            this.cbKozBiber.TabIndex = 13;
            this.cbKozBiber.Text = "Köz Biber";
            this.cbKozBiber.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(244, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Adet";
            // 
            // numAdet
            // 
            this.numAdet.Location = new System.Drawing.Point(247, 30);
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(75, 20);
            this.numAdet.TabIndex = 13;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(328, 30);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 14;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(592, 30);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSepeteEkle.TabIndex = 17;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(479, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tutar";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(482, 32);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(105, 20);
            this.txtTutar.TabIndex = 18;
            // 
            // lstSepet
            // 
            this.lstSepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 15;
            this.lstSepet.Location = new System.Drawing.Point(247, 59);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(420, 289);
            this.lstSepet.TabIndex = 19;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(244, 354);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(89, 15);
            this.lblToplamTutar.TabIndex = 20;
            this.lblToplamTutar.Text = "Toplam Tutar : ";
            // 
            // btnSiparisOnayla
            // 
            this.btnSiparisOnayla.Location = new System.Drawing.Point(561, 351);
            this.btnSiparisOnayla.Name = "btnSiparisOnayla";
            this.btnSiparisOnayla.Size = new System.Drawing.Size(106, 23);
            this.btnSiparisOnayla.TabIndex = 21;
            this.btnSiparisOnayla.Text = "Siparişi Onayla";
            this.btnSiparisOnayla.UseVisualStyleBackColor = true;
            this.btnSiparisOnayla.Click += new System.EventHandler(this.btnSiparisOnayla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 381);
            this.Controls.Add(this.btnSiparisOnayla);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.numAdet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lstPizzalar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Pizza Otomasyonu v1.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbEbatKucuk;
        private System.Windows.Forms.RadioButton rbEbatOrta;
        private System.Windows.Forms.RadioButton rbEbatBuyuk;
        private System.Windows.Forms.RadioButton rbKenarInce;
        private System.Windows.Forms.RadioButton rbKenarKalin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstPizzalar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbKozBiber;
        private System.Windows.Forms.CheckBox cbDomates;
        private System.Windows.Forms.CheckBox cbPeynir;
        private System.Windows.Forms.CheckBox cbSiyahZeytin;
        private System.Windows.Forms.CheckBox cbMantar;
        private System.Windows.Forms.CheckBox cbJambon;
        private System.Windows.Forms.CheckBox cbSosis;
        private System.Windows.Forms.CheckBox cbSusam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnSiparisOnayla;
    }
}

