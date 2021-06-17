
namespace projekt
{
    partial class IznajmiAutomobilForm
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
            this.iznajmiButton = new System.Windows.Forms.Button();
            this.automobilTextBox = new System.Windows.Forms.TextBox();
            this.automobilDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPoduzeca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(473, 247);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 9;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // iznajmiButton
            // 
            this.iznajmiButton.Location = new System.Drawing.Point(21, 247);
            this.iznajmiButton.Name = "iznajmiButton";
            this.iznajmiButton.Size = new System.Drawing.Size(75, 23);
            this.iznajmiButton.TabIndex = 8;
            this.iznajmiButton.Text = "Iznajmi";
            this.iznajmiButton.UseVisualStyleBackColor = true;
            this.iznajmiButton.Click += new System.EventHandler(this.iznajmiButton_Click);
            // 
            // automobilTextBox
            // 
            this.automobilTextBox.Location = new System.Drawing.Point(80, 12);
            this.automobilTextBox.Name = "automobilTextBox";
            this.automobilTextBox.Size = new System.Drawing.Size(196, 20);
            this.automobilTextBox.TabIndex = 7;
            this.automobilTextBox.TextChanged += new System.EventHandler(this.automobilTextBox_TextChanged);
            // 
            // automobilDataGridView
            // 
            this.automobilDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.automobilDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.automobilDataGridView.Location = new System.Drawing.Point(21, 48);
            this.automobilDataGridView.Name = "automobilDataGridView";
            this.automobilDataGridView.RowHeadersWidth = 51;
            this.automobilDataGridView.Size = new System.Drawing.Size(625, 182);
            this.automobilDataGridView.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Automobil:";
            // 
            // cmbPoduzeca
            // 
            this.cmbPoduzeca.FormattingEnabled = true;
            this.cmbPoduzeca.Location = new System.Drawing.Point(342, 11);
            this.cmbPoduzeca.Name = "cmbPoduzeca";
            this.cmbPoduzeca.Size = new System.Drawing.Size(304, 21);
            this.cmbPoduzeca.TabIndex = 10;
            this.cmbPoduzeca.SelectedIndexChanged += new System.EventHandler(this.cmbPoduzeca_SelectedIndexChanged);
            // 
            // IznajmiAutomobilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 285);
            this.Controls.Add(this.cmbPoduzeca);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.iznajmiButton);
            this.Controls.Add(this.automobilTextBox);
            this.Controls.Add(this.automobilDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "IznajmiAutomobilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IZNAJMI AUTOMOBIL";
            this.Load += new System.EventHandler(this.IznajmiAutomobilForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automobilDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button iznajmiButton;
        private System.Windows.Forms.TextBox automobilTextBox;
        private System.Windows.Forms.DataGridView automobilDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPoduzeca;
    }
}