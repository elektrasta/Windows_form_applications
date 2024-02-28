
namespace _20220328_AtYarisi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbAt1 = new System.Windows.Forms.PictureBox();
            this.pbAt2 = new System.Windows.Forms.PictureBox();
            this.pbAt3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBaslat = new System.Windows.Forms.Button();
            this.pnlAt1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt3)).BeginInit();
            this.pnlAt1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAt1
            // 
            this.pbAt1.Image = ((System.Drawing.Image)(resources.GetObject("pbAt1.Image")));
            this.pbAt1.Location = new System.Drawing.Point(3, 3);
            this.pbAt1.Name = "pbAt1";
            this.pbAt1.Size = new System.Drawing.Size(174, 137);
            this.pbAt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt1.TabIndex = 0;
            this.pbAt1.TabStop = false;
            // 
            // pbAt2
            // 
            this.pbAt2.Image = ((System.Drawing.Image)(resources.GetObject("pbAt2.Image")));
            this.pbAt2.Location = new System.Drawing.Point(44, 195);
            this.pbAt2.Name = "pbAt2";
            this.pbAt2.Size = new System.Drawing.Size(177, 137);
            this.pbAt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt2.TabIndex = 1;
            this.pbAt2.TabStop = false;
            // 
            // pbAt3
            // 
            this.pbAt3.Image = ((System.Drawing.Image)(resources.GetObject("pbAt3.Image")));
            this.pbAt3.Location = new System.Drawing.Point(44, 354);
            this.pbAt3.Name = "pbAt3";
            this.pbAt3.Size = new System.Drawing.Size(177, 137);
            this.pbAt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt3.TabIndex = 2;
            this.pbAt3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Location = new System.Drawing.Point(44, 558);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(177, 57);
            this.btnBaslat.TabIndex = 3;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // pnlAt1
            // 
            this.pnlAt1.Controls.Add(this.label1);
            this.pnlAt1.Controls.Add(this.pbAt1);
            this.pnlAt1.Location = new System.Drawing.Point(44, 12);
            this.pnlAt1.Name = "pnlAt1";
            this.pnlAt1.Size = new System.Drawing.Size(177, 188);
            this.pnlAt1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bold Pilot";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 627);
            this.Controls.Add(this.pnlAt1);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.pbAt3);
            this.Controls.Add(this.pbAt2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt3)).EndInit();
            this.pnlAt1.ResumeLayout(false);
            this.pnlAt1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAt1;
        private System.Windows.Forms.PictureBox pbAt2;
        private System.Windows.Forms.PictureBox pbAt3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Panel pnlAt1;
        private System.Windows.Forms.Label label1;
    }
}

