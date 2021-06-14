
namespace projekt
{
    partial class OdgovoriForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtPredmet = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.rtbOdgovor = new System.Windows.Forms.RichTextBox();
            this.btnOdgovori = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Predmet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Odgovor";
            // 
            // txtPredmet
            // 
            this.txtPredmet.Enabled = false;
            this.txtPredmet.Location = new System.Drawing.Point(78, 20);
            this.txtPredmet.Name = "txtPredmet";
            this.txtPredmet.Size = new System.Drawing.Size(359, 20);
            this.txtPredmet.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(78, 64);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(359, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // rtbOpis
            // 
            this.rtbOpis.Enabled = false;
            this.rtbOpis.Location = new System.Drawing.Point(78, 124);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(359, 96);
            this.rtbOpis.TabIndex = 6;
            this.rtbOpis.Text = "";
            // 
            // rtbOdgovor
            // 
            this.rtbOdgovor.Location = new System.Drawing.Point(78, 239);
            this.rtbOdgovor.Name = "rtbOdgovor";
            this.rtbOdgovor.Size = new System.Drawing.Size(359, 96);
            this.rtbOdgovor.TabIndex = 7;
            this.rtbOdgovor.Text = "";
            // 
            // btnOdgovori
            // 
            this.btnOdgovori.Location = new System.Drawing.Point(78, 357);
            this.btnOdgovori.Name = "btnOdgovori";
            this.btnOdgovori.Size = new System.Drawing.Size(80, 27);
            this.btnOdgovori.TabIndex = 8;
            this.btnOdgovori.Text = "Odgovori";
            this.btnOdgovori.UseVisualStyleBackColor = true;
            this.btnOdgovori.Click += new System.EventHandler(this.btnOdgovori_Click_1);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(357, 357);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(80, 27);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // OdgovoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 408);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnOdgovori);
            this.Controls.Add(this.rtbOdgovor);
            this.Controls.Add(this.rtbOpis);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPredmet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OdgovoriForm";
            this.Text = "OdgovoriForm";
            this.Load += new System.EventHandler(this.OdgovoriForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPredmet;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.RichTextBox rtbOdgovor;
        private System.Windows.Forms.Button btnOdgovori;
        private System.Windows.Forms.Button btnOdustani;
    }
}