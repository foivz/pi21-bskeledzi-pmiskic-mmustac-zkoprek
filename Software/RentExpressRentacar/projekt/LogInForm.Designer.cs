
namespace projekt
{
    partial class LogInForm
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
            this.adminButton = new System.Windows.Forms.Button();
            this.kupacButton = new System.Windows.Forms.Button();
            this.korisnickoImeTextBox = new System.Windows.Forms.TextBox();
            this.lozinkaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.upitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime";
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(58, 100);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(75, 23);
            this.adminButton.TabIndex = 1;
            this.adminButton.Text = "Prijavi se";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // kupacButton
            // 
            this.kupacButton.Location = new System.Drawing.Point(58, 129);
            this.kupacButton.Name = "kupacButton";
            this.kupacButton.Size = new System.Drawing.Size(75, 23);
            this.kupacButton.TabIndex = 2;
            this.kupacButton.Text = "Gost";
            this.kupacButton.UseVisualStyleBackColor = true;
            this.kupacButton.Click += new System.EventHandler(this.kupacButton_Click);
            // 
            // korisnickoImeTextBox
            // 
            this.korisnickoImeTextBox.Location = new System.Drawing.Point(50, 25);
            this.korisnickoImeTextBox.Name = "korisnickoImeTextBox";
            this.korisnickoImeTextBox.Size = new System.Drawing.Size(100, 20);
            this.korisnickoImeTextBox.TabIndex = 3;
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.Location = new System.Drawing.Point(50, 65);
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.Size = new System.Drawing.Size(100, 20);
            this.lozinkaTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lozinka";
            // 
            // upitButton
            // 
            this.upitButton.Location = new System.Drawing.Point(58, 158);
            this.upitButton.Name = "upitButton";
            this.upitButton.Size = new System.Drawing.Size(75, 23);
            this.upitButton.TabIndex = 6;
            this.upitButton.Text = "Pošalji upit";
            this.upitButton.UseVisualStyleBackColor = true;
            this.upitButton.Click += new System.EventHandler(this.upitButton_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 203);
            this.Controls.Add(this.upitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lozinkaTextBox);
            this.Controls.Add(this.korisnickoImeTextBox);
            this.Controls.Add(this.kupacButton);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.label1);
            this.Name = "LogInForm";
            this.Text = "PRIJAVI SE";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button kupacButton;
        private System.Windows.Forms.TextBox korisnickoImeTextBox;
        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button upitButton;
    }
}