
namespace projekt
{
    partial class DodajLokacijuForm
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
            this.gradTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime grada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresa:";
            // 
            // gradTextBox
            // 
            this.gradTextBox.Location = new System.Drawing.Point(94, 12);
            this.gradTextBox.Name = "gradTextBox";
            this.gradTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradTextBox.TabIndex = 2;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.Location = new System.Drawing.Point(94, 46);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(100, 20);
            this.adresaTextBox.TabIndex = 3;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(34, 85);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(75, 23);
            this.dodajButton.TabIndex = 4;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(119, 85);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 5;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // DodajLokacijuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 122);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(this.gradTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajLokacijuForm";
            this.Text = "DODAJ LOKACIJU";
            this.Load += new System.EventHandler(this.DodajLokacijuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gradTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button odustaniButton;
    }
}