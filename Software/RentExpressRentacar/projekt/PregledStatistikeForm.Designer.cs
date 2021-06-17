
namespace projekt
{
    partial class PregledStatistikeForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartStatistika = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnIzvezi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistika)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStatistika
            // 
            chartArea2.Name = "Marka";
            this.chartStatistika.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStatistika.Legends.Add(legend2);
            this.chartStatistika.Location = new System.Drawing.Point(38, 29);
            this.chartStatistika.Name = "chartStatistika";
            series2.ChartArea = "Marka";
            series2.Legend = "Legend1";
            series2.Name = "Marka";
            this.chartStatistika.Series.Add(series2);
            this.chartStatistika.Size = new System.Drawing.Size(413, 300);
            this.chartStatistika.TabIndex = 0;
            this.chartStatistika.Text = "chart1";
            // 
            // btnIzvezi
            // 
            this.btnIzvezi.Location = new System.Drawing.Point(376, 349);
            this.btnIzvezi.Name = "btnIzvezi";
            this.btnIzvezi.Size = new System.Drawing.Size(75, 23);
            this.btnIzvezi.TabIndex = 1;
            this.btnIzvezi.Text = "Izvezi u PDF";
            this.btnIzvezi.UseVisualStyleBackColor = true;
            // 
            // PregledStatistikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 417);
            this.Controls.Add(this.btnIzvezi);
            this.Controls.Add(this.chartStatistika);
            this.Name = "PregledStatistikeForm";
            this.Text = "PregledStatistikeForm";
            this.Load += new System.EventHandler(this.PregledStatistikeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistika;
        private System.Windows.Forms.Button btnIzvezi;
    }
}