
namespace IdeaCode.OtherForms
{
    partial class StatisticForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCountProblemsByComplexity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartUsersByRating = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartBySolved = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountProblemsByComplexity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsersByRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBySolved)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCountProblemsByComplexity
            // 
            this.chartCountProblemsByComplexity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.chartCountProblemsByComplexity.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(140)))), ((int)(((byte)(235)))));
            chartArea1.Name = "ChartArea1";
            this.chartCountProblemsByComplexity.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartCountProblemsByComplexity.Legends.Add(legend1);
            this.chartCountProblemsByComplexity.Location = new System.Drawing.Point(113, 80);
            this.chartCountProblemsByComplexity.Name = "chartCountProblemsByComplexity";
            this.chartCountProblemsByComplexity.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCountProblemsByComplexity.Series.Add(series1);
            this.chartCountProblemsByComplexity.Size = new System.Drawing.Size(600, 318);
            this.chartCountProblemsByComplexity.TabIndex = 0;
            this.chartCountProblemsByComplexity.Text = "chart1";
            this.chartCountProblemsByComplexity.Click += new System.EventHandler(this.chartCountProblemsByComplexity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(147, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Problems Complexity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label2.Location = new System.Drawing.Point(30, 1219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Problems Complexity";
            // 
            // chartUsersByRating
            // 
            this.chartUsersByRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.chartUsersByRating.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(140)))), ((int)(((byte)(235)))));
            chartArea2.Name = "ChartArea1";
            this.chartUsersByRating.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartUsersByRating.Legends.Add(legend2);
            this.chartUsersByRating.Location = new System.Drawing.Point(113, 477);
            this.chartUsersByRating.Name = "chartUsersByRating";
            this.chartUsersByRating.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.LabelForeColor = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartUsersByRating.Series.Add(series2);
            this.chartUsersByRating.Size = new System.Drawing.Size(600, 318);
            this.chartUsersByRating.TabIndex = 3;
            this.chartUsersByRating.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label3.Location = new System.Drawing.Point(147, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Users by Rating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label4.Location = new System.Drawing.Point(147, 833);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Users by amount of solved tasks";
            // 
            // chartBySolved
            // 
            this.chartBySolved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.chartBySolved.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(140)))), ((int)(((byte)(235)))));
            chartArea3.Name = "ChartArea1";
            this.chartBySolved.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chartBySolved.Legends.Add(legend3);
            this.chartBySolved.Location = new System.Drawing.Point(113, 878);
            this.chartBySolved.Name = "chartBySolved";
            this.chartBySolved.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.LabelForeColor = System.Drawing.Color.Transparent;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartBySolved.Series.Add(series3);
            this.chartBySolved.Size = new System.Drawing.Size(927, 318);
            this.chartBySolved.TabIndex = 5;
            this.chartBySolved.Text = "chart1";
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1156, 538);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chartBySolved);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartUsersByRating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartCountProblemsByComplexity);
            this.Name = "StatisticForm";
            this.Text = "Statistic";
            ((System.ComponentModel.ISupportInitialize)(this.chartCountProblemsByComplexity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsersByRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBySolved)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCountProblemsByComplexity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsersByRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBySolved;
    }
}