
namespace projekt
{
    partial class OdgovoriUpitForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPredmet = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbOdgovor = new System.Windows.Forms.RichTextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Predmet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis:";
            // 
            // tbPredmet
            // 
            this.tbPredmet.Enabled = false;
            this.tbPredmet.Location = new System.Drawing.Point(99, 22);
            this.tbPredmet.Name = "tbPredmet";
            this.tbPredmet.Size = new System.Drawing.Size(269, 20);
            this.tbPredmet.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(99, 55);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(269, 20);
            this.tbEmail.TabIndex = 4;
            // 
            // rtbOpis
            // 
            this.rtbOpis.Enabled = false;
            this.rtbOpis.Location = new System.Drawing.Point(99, 88);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(269, 119);
            this.rtbOpis.TabIndex = 5;
            this.rtbOpis.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Odgovor:";
            // 
            // rtbOdgovor
            // 
            this.rtbOdgovor.Location = new System.Drawing.Point(99, 228);
            this.rtbOdgovor.Name = "rtbOdgovor";
            this.rtbOdgovor.Size = new System.Drawing.Size(269, 123);
            this.rtbOdgovor.TabIndex = 7;
            this.rtbOdgovor.Text = "";
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(155, 377);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(75, 23);
            this.btnPosalji.TabIndex = 8;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(247, 377);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // OdgovoriUpitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 432);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.rtbOdgovor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbOpis);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPredmet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OdgovoriUpitForm";
            this.Text = "OdgovoriUpitForm";
            this.Load += new System.EventHandler(this.OdgovoriUpitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPredmet;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbOdgovor;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Button btnOdustani;
    }
}