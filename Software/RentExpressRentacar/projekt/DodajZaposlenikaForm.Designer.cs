
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trajniRadio = new System.Windows.Forms.RadioButton();
            this.naOgranicenoVrijemeRadio = new System.Windows.Forms.RadioButton();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.oibTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.korisnickoImeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upišite ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Upišite prezime:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trajniRadio);
            this.groupBox2.Controls.Add(this.naOgranicenoVrijemeRadio);
            this.groupBox2.Location = new System.Drawing.Point(35, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 71);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odaberite ugovor zaposlenika:";
            // 
            // trajniRadio
            // 
            this.trajniRadio.AutoSize = true;
            this.trajniRadio.Location = new System.Drawing.Point(20, 42);
            this.trajniRadio.Name = "trajniRadio";
            this.trajniRadio.Size = new System.Drawing.Size(51, 17);
            this.trajniRadio.TabIndex = 1;
            this.trajniRadio.TabStop = true;
            this.trajniRadio.Text = "Trajni";
            this.trajniRadio.UseVisualStyleBackColor = true;
            // 
            // naOgranicenoVrijemeRadio
            // 
            this.naOgranicenoVrijemeRadio.AutoSize = true;
            this.naOgranicenoVrijemeRadio.Location = new System.Drawing.Point(20, 19);
            this.naOgranicenoVrijemeRadio.Name = "naOgranicenoVrijemeRadio";
            this.naOgranicenoVrijemeRadio.Size = new System.Drawing.Size(131, 17);
            this.naOgranicenoVrijemeRadio.TabIndex = 0;
            this.naOgranicenoVrijemeRadio.TabStop = true;
            this.naOgranicenoVrijemeRadio.Text = "Na ograničeno vrijeme";
            this.naOgranicenoVrijemeRadio.UseVisualStyleBackColor = true;
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(119, 9);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(100, 20);
            this.imeTextBox.TabIndex = 8;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Location = new System.Drawing.Point(119, 42);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.prezimeTextBox.TabIndex = 9;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(35, 218);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(75, 23);
            this.dodajButton.TabIndex = 11;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(118, 218);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 12;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Upišite OIB:";
            // 
            // oibTextBox
            // 
            this.oibTextBox.Location = new System.Drawing.Point(119, 74);
            this.oibTextBox.Name = "oibTextBox";
            this.oibTextBox.Size = new System.Drawing.Size(100, 20);
            this.oibTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Korisničko ime:";
            // 
            // korisnickoImeTextBox
            // 
            this.korisnickoImeTextBox.Location = new System.Drawing.Point(119, 106);
            this.korisnickoImeTextBox.Name = "korisnickoImeTextBox";
            this.korisnickoImeTextBox.Size = new System.Drawing.Size(100, 20);
            this.korisnickoImeTextBox.TabIndex = 16;
            // 
            // DodajZaposlenikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 254);
            this.Controls.Add(this.korisnickoImeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oibTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajZaposlenikaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DODAJ ZAPOSLENIKA";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton trajniRadio;
        private System.Windows.Forms.RadioButton naOgranicenoVrijemeRadio;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oibTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox korisnickoImeTextBox;
    }
}