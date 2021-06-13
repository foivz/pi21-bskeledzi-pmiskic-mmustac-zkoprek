
namespace projekt
{
    partial class PregledUpitaForm
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
            this.dgvUpiti = new System.Windows.Forms.DataGridView();
            this.btnOdgovori = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpiti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUpiti
            // 
            this.dgvUpiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpiti.Location = new System.Drawing.Point(12, 12);
            this.dgvUpiti.Name = "dgvUpiti";
            this.dgvUpiti.Size = new System.Drawing.Size(667, 272);
            this.dgvUpiti.TabIndex = 0;
            // 
            // btnOdgovori
            // 
            this.btnOdgovori.Location = new System.Drawing.Point(12, 303);
            this.btnOdgovori.Name = "btnOdgovori";
            this.btnOdgovori.Size = new System.Drawing.Size(115, 29);
            this.btnOdgovori.TabIndex = 1;
            this.btnOdgovori.Text = "Odgovori";
            this.btnOdgovori.UseVisualStyleBackColor = true;
            this.btnOdgovori.Click += new System.EventHandler(this.btnOdgovori_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(564, 303);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(115, 29);
            this.btnOdustani.TabIndex = 2;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // PregledUpitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 344);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnOdgovori);
            this.Controls.Add(this.dgvUpiti);
            this.Name = "PregledUpitaForm";
            this.Text = "PregledUpitaForm";
            this.Load += new System.EventHandler(this.PregledUpitaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpiti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpiti;
        private System.Windows.Forms.Button btnOdgovori;
        private System.Windows.Forms.Button btnOdustani;
    }
}