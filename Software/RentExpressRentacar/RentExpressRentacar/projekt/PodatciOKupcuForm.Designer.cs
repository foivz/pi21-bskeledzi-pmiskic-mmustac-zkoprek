
namespace projekt
{
    partial class PodatciOKupcuForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.cvvTextBox = new System.Windows.Forms.TextBox();
            this.datumIstekaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.zavrsiRezervacijuButton = new System.Windows.Forms.Button();
            this.brojKarticeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vozackaDozvolaTextBox = new System.Windows.Forms.TextBox();
            this.oibTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SviPodaci = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "/";
            // 
            // cvvTextBox
            // 
            this.cvvTextBox.Location = new System.Drawing.Point(336, 192);
            this.cvvTextBox.Name = "cvvTextBox";
            this.cvvTextBox.Size = new System.Drawing.Size(69, 20);
            this.cvvTextBox.TabIndex = 32;
            this.cvvTextBox.TextChanged += new System.EventHandler(this.imeTextBox_TextChanged);
            // 
            // datumIstekaTextBox
            // 
            this.datumIstekaTextBox.Location = new System.Drawing.Point(243, 192);
            this.datumIstekaTextBox.Name = "datumIstekaTextBox";
            this.datumIstekaTextBox.Size = new System.Drawing.Size(69, 20);
            this.datumIstekaTextBox.TabIndex = 31;
            this.datumIstekaTextBox.TextChanged += new System.EventHandler(this.imeTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Datum isteka / CVV";
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(19, 288);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(86, 23);
            this.odustaniButton.TabIndex = 29;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // zavrsiRezervacijuButton
            // 
            this.zavrsiRezervacijuButton.Location = new System.Drawing.Point(286, 288);
            this.zavrsiRezervacijuButton.Name = "zavrsiRezervacijuButton";
            this.zavrsiRezervacijuButton.Size = new System.Drawing.Size(118, 23);
            this.zavrsiRezervacijuButton.TabIndex = 28;
            this.zavrsiRezervacijuButton.Text = "Završi Rezervaciju";
            this.zavrsiRezervacijuButton.UseVisualStyleBackColor = true;
            this.zavrsiRezervacijuButton.Click += new System.EventHandler(this.zavrsiRezervacijuButton_Click);
            // 
            // brojKarticeTextBox
            // 
            this.brojKarticeTextBox.Location = new System.Drawing.Point(12, 192);
            this.brojKarticeTextBox.Name = "brojKarticeTextBox";
            this.brojKarticeTextBox.Size = new System.Drawing.Size(148, 20);
            this.brojKarticeTextBox.TabIndex = 27;
            this.brojKarticeTextBox.TextChanged += new System.EventHandler(this.imeTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Broj kartice:";
            // 
            // vozackaDozvolaTextBox
            // 
            this.vozackaDozvolaTextBox.Location = new System.Drawing.Point(243, 120);
            this.vozackaDozvolaTextBox.Name = "vozackaDozvolaTextBox";
            this.vozackaDozvolaTextBox.Size = new System.Drawing.Size(162, 20);
            this.vozackaDozvolaTextBox.TabIndex = 25;
            this.vozackaDozvolaTextBox.TextChanged += new System.EventHandler(this.imeTextBox_TextChanged);
            // 
            // oibTextBox
            // 
            this.oibTextBox.Location = new System.Drawing.Point(12, 121);
            this.oibTextBox.Name = "oibTextBox";
            this.oibTextBox.Size = new System.Drawing.Size(148, 20);
            this.oibTextBox.TabIndex = 24;
            this.oibTextBox.TextChanged += new System.EventHandler(this.imeTextBox_TextChanged);
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Location = new System.Drawing.Point(243, 52);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(162, 20);
            this.prezimeTextBox.TabIndex = 23;
            this.prezimeTextBox.TextChanged += new System.EventHandler(this.imeTextBox_TextChanged);
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(12, 53);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(148, 20);
            this.imeTextBox.TabIndex = 22;
            this.imeTextBox.TextChanged += new System.EventHandler(this.imeTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Vozačka dozvola:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "OIB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ime:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 253);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 20);
            this.txtEmail.TabIndex = 36;
            this.txtEmail.TextChanged += new System.EventHandler(this.imeTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "E-mail:";
            // 
            // SviPodaci
            // 
            this.SviPodaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SviPodaci.ForeColor = System.Drawing.Color.Red;
            this.SviPodaci.Location = new System.Drawing.Point(86, 324);
            this.SviPodaci.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SviPodaci.Name = "SviPodaci";
            this.SviPodaci.Size = new System.Drawing.Size(244, 33);
            this.SviPodaci.TabIndex = 37;
            this.SviPodaci.Text = "Svi podaci moraju biti uneseni!";
            this.SviPodaci.Visible = false;
            // 
            // txtCijena
            // 
            this.txtCijena.Enabled = false;
            this.txtCijena.Location = new System.Drawing.Point(336, 245);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(69, 20);
            this.txtCijena.TabIndex = 38;
 
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Cijena:";
            // 
            // PodatciOKupcuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 375);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.SviPodaci);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cvvTextBox);
            this.Controls.Add(this.datumIstekaTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.zavrsiRezervacijuButton);
            this.Controls.Add(this.brojKarticeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vozackaDozvolaTextBox);
            this.Controls.Add(this.oibTextBox);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PodatciOKupcuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PODATCI O KUPCU";
            this.Load += new System.EventHandler(this.PodatciOKupcuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cvvTextBox;
        private System.Windows.Forms.TextBox datumIstekaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button zavrsiRezervacijuButton;
        private System.Windows.Forms.TextBox brojKarticeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vozackaDozvolaTextBox;
        private System.Windows.Forms.TextBox oibTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label SviPodaci;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label9;
    }
}