
namespace _20220328_ParaCekme
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
            this.txtPara = new System.Windows.Forms.TextBox();
            this.lstPara = new System.Windows.Forms.ListBox();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPara
            // 
            this.txtPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPara.Location = new System.Drawing.Point(64, 77);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(135, 41);
            this.txtPara.TabIndex = 0;
            // 
            // lstPara
            // 
            this.lstPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstPara.FormattingEnabled = true;
            this.lstPara.ItemHeight = 36;
            this.lstPara.Location = new System.Drawing.Point(234, 78);
            this.lstPara.Name = "lstPara";
            this.lstPara.Size = new System.Drawing.Size(312, 328);
            this.lstPara.TabIndex = 1;
            // 
            // btnParaCek
            // 
            this.btnParaCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaCek.Location = new System.Drawing.Point(64, 133);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(135, 40);
            this.btnParaCek.TabIndex = 2;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(331, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "ÖMER BANK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnParaCek);
            this.Controls.Add(this.lstPara);
            this.Controls.Add(this.txtPara);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.ListBox lstPara;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.Label label1;
    }
}

