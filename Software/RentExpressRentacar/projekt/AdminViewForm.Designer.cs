
namespace projekt
{
    partial class AdminViewForm
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
            this.dodajButton = new System.Windows.Forms.Button();
            this.vidiLokacijeButton = new System.Windows.Forms.Button();
            this.vidiAutomobileButton = new System.Windows.Forms.Button();
            this.vidiOsiguranjaButton = new System.Windows.Forms.Button();
            this.statistikaButton = new System.Windows.Forms.Button();
            this.izmijeniButton = new System.Windows.Forms.Button();
            this.glavniLabel = new System.Windows.Forms.Label();
            this.glavniDataGrid = new System.Windows.Forms.DataGridView();
            this.vidiZaposlenikeButton = new System.Windows.Forms.Button();
            this.izbrisiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.glavniDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(697, 347);
            this.dodajButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(113, 44);
            this.dodajButton.TabIndex = 2;
            this.dodajButton.Text = "Dodaj zaposlenika";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // vidiLokacijeButton
            // 
            this.vidiLokacijeButton.Location = new System.Drawing.Point(245, 347);
            this.vidiLokacijeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vidiLokacijeButton.Name = "vidiLokacijeButton";
            this.vidiLokacijeButton.Size = new System.Drawing.Size(103, 44);
            this.vidiLokacijeButton.TabIndex = 4;
            this.vidiLokacijeButton.Text = "Vidi lokacije";
            this.vidiLokacijeButton.UseVisualStyleBackColor = true;
            this.vidiLokacijeButton.Click += new System.EventHandler(this.vidiLokacijeButton_Click);
            // 
            // vidiAutomobileButton
            // 
            this.vidiAutomobileButton.Location = new System.Drawing.Point(356, 347);
            this.vidiAutomobileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vidiAutomobileButton.Name = "vidiAutomobileButton";
            this.vidiAutomobileButton.Size = new System.Drawing.Size(101, 44);
            this.vidiAutomobileButton.TabIndex = 5;
            this.vidiAutomobileButton.Text = "Vidi automobile";
            this.vidiAutomobileButton.UseVisualStyleBackColor = true;
            this.vidiAutomobileButton.Click += new System.EventHandler(this.vidiAutomobilButton_Click);
            // 
            // vidiOsiguranjaButton
            // 
            this.vidiOsiguranjaButton.Location = new System.Drawing.Point(131, 347);
            this.vidiOsiguranjaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vidiOsiguranjaButton.Name = "vidiOsiguranjaButton";
            this.vidiOsiguranjaButton.Size = new System.Drawing.Size(107, 44);
            this.vidiOsiguranjaButton.TabIndex = 6;
            this.vidiOsiguranjaButton.Text = "Vidi osiguranja";
            this.vidiOsiguranjaButton.UseVisualStyleBackColor = true;
            this.vidiOsiguranjaButton.Click += new System.EventHandler(this.vidiOsiguranjaButton_Click);
            // 
            // statistikaButton
            // 
            this.statistikaButton.Location = new System.Drawing.Point(583, 347);
            this.statistikaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statistikaButton.Name = "statistikaButton";
            this.statistikaButton.Size = new System.Drawing.Size(107, 44);
            this.statistikaButton.TabIndex = 7;
            this.statistikaButton.Text = "Pregled statistike";
            this.statistikaButton.UseVisualStyleBackColor = true;
            this.statistikaButton.Click += new System.EventHandler(this.statistikaButton_Click);
            // 
            // izmijeniButton
            // 
            this.izmijeniButton.Location = new System.Drawing.Point(819, 347);
            this.izmijeniButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.izmijeniButton.Name = "izmijeniButton";
            this.izmijeniButton.Size = new System.Drawing.Size(112, 44);
            this.izmijeniButton.TabIndex = 3;
            this.izmijeniButton.Text = "Izmijeni zaposlenika";
            this.izmijeniButton.UseVisualStyleBackColor = true;
            this.izmijeniButton.Click += new System.EventHandler(this.izmijeniButton_Click);
            // 
            // glavniLabel
            // 
            this.glavniLabel.AutoSize = true;
            this.glavniLabel.Location = new System.Drawing.Point(16, 11);
            this.glavniLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.glavniLabel.Name = "glavniLabel";
            this.glavniLabel.Size = new System.Drawing.Size(126, 17);
            this.glavniLabel.TabIndex = 0;
            this.glavniLabel.Text = "Popis zaposlenika:";
            // 
            // glavniDataGrid
            // 
            this.glavniDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.glavniDataGrid.Location = new System.Drawing.Point(16, 31);
            this.glavniDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.glavniDataGrid.Name = "glavniDataGrid";
            this.glavniDataGrid.RowHeadersWidth = 51;
            this.glavniDataGrid.Size = new System.Drawing.Size(1035, 309);
            this.glavniDataGrid.TabIndex = 1;
            // 
            // vidiZaposlenikeButton
            // 
            this.vidiZaposlenikeButton.Location = new System.Drawing.Point(21, 347);
            this.vidiZaposlenikeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vidiZaposlenikeButton.Name = "vidiZaposlenikeButton";
            this.vidiZaposlenikeButton.Size = new System.Drawing.Size(101, 44);
            this.vidiZaposlenikeButton.TabIndex = 8;
            this.vidiZaposlenikeButton.Text = "Vidi zaposlenike";
            this.vidiZaposlenikeButton.UseVisualStyleBackColor = true;
            this.vidiZaposlenikeButton.Click += new System.EventHandler(this.vidiZaposlenikeButton_Click);
            // 
            // izbrisiButton
            // 
            this.izbrisiButton.Location = new System.Drawing.Point(939, 347);
            this.izbrisiButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.izbrisiButton.Name = "izbrisiButton";
            this.izbrisiButton.Size = new System.Drawing.Size(112, 44);
            this.izbrisiButton.TabIndex = 9;
            this.izbrisiButton.Text = "Izbriši zaposlenika";
            this.izbrisiButton.UseVisualStyleBackColor = true;
            this.izbrisiButton.Click += new System.EventHandler(this.izbrisiButton_Click);
            // 
            // AdminViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 402);
            this.Controls.Add(this.izbrisiButton);
            this.Controls.Add(this.vidiZaposlenikeButton);
            this.Controls.Add(this.statistikaButton);
            this.Controls.Add(this.vidiOsiguranjaButton);
            this.Controls.Add(this.vidiAutomobileButton);
            this.Controls.Add(this.vidiLokacijeButton);
            this.Controls.Add(this.izmijeniButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.glavniDataGrid);
            this.Controls.Add(this.glavniLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administratorska forma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AdminViewForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.glavniDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button vidiLokacijeButton;
        private System.Windows.Forms.Button vidiAutomobileButton;
        private System.Windows.Forms.Button vidiOsiguranjaButton;
        private System.Windows.Forms.Button statistikaButton;
        private System.Windows.Forms.Button izmijeniButton;
        private System.Windows.Forms.Label glavniLabel;
        private System.Windows.Forms.DataGridView glavniDataGrid;
        private System.Windows.Forms.Button vidiZaposlenikeButton;
        private System.Windows.Forms.Button izbrisiButton;
    }
}

