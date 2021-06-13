
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
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime grada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresa:";
            // 
            // gradTextBox
            // 
            this.gradTextBox.Location = new System.Drawing.Point(125, 15);
            this.gradTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gradTextBox.Name = "gradTextBox";
            this.gradTextBox.Size = new System.Drawing.Size(132, 22);
            this.gradTextBox.TabIndex = 2;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.Location = new System.Drawing.Point(125, 57);
            this.adresaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(132, 22);
            this.adresaTextBox.TabIndex = 3;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(45, 105);
            this.dodajButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(100, 28);
            this.dodajButton.TabIndex = 4;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(159, 105);
            this.odustaniButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(100, 28);
            this.odustaniButton.TabIndex = 5;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // DodajLokacijuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 150);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(this.gradTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DodajLokacijuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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