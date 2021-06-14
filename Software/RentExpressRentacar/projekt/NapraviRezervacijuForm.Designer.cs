
namespace projekt
{
    partial class NapraviRezervacijuForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gotovinaRadio = new System.Windows.Forms.RadioButton();
            this.karticaRadio = new System.Windows.Forms.RadioButton();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.ureduButton = new System.Windows.Forms.Button();
            this.lokacijaComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kalendarPruzimanje = new System.Windows.Forms.DateTimePicker();
            this.kalendarVracanje = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gotovinaRadio);
            this.groupBox1.Controls.Add(this.karticaRadio);
            this.groupBox1.Location = new System.Drawing.Point(23, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 64);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Način plaćanja:";
            // 
            // gotovinaRadio
            // 
            this.gotovinaRadio.AutoSize = true;
            this.gotovinaRadio.Location = new System.Drawing.Point(147, 28);
            this.gotovinaRadio.Name = "gotovinaRadio";
            this.gotovinaRadio.Size = new System.Drawing.Size(68, 17);
            this.gotovinaRadio.TabIndex = 1;
            this.gotovinaRadio.TabStop = true;
            this.gotovinaRadio.Text = "Gotovina";
            this.gotovinaRadio.UseVisualStyleBackColor = true;
            // 
            // karticaRadio
            // 
            this.karticaRadio.AutoSize = true;
            this.karticaRadio.Location = new System.Drawing.Point(20, 28);
            this.karticaRadio.Name = "karticaRadio";
            this.karticaRadio.Size = new System.Drawing.Size(58, 17);
            this.karticaRadio.TabIndex = 0;
            this.karticaRadio.TabStop = true;
            this.karticaRadio.Text = "Kartica";
            this.karticaRadio.UseVisualStyleBackColor = true;
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(202, 195);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 14;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // ureduButton
            // 
            this.ureduButton.Location = new System.Drawing.Point(20, 195);
            this.ureduButton.Name = "ureduButton";
            this.ureduButton.Size = new System.Drawing.Size(75, 23);
            this.ureduButton.TabIndex = 13;
            this.ureduButton.Text = "Uredu";
            this.ureduButton.UseVisualStyleBackColor = true;
            this.ureduButton.Click += new System.EventHandler(this.ureduButton_Click);
            // 
            // lokacijaComboBox
            // 
            this.lokacijaComboBox.FormattingEnabled = true;
            this.lokacijaComboBox.Location = new System.Drawing.Point(124, 61);
            this.lokacijaComboBox.Name = "lokacijaComboBox";
            this.lokacijaComboBox.Size = new System.Drawing.Size(170, 21);
            this.lokacijaComboBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lokacija:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Datum preuzimanja:";
            // 
            // kalendarPruzimanje
            // 
            this.kalendarPruzimanje.Location = new System.Drawing.Point(124, 15);
            this.kalendarPruzimanje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kalendarPruzimanje.Name = "kalendarPruzimanje";
            this.kalendarPruzimanje.Size = new System.Drawing.Size(137, 20);
            this.kalendarPruzimanje.TabIndex = 16;
            // 
            // kalendarVracanje
            // 
            this.kalendarVracanje.Location = new System.Drawing.Point(124, 37);
            this.kalendarVracanje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kalendarVracanje.Name = "kalendarVracanje";
            this.kalendarVracanje.Size = new System.Drawing.Size(137, 20);
            this.kalendarVracanje.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Datum vraćanja:";
            // 
            // NapraviRezervacijuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 239);
            this.Controls.Add(this.kalendarVracanje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kalendarPruzimanje);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.ureduButton);
            this.Controls.Add(this.lokacijaComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NapraviRezervacijuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NAPRAVI REZERVACIJU";
            this.Load += new System.EventHandler(this.NapraviRezervacijuForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton gotovinaRadio;
        private System.Windows.Forms.RadioButton karticaRadio;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button ureduButton;
        private System.Windows.Forms.ComboBox lokacijaComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker kalendarPruzimanje;
        private System.Windows.Forms.DateTimePicker kalendarVracanje;
        private System.Windows.Forms.Label label3;
    }
}