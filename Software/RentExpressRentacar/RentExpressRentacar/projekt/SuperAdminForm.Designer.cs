
namespace projekt
{
    partial class SuperAdminForm
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
            this.btnSpremiPoduzece = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbImePoduzeca = new System.Windows.Forms.TextBox();
            this.cmbPoduzeca = new System.Windows.Forms.ComboBox();
            this.cmbZaposlenici = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodijeliAdmina = new System.Windows.Forms.Button();
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSpremiPoduzece);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbImePoduzeca);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kreiraj novo poduzeće";
            // 
            // btnSpremiPoduzece
            // 
            this.btnSpremiPoduzece.Location = new System.Drawing.Point(6, 102);
            this.btnSpremiPoduzece.Name = "btnSpremiPoduzece";
            this.btnSpremiPoduzece.Size = new System.Drawing.Size(75, 23);
            this.btnSpremiPoduzece.TabIndex = 2;
            this.btnSpremiPoduzece.Text = "Spremi";
            this.btnSpremiPoduzece.UseVisualStyleBackColor = true;
            this.btnSpremiPoduzece.Click += new System.EventHandler(this.btnSpremiPoduzece_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv Poduzeća:";
            // 
            // tbImePoduzeca
            // 
            this.tbImePoduzeca.Location = new System.Drawing.Point(6, 32);
            this.tbImePoduzeca.Name = "tbImePoduzeca";
            this.tbImePoduzeca.Size = new System.Drawing.Size(144, 20);
            this.tbImePoduzeca.TabIndex = 0;
            // 
            // cmbPoduzeca
            // 
            this.cmbPoduzeca.FormattingEnabled = true;
            this.cmbPoduzeca.Location = new System.Drawing.Point(12, 186);
            this.cmbPoduzeca.Name = "cmbPoduzeca";
            this.cmbPoduzeca.Size = new System.Drawing.Size(121, 21);
            this.cmbPoduzeca.TabIndex = 1;
            // 
            // cmbZaposlenici
            // 
            this.cmbZaposlenici.FormattingEnabled = true;
            this.cmbZaposlenici.Location = new System.Drawing.Point(156, 186);
            this.cmbZaposlenici.Name = "cmbZaposlenici";
            this.cmbZaposlenici.Size = new System.Drawing.Size(121, 21);
            this.cmbZaposlenici.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odaberi poduzeće:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Odaberi zaposlenika";
            // 
            // btnDodijeliAdmina
            // 
            this.btnDodijeliAdmina.Location = new System.Drawing.Point(12, 229);
            this.btnDodijeliAdmina.Name = "btnDodijeliAdmina";
            this.btnDodijeliAdmina.Size = new System.Drawing.Size(95, 23);
            this.btnDodijeliAdmina.TabIndex = 3;
            this.btnDodijeliAdmina.Text = "Dodijeli admina";
            this.btnDodijeliAdmina.UseVisualStyleBackColor = true;
            this.btnDodijeliAdmina.Click += new System.EventHandler(this.btnDodijeliAdmina_Click);
            // 
            // btnDodajZaposlenika
            // 
            this.btnDodajZaposlenika.Location = new System.Drawing.Point(156, 229);
            this.btnDodajZaposlenika.Name = "btnDodajZaposlenika";
            this.btnDodajZaposlenika.Size = new System.Drawing.Size(121, 23);
            this.btnDodajZaposlenika.TabIndex = 5;
            this.btnDodajZaposlenika.Text = "Dodaj zaposlenika";
            this.btnDodajZaposlenika.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenika.Click += new System.EventHandler(this.btnDodajZaposlenika_Click);
            // 
            // SuperAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 283);
            this.Controls.Add(this.btnDodajZaposlenika);
            this.Controls.Add(this.btnDodijeliAdmina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbZaposlenici);
            this.Controls.Add(this.cmbPoduzeca);
            this.Controls.Add(this.groupBox1);
            this.Name = "SuperAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperAdminForm";
            this.Load += new System.EventHandler(this.SuperAdminForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSpremiPoduzece;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbImePoduzeca;
        private System.Windows.Forms.ComboBox cmbZaposlenici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodijeliAdmina;
        private System.Windows.Forms.ComboBox cmbPoduzeca;
        private System.Windows.Forms.Button btnDodajZaposlenika;
    }
}