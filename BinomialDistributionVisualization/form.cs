﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace BinomialDistributionVisualization
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        BigInteger Factorial(BigInteger num)
        {
            if (num <= 1)
                return 1;
            else return BigInteger.Multiply(Factorial(num - 1), num);
        }

        //nCk = n! / k!(n-k)!
        //giving n! already as input to optimize, it will never differ per item.
        double Combinations(double nF, BigInteger n, BigInteger k)
        {

            var kF = (double)Factorial(k);
            var nMinuskF = (double)Factorial(n - k);
            return nF / (kF * nMinuskF);
        }
     
        void UpdateChart()
        {
            int n = (int)ItemsCount.Value;
            var nF = (double)Factorial(n); //yeah will break if n too big
            var model = new PlotModel { Title = "Binomial probability distribution" };
            var prob = (double)Probability.Value / 10000.0; //to get to 0-1 probability
            var values = new List<ColumnItem>();
            for (int k = 0; k <= n; k++)
            {
                //formula for point k: nCk * p^k * (1-p)^(n-k) where n is max items, p is probability of success
                var weight = Combinations(nF, n, k) * Math.Pow(prob, k) * Math.Pow(1.0 - prob, n - k);
                values.Add(new ColumnItem { Value = weight * 100.0 });
            }
            model.Series.Add(new ColumnSeries { ItemsSource = values });
            model.Axes.Add(new CategoryAxis { Position = AxisPosition.Bottom, TextColor = OxyColors.Transparent }); //hide label
            PlotView.Model = model;
        }

        private void form_Load(object sender, EventArgs e)
        => UpdateChart();

        private void UpdateButton_Click(object sender, EventArgs e)
        => UpdateChart();

        private void Probability_ValueChanged(object sender, EventArgs e)
        {
            ProbabilityLabel.Text = $"Probability: {Math.Round(Probability.Value / 100.0, 2)}%";
            UpdateChart();
        }

        private void ItemsCount_ValueChanged(object sender, EventArgs e)
        => UpdateChart();
    }
}
