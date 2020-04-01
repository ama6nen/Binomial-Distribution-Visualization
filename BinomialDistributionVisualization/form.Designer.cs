namespace BinomialDistributionVisualization
{
    partial class form
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
            this.PlotView = new OxyPlot.WindowsForms.PlotView();
            this.Probability = new System.Windows.Forms.TrackBar();
            this.ProbabilityLabel = new System.Windows.Forms.Label();
            this.ItemsCount = new System.Windows.Forms.NumericUpDown();
            this.CountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Probability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // PlotView
            // 
            this.PlotView.Location = new System.Drawing.Point(12, 100);
            this.PlotView.Name = "PlotView";
            this.PlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.PlotView.Size = new System.Drawing.Size(896, 469);
            this.PlotView.TabIndex = 0;
            this.PlotView.Text = "Plot";
            this.PlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.PlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.PlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Probability
            // 
            this.Probability.Location = new System.Drawing.Point(85, 12);
            this.Probability.Maximum = 10000;
            this.Probability.Name = "Probability";
            this.Probability.Size = new System.Drawing.Size(830, 45);
            this.Probability.TabIndex = 2;
            this.Probability.TickFrequency = 500;
            this.Probability.Value = 5000;
            this.Probability.ValueChanged += new System.EventHandler(this.Probability_ValueChanged);
            // 
            // ProbabilityLabel
            // 
            this.ProbabilityLabel.AutoSize = true;
            this.ProbabilityLabel.Location = new System.Drawing.Point(91, 40);
            this.ProbabilityLabel.Name = "ProbabilityLabel";
            this.ProbabilityLabel.Size = new System.Drawing.Size(102, 17);
            this.ProbabilityLabel.TabIndex = 3;
            this.ProbabilityLabel.Text = "Probability: 50%";
            // 
            // ItemsCount
            // 
            this.ItemsCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemsCount.Location = new System.Drawing.Point(3, 12);
            this.ItemsCount.Maximum = new decimal(new int[] {
            170,
            0,
            0,
            0});
            this.ItemsCount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ItemsCount.Name = "ItemsCount";
            this.ItemsCount.Size = new System.Drawing.Size(63, 25);
            this.ItemsCount.TabIndex = 4;
            this.ItemsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemsCount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ItemsCount.ValueChanged += new System.EventHandler(this.ItemsCount_ValueChanged);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(5, 40);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(61, 17);
            this.CountLabel.TabIndex = 5;
            this.CountLabel.Text = "Count (n)";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 581);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.ItemsCount);
            this.Controls.Add(this.ProbabilityLabel);
            this.Controls.Add(this.Probability);
            this.Controls.Add(this.PlotView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form";
            this.ShowIcon = false;
            this.Text = "Binomial Normal Distribution Visualization";
            this.Load += new System.EventHandler(this.form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Probability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView PlotView;
        private System.Windows.Forms.TrackBar Probability;
        private System.Windows.Forms.Label ProbabilityLabel;
        private System.Windows.Forms.NumericUpDown ItemsCount;
        private System.Windows.Forms.Label CountLabel;
    }
}

