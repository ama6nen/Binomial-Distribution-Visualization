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
            this.label1 = new System.Windows.Forms.Label();
            this.Successes = new System.Windows.Forms.NumericUpDown();
            this.P_Equal = new System.Windows.Forms.Label();
            this.P_Less = new System.Windows.Forms.Label();
            this.P_LessEqual = new System.Windows.Forms.Label();
            this.P_More = new System.Windows.Forms.Label();
            this.P_MoreEqual = new System.Windows.Forms.Label();
            this.FormulaPicture = new System.Windows.Forms.PictureBox();
            this.ShowFormula = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Probability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Successes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormulaPicture)).BeginInit();
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
            this.ProbabilityLabel.Size = new System.Drawing.Size(216, 17);
            this.ProbabilityLabel.TabIndex = 3;
            this.ProbabilityLabel.Text = "Single trial success probability: 50%";
            // 
            // ItemsCount
            // 
            this.ItemsCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemsCount.Location = new System.Drawing.Point(10, 12);
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
            this.CountLabel.Location = new System.Drawing.Point(12, 40);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(57, 17);
            this.CountLabel.TabIndex = 5;
            this.CountLabel.Text = "Trials (n)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Successes (x)";
            // 
            // Successes
            // 
            this.Successes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Successes.Location = new System.Drawing.Point(10, 69);
            this.Successes.Maximum = new decimal(new int[] {
            170,
            0,
            0,
            0});
            this.Successes.Name = "Successes";
            this.Successes.Size = new System.Drawing.Size(63, 25);
            this.Successes.TabIndex = 6;
            this.Successes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Successes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Successes.ValueChanged += new System.EventHandler(this.Successes_ValueChanged);
            // 
            // P_Equal
            // 
            this.P_Equal.AutoSize = true;
            this.P_Equal.Location = new System.Drawing.Point(157, 71);
            this.P_Equal.Name = "P_Equal";
            this.P_Equal.Size = new System.Drawing.Size(106, 17);
            this.P_Equal.TabIndex = 8;
            this.P_Equal.Text = "P(X = x): 0.00000";
            // 
            // P_Less
            // 
            this.P_Less.AutoSize = true;
            this.P_Less.Location = new System.Drawing.Point(269, 71);
            this.P_Less.Name = "P_Less";
            this.P_Less.Size = new System.Drawing.Size(106, 17);
            this.P_Less.TabIndex = 9;
            this.P_Less.Text = "P(X < x): 0.00000";
            // 
            // P_LessEqual
            // 
            this.P_LessEqual.AutoSize = true;
            this.P_LessEqual.Location = new System.Drawing.Point(381, 71);
            this.P_LessEqual.Name = "P_LessEqual";
            this.P_LessEqual.Size = new System.Drawing.Size(115, 17);
            this.P_LessEqual.TabIndex = 10;
            this.P_LessEqual.Text = "P(X <= x): 0.00000";
            // 
            // P_More
            // 
            this.P_More.AutoSize = true;
            this.P_More.Location = new System.Drawing.Point(502, 71);
            this.P_More.Name = "P_More";
            this.P_More.Size = new System.Drawing.Size(106, 17);
            this.P_More.TabIndex = 11;
            this.P_More.Text = "P(X > x): 0.00000";
            // 
            // P_MoreEqual
            // 
            this.P_MoreEqual.AutoSize = true;
            this.P_MoreEqual.Location = new System.Drawing.Point(614, 71);
            this.P_MoreEqual.Name = "P_MoreEqual";
            this.P_MoreEqual.Size = new System.Drawing.Size(115, 17);
            this.P_MoreEqual.TabIndex = 12;
            this.P_MoreEqual.Text = "P(X >= x): 0.00000";
            // 
            // FormulaPicture
            // 
            this.FormulaPicture.Image = global::BinomialDistributionVisualization.Properties.Resources.xbinomial_distribution_formula_png_pagespeed_ic_82Np1Wmmm6;
            this.FormulaPicture.Location = new System.Drawing.Point(12, 327);
            this.FormulaPicture.Name = "FormulaPicture";
            this.FormulaPicture.Size = new System.Drawing.Size(420, 242);
            this.FormulaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FormulaPicture.TabIndex = 13;
            this.FormulaPicture.TabStop = false;
            this.FormulaPicture.Visible = false;
            // 
            // ShowFormula
            // 
            this.ShowFormula.AutoSize = true;
            this.ShowFormula.Location = new System.Drawing.Point(801, 73);
            this.ShowFormula.Name = "ShowFormula";
            this.ShowFormula.Size = new System.Drawing.Size(107, 21);
            this.ShowFormula.TabIndex = 14;
            this.ShowFormula.Text = "Show formula";
            this.ShowFormula.UseVisualStyleBackColor = true;
            this.ShowFormula.CheckedChanged += new System.EventHandler(this.ShowFormula_CheckedChanged);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 581);
            this.Controls.Add(this.ShowFormula);
            this.Controls.Add(this.FormulaPicture);
            this.Controls.Add(this.P_MoreEqual);
            this.Controls.Add(this.P_More);
            this.Controls.Add(this.P_LessEqual);
            this.Controls.Add(this.P_Less);
            this.Controls.Add(this.P_Equal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Successes);
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
            this.Text = "Binomial probability";
            this.Load += new System.EventHandler(this.form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Probability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Successes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormulaPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView PlotView;
        private System.Windows.Forms.TrackBar Probability;
        private System.Windows.Forms.Label ProbabilityLabel;
        private System.Windows.Forms.NumericUpDown ItemsCount;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Successes;
        private System.Windows.Forms.Label P_Equal;
        private System.Windows.Forms.Label P_Less;
        private System.Windows.Forms.Label P_LessEqual;
        private System.Windows.Forms.Label P_More;
        private System.Windows.Forms.Label P_MoreEqual;
        private System.Windows.Forms.PictureBox FormulaPicture;
        private System.Windows.Forms.CheckBox ShowFormula;
    }
}

