
namespace projekt
{
    partial class DodajZaposlenikaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moderatorRadio = new System.Windows.Forms.RadioButton();
            this.zaposlenikRadio = new System.Windows.Forms.RadioButton();
            this.adminRadio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trajniRadio = new System.Windows.Forms.RadioButton();
            this.naOgranicenoVrijemeRadio = new System.Windows.Forms.RadioButton();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.muskoRadio = new System.Windows.Forms.RadioButton();
            this.zenskoRadio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.oibTextBox = new System.Windows.Forms.TextBox();
            this.brojTelefonaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upišite ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Upišite prezime:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.moderatorRadio);
            this.groupBox1.Controls.Add(this.zaposlenikRadio);
            this.groupBox1.Controls.Add(this.adminRadio);
            this.groupBox1.Location = new System.Drawing.Point(47, 270);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(211, 117);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odaberite rank:";
            // 
            // moderatorRadio
            // 
            this.moderatorRadio.AutoSize = true;
            this.moderatorRadio.Location = new System.Drawing.Point(44, 52);
            this.moderatorRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moderatorRadio.Name = "moderatorRadio";
            this.moderatorRadio.Size = new System.Drawing.Size(94, 21);
            this.moderatorRadio.TabIndex = 6;
            this.moderatorRadio.TabStop = true;
            this.moderatorRadio.Text = "Moderator";
            this.moderatorRadio.UseVisualStyleBackColor = true;
            // 
            // zaposlenikRadio
            // 
            this.zaposlenikRadio.AutoSize = true;
            this.zaposlenikRadio.Location = new System.Drawing.Point(44, 80);
            this.zaposlenikRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zaposlenikRadio.Name = "zaposlenikRadio";
            this.zaposlenikRadio.Size = new System.Drawing.Size(98, 21);
            this.zaposlenikRadio.TabIndex = 5;
            this.zaposlenikRadio.TabStop = true;
            this.zaposlenikRadio.Text = "Zaposlenik";
            this.zaposlenikRadio.UseVisualStyleBackColor = true;
            // 
            // adminRadio
            // 
            this.adminRadio.AutoSize = true;
            this.adminRadio.Location = new System.Drawing.Point(44, 23);
            this.adminRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminRadio.Name = "adminRadio";
            this.adminRadio.Size = new System.Drawing.Size(112, 21);
            this.adminRadio.TabIndex = 4;
            this.adminRadio.TabStop = true;
            this.adminRadio.Text = "Administrator";
            this.adminRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trajniRadio);
            this.groupBox2.Controls.Add(this.naOgranicenoVrijemeRadio);
            this.groupBox2.Location = new System.Drawing.Point(47, 394);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(225, 87);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odaberite ugovor zaposlenika:";
            // 
            // trajniRadio
            // 
            this.trajniRadio.AutoSize = true;
            this.trajniRadio.Location = new System.Drawing.Point(27, 52);
            this.trajniRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trajniRadio.Name = "trajniRadio";
            this.trajniRadio.Size = new System.Drawing.Size(65, 21);
            this.trajniRadio.TabIndex = 1;
            this.trajniRadio.TabStop = true;
            this.trajniRadio.Text = "Trajni";
            this.trajniRadio.UseVisualStyleBackColor = true;
            // 
            // naOgranicenoVrijemeRadio
            // 
            this.naOgranicenoVrijemeRadio.AutoSize = true;
            this.naOgranicenoVrijemeRadio.Location = new System.Drawing.Point(27, 23);
            this.naOgranicenoVrijemeRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.naOgranicenoVrijemeRadio.Name = "naOgranicenoVrijemeRadio";
            this.naOgranicenoVrijemeRadio.Size = new System.Drawing.Size(171, 21);
            this.naOgranicenoVrijemeRadio.TabIndex = 0;
            this.naOgranicenoVrijemeRadio.TabStop = true;
            this.naOgranicenoVrijemeRadio.Text = "Na ograničeno vrijeme";
            this.naOgranicenoVrijemeRadio.UseVisualStyleBackColor = true;
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(159, 11);
            this.imeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(132, 22);
            this.imeTextBox.TabIndex = 8;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Location = new System.Drawing.Point(159, 52);
            this.prezimeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(132, 22);
            this.prezimeTextBox.TabIndex = 9;
            // 
            // muskoRadio
            // 
            this.muskoRadio.AutoSize = true;
            this.muskoRadio.Location = new System.Drawing.Point(19, 23);
            this.muskoRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.muskoRadio.Name = "muskoRadio";
            this.muskoRadio.Size = new System.Drawing.Size(70, 21);
            this.muskoRadio.TabIndex = 7;
            this.muskoRadio.TabStop = true;
            this.muskoRadio.Text = "Muško";
            this.muskoRadio.UseVisualStyleBackColor = true;
            // 
            // zenskoRadio
            // 
            this.zenskoRadio.AutoSize = true;
            this.zenskoRadio.Location = new System.Drawing.Point(19, 52);
            this.zenskoRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zenskoRadio.Name = "zenskoRadio";
            this.zenskoRadio.Size = new System.Drawing.Size(76, 21);
            this.zenskoRadio.TabIndex = 8;
            this.zenskoRadio.TabStop = true;
            this.zenskoRadio.Text = "Žensko";
            this.zenskoRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.muskoRadio);
            this.groupBox3.Controls.Add(this.zenskoRadio);
            this.groupBox3.Location = new System.Drawing.Point(47, 172);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(192, 90);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Odaberite spol:";
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(47, 489);
            this.dodajButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(100, 28);
            this.dodajButton.TabIndex = 11;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(157, 489);
            this.odustaniButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(100, 28);
            this.odustaniButton.TabIndex = 12;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Upišite OIB:";
            // 
            // oibTextBox
            // 
            this.oibTextBox.Location = new System.Drawing.Point(159, 91);
            this.oibTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.oibTextBox.Name = "oibTextBox";
            this.oibTextBox.Size = new System.Drawing.Size(132, 22);
            this.oibTextBox.TabIndex = 14;
            // 
            // brojTelefonaTextBox
            // 
            this.brojTelefonaTextBox.Location = new System.Drawing.Point(159, 128);
            this.brojTelefonaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brojTelefonaTextBox.Name = "brojTelefonaTextBox";
            this.brojTelefonaTextBox.Size = new System.Drawing.Size(132, 22);
            this.brojTelefonaTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Broj telefona:";
            // 
            // DodajZaposlenikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 542);
            this.Controls.Add(this.brojTelefonaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oibTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DodajZaposlenikaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DODAJ ZAPOSLENIKA";
            this.Load += new System.EventHandler(this.DodajZaposlenikaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton moderatorRadio;
        private System.Windows.Forms.RadioButton zaposlenikRadio;
        private System.Windows.Forms.RadioButton adminRadio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton trajniRadio;
        private System.Windows.Forms.RadioButton naOgranicenoVrijemeRadio;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.RadioButton muskoRadio;
        private System.Windows.Forms.RadioButton zenskoRadio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oibTextBox;
        private System.Windows.Forms.TextBox brojTelefonaTextBox;
        private System.Windows.Forms.Label label4;
    }
}