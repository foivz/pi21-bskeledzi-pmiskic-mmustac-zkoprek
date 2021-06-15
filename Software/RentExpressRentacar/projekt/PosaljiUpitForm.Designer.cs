
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
            this.SuspendLayout();
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(369, 311);
            this.odustaniButton.Margin = new System.Windows.Forms.Padding(4);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(100, 28);
            this.odustaniButton.TabIndex = 15;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // posaljiButton
            // 
            this.posaljiButton.Location = new System.Drawing.Point(47, 311);
            this.posaljiButton.Margin = new System.Windows.Forms.Padding(4);
            this.posaljiButton.Name = "posaljiButton";
            this.posaljiButton.Size = new System.Drawing.Size(100, 28);
            this.posaljiButton.TabIndex = 14;
            this.posaljiButton.Text = "Pošalji";
            this.posaljiButton.UseVisualStyleBackColor = true;
            this.posaljiButton.Click += new System.EventHandler(this.posaljiButton_Click);
            // 
            // opisRichTextBox
            // 
            this.opisRichTextBox.Location = new System.Drawing.Point(47, 169);
            this.opisRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.opisRichTextBox.Name = "opisRichTextBox";
            this.opisRichTextBox.Size = new System.Drawing.Size(421, 117);
            this.opisRichTextBox.TabIndex = 13;
            this.opisRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Opis:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(132, 91);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(336, 22);
            this.emailTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Vaš e-mail:";
            // 
            // predmetTextBox
            // 
            this.predmetTextBox.Location = new System.Drawing.Point(133, 49);
            this.predmetTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.predmetTextBox.Name = "predmetTextBox";
            this.predmetTextBox.Size = new System.Drawing.Size(336, 22);
            this.predmetTextBox.TabIndex = 9;
            // 
            // predmetLabel
            // 
            this.predmetLabel.AutoSize = true;
            this.predmetLabel.Location = new System.Drawing.Point(44, 52);
            this.predmetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.predmetLabel.Name = "predmetLabel";
            this.predmetLabel.Size = new System.Drawing.Size(65, 17);
            this.predmetLabel.TabIndex = 8;
            this.predmetLabel.Text = "Predmet:";
            // 
            // PosaljiUpitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 358);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.posaljiButton);
            this.Controls.Add(this.opisRichTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.predmetTextBox);
            this.Controls.Add(this.predmetLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}