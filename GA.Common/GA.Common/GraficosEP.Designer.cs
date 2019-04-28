namespace GA.Common
{
    partial class GraficosEP
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.FitGen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.FitGen)).BeginInit();
            this.SuspendLayout();
            // 
            // FitGen
            // 
            chartArea1.Name = "ChartArea1";
            this.FitGen.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.FitGen.Legends.Add(legend1);
            this.FitGen.Location = new System.Drawing.Point(39, 24);
            this.FitGen.Name = "FitGen";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.FitGen.Series.Add(series1);
            this.FitGen.Size = new System.Drawing.Size(682, 405);
            this.FitGen.TabIndex = 0;
            this.FitGen.Text = "FitGen";
            title1.Name = "Fitness X Generation";
            title1.Text = "Fitness X Generation";
            this.FitGen.Titles.Add(title1);
            // 
            // GraficosEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FitGen);
            this.Name = "GraficosEP";
            this.Text = "GraficosEP";
            this.Load += new System.EventHandler(this.GraficosEP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FitGen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart FitGen;
    }
}