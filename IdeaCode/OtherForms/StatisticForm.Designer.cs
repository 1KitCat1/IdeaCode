
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCountProblemsByComplexity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.chartUsersByRating = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartBySolved = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chartByCompilers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountProblemsByComplexity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsersByRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBySolved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartByCompilers)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCountProblemsByComplexity
            // 
            this.chartCountProblemsByComplexity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.chartCountProblemsByComplexity.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(140)))), ((int)(((byte)(235)))));
            chartArea5.Name = "ChartArea1";
            this.chartCountProblemsByComplexity.ChartAreas.Add(chartArea5);
            legend5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend5.IsTextAutoFit = false;
            legend5.Name = "Legend1";
            this.chartCountProblemsByComplexity.Legends.Add(legend5);
            this.chartCountProblemsByComplexity.Location = new System.Drawing.Point(113, 80);
            this.chartCountProblemsByComplexity.Name = "chartCountProblemsByComplexity";
            this.chartCountProblemsByComplexity.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.LabelForeColor = System.Drawing.Color.Transparent;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartCountProblemsByComplexity.Series.Add(series5);
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
            // chartUsersByRating
            // 
            this.chartUsersByRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.chartUsersByRating.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(140)))), ((int)(((byte)(235)))));
            chartArea6.Name = "ChartArea1";
            this.chartUsersByRating.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend6.IsTextAutoFit = false;
            legend6.Name = "Legend1";
            this.chartUsersByRating.Legends.Add(legend6);
            this.chartUsersByRating.Location = new System.Drawing.Point(113, 477);
            this.chartUsersByRating.Name = "chartUsersByRating";
            this.chartUsersByRating.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series6.LabelForeColor = System.Drawing.Color.Transparent;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartUsersByRating.Series.Add(series6);
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
            chartArea7.Name = "ChartArea1";
            this.chartBySolved.ChartAreas.Add(chartArea7);
            legend7.Enabled = false;
            legend7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend7.IsTextAutoFit = false;
            legend7.Name = "Legend1";
            this.chartBySolved.Legends.Add(legend7);
            this.chartBySolved.Location = new System.Drawing.Point(113, 904);
            this.chartBySolved.Name = "chartBySolved";
            this.chartBySolved.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series7.ChartArea = "ChartArea1";
            series7.LabelForeColor = System.Drawing.Color.Transparent;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartBySolved.Series.Add(series7);
            this.chartBySolved.Size = new System.Drawing.Size(846, 292);
            this.chartBySolved.TabIndex = 5;
            this.chartBySolved.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label5.Location = new System.Drawing.Point(147, 1269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Submissions by compilers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.label6.Location = new System.Drawing.Point(93, 1657);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // chartByCompilers
            // 
            this.chartByCompilers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.chartByCompilers.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(140)))), ((int)(((byte)(235)))));
            chartArea8.Name = "ChartArea1";
            this.chartByCompilers.ChartAreas.Add(chartArea8);
            legend8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend8.IsTextAutoFit = false;
            legend8.Name = "Legend1";
            this.chartByCompilers.Legends.Add(legend8);
            this.chartByCompilers.Location = new System.Drawing.Point(113, 1327);
            this.chartByCompilers.Name = "chartByCompilers";
            this.chartByCompilers.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.LabelForeColor = System.Drawing.Color.Transparent;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartByCompilers.Series.Add(series8);
            this.chartByCompilers.Size = new System.Drawing.Size(600, 318);
            this.chartByCompilers.TabIndex = 10;
            this.chartByCompilers.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panel1.Location = new System.Drawing.Point(142, 917);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 241);
            this.panel1.TabIndex = 11;
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1156, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartByCompilers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chartBySolved);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartUsersByRating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartCountProblemsByComplexity);
            this.Name = "StatisticForm";
            this.Text = "Statistic";
            ((System.ComponentModel.ISupportInitialize)(this.chartCountProblemsByComplexity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsersByRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBySolved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartByCompilers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCountProblemsByComplexity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsersByRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBySolved;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartByCompilers;
        private System.Windows.Forms.Panel panel1;
    }
}