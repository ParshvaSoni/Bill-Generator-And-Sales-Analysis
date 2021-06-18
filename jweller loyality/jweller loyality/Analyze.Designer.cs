namespace jweller_loyality
{
    partial class Analyze
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analyze));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.plot = new System.Windows.Forms.Button();
            this.plot1 = new System.Windows.Forms.Button();
            this.selecta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(223, 28);
            this.chart1.Margin = new System.Windows.Forms.Padding(6);
            this.chart1.Name = "chart1";
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "PIN";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(401, 213);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // plot
            // 
            this.plot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plot.Location = new System.Drawing.Point(812, 655);
            this.plot.Margin = new System.Windows.Forms.Padding(6);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(274, 48);
            this.plot.TabIndex = 1;
            this.plot.Text = "Plot Chart";
            this.plot.UseVisualStyleBackColor = true;
            // 
            // plot1
            // 
            this.plot1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plot1.Location = new System.Drawing.Point(342, 250);
            this.plot1.Name = "plot1";
            this.plot1.Size = new System.Drawing.Size(107, 28);
            this.plot1.TabIndex = 2;
            this.plot1.Text = "Plot Chart";
            this.plot1.UseVisualStyleBackColor = true;
            this.plot1.Click += new System.EventHandler(this.plot1_Click);
            // 
            // selecta
            // 
            this.selecta.FormattingEnabled = true;
            this.selecta.Items.AddRange(new object[] {
            "Area Analysis"});
            this.selecta.Location = new System.Drawing.Point(33, 120);
            this.selecta.Name = "selecta";
            this.selecta.Size = new System.Drawing.Size(172, 32);
            this.selecta.TabIndex = 3;
            this.selecta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Analyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 349);
            this.Controls.Add(this.selecta);
            this.Controls.Add(this.plot1);
            this.Controls.Add(this.plot);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Analyze";
            this.Text = "Analyze";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button plot;
        private System.Windows.Forms.Button plot1;
        private System.Windows.Forms.ComboBox selecta;
    }
}