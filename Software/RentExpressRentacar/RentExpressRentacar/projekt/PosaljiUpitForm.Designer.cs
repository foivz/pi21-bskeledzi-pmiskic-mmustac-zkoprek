
namespace projekt
{
    partial class PosaljiUpitForm
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
            this.odustaniButton = new System.Windows.Forms.Button();
            this.posaljiButton = new System.Windows.Forms.Button();
            this.opisRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.predmetTextBox = new System.Windows.Forms.TextBox();
            this.predmetLabel = new System.Windows.Forms.Label();
            this.cmbPoduzece = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(269, 269);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 15;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // posaljiButton
            // 
            this.posaljiButton.Location = new System.Drawing.Point(27, 269);
            this.posaljiButton.Name = "posaljiButton";
            this.posaljiButton.Size = new System.Drawing.Size(75, 23);
            this.posaljiButton.TabIndex = 14;
            this.posaljiButton.Text = "Pošalji";
            this.posaljiButton.UseVisualStyleBackColor = true;
            this.posaljiButton.Click += new System.EventHandler(this.posaljiButton_Click);
            // 
            // opisRichTextBox
            // 
            this.opisRichTextBox.Location = new System.Drawing.Point(27, 153);
            this.opisRichTextBox.Name = "opisRichTextBox";
            this.opisRichTextBox.Size = new System.Drawing.Size(317, 96);
            this.opisRichTextBox.TabIndex = 13;
            this.opisRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Opis:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(91, 90);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(253, 20);
            this.emailTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Vaš e-mail:";
            // 
            // predmetTextBox
            // 
            this.predmetTextBox.Location = new System.Drawing.Point(92, 56);
            this.predmetTextBox.Name = "predmetTextBox";
            this.predmetTextBox.Size = new System.Drawing.Size(253, 20);
            this.predmetTextBox.TabIndex = 9;
            // 
            // predmetLabel
            // 
            this.predmetLabel.AutoSize = true;
            this.predmetLabel.Location = new System.Drawing.Point(25, 58);
            this.predmetLabel.Name = "predmetLabel";
            this.predmetLabel.Size = new System.Drawing.Size(49, 13);
            this.predmetLabel.TabIndex = 8;
            this.predmetLabel.Text = "Predmet:";
            // 
            // cmbPoduzece
            // 
            this.cmbPoduzece.FormattingEnabled = true;
            this.cmbPoduzece.Location = new System.Drawing.Point(28, 12);
            this.cmbPoduzece.Name = "cmbPoduzece";
            this.cmbPoduzece.Size = new System.Drawing.Size(121, 21);
            this.cmbPoduzece.TabIndex = 16;
            // 
            // PosaljiUpitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 304);
            this.Controls.Add(this.cmbPoduzece);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.posaljiButton);
            this.Controls.Add(this.opisRichTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.predmetTextBox);
            this.Controls.Add(this.predmetLabel);
            this.Name = "PosaljiUpitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POŠALJI UPIT";
            this.Load += new System.EventHandler(this.PosaljiUpitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button posaljiButton;
        private System.Windows.Forms.RichTextBox opisRichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox predmetTextBox;
        private System.Windows.Forms.Label predmetLabel;
        private System.Windows.Forms.ComboBox cmbPoduzece;
    }
}
