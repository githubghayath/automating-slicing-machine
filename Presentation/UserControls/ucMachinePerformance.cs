using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ScottPlot.Plottables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Presentation.UserControls
{
    public partial class ucMachinePerformance : UserControl
    {
        public ucMachinePerformance()
        {
            InitializeComponent();
            _IntializingPerformanceCharts();
            _InitializeProductionVolumeChart();
        }

        double[] buffer = new double[100];   // circular buffer
        double[] plotData = new double[100]; // ordered data for plotting
        double[] xs;
        double dt = 0.05;
        SignalXY signal;
        int index = 0;
        Random rand = new Random();
        double t = 0;

        private List<double> _timeData = new();
        private List<double> _volumeData = new();

        private DateTime _processStartTime;

        private void _IntializingPerformanceCharts()
        {
            xs = Enumerable.Range(0, plotData.Length)
                          .Select(i => i * dt)
                          .ToArray();

            signal = formsPlot1MachinePerformance.Plot.Add.SignalXY(xs, plotData);

            signal.LineWidth = 3;
            signal.Color = ScottPlot.Colors.BurlyWood;

            formsPlot1MachinePerformance.Plot.Title("Simulated Shaft Torque vs Time");
            formsPlot1MachinePerformance.Plot.XLabel("Time (Millisecond)");
            formsPlot1MachinePerformance.Plot.YLabel("Torque (Nm)");
            formsPlot1MachinePerformance.Plot.Axes.Title.Label.ForeColor = ScottPlot.Color.FromHex("#4E6E81");
            formsPlot1MachinePerformance.Plot.Axes.Left.Label.ForeColor = ScottPlot.Color.FromHex("#4E6E81");
            formsPlot1MachinePerformance.Plot.Axes.Bottom.Label.ForeColor = ScottPlot.Color.FromHex("#4E6E81");
            formsPlot1MachinePerformance.Plot.Axes.AutoScaleY();
           
        }
        private void _InitializeProductionVolumeChart()
        {
            _timeData.Clear();
            _volumeData.Clear();

            _processStartTime = DateTime.Now;

            formsPlotProductionVolume.Plot.Clear();

            formsPlotProductionVolume.Plot.Title("Production Line vs Time");
            formsPlotProductionVolume.Plot.XLabel("Time (Millisecond)");
            formsPlotProductionVolume.Plot.YLabel("Production Line (m)");
            formsPlotProductionVolume.Plot.Axes.Title.Label.ForeColor = ScottPlot.Color.FromHex("#4E6E81");
            formsPlotProductionVolume.Plot.Axes.Left.Label.ForeColor = ScottPlot.Color.FromHex("#4E6E81");
            formsPlotProductionVolume.Plot.Axes.Bottom.Label.ForeColor = ScottPlot.Color.FromHex("#4E6E81");

            formsPlotProductionVolume.Refresh();
        }

        private void _MachineProductionVolumLiveChart(double feedRatePerSecond)
        {
            // --------------------------------------------
            // Calculate elapsed time
            // --------------------------------------------
            double elapsedSeconds =
                (DateTime.Now - _processStartTime).TotalSeconds;

            // --------------------------------------------
            // Production volume equation
            // Volume = FeedRate * Time
            // --------------------------------------------
            double productionVolume =
                feedRatePerSecond * elapsedSeconds;

            // --------------------------------------------
            // Add live point
            // --------------------------------------------
            _timeData.Add(elapsedSeconds);
            _volumeData.Add(productionVolume);

            // --------------------------------------------
            // Redraw chart
            // --------------------------------------------
            formsPlotProductionVolume.Plot.Clear();

            formsPlotProductionVolume.Plot.Add.Scatter(
                _timeData.ToArray(),
                _volumeData.ToArray()).LineWidth=1;

            // Optional auto-scale
            formsPlotProductionVolume.Plot.Axes.AutoScale();

            formsPlotProductionVolume.Refresh();
        }

        private void _MachinePerformanceLiveChart()
        {
            // === 1. Generate new torque value ===
            double baseTorque = 50;
            double oscillation = 10 * Math.Sin(t);
            double noise = rand.NextDouble() * 2 - 1;

            double torque = baseTorque + oscillation + noise;

            // === 5. Update X-axis (SCROLLING WINDOW) ===
            double windowSize = xs.Length * dt;

            double xMax = xs[xs.Length - 1];
            double xMin = xMax - windowSize;

            formsPlot1MachinePerformance.Plot.Axes.SetLimitsX(xMin, xMax);



            // === 2. Insert into circular buffer ===
            buffer[index] = torque;

            index = (index + 1) % buffer.Length;

            t += dt;

            // === 3. Rebuild ordered array (for plotting) ===
            int j = 0;

            for (int i = index; i < buffer.Length; i++)
                plotData[j++] = buffer[i];

            for (int i = 0; i < index; i++)
                plotData[j++] = buffer[i];

            // === 4. Update X axis (time sliding window) ===
            for (int i = 0; i < xs.Length - 1; i++)
                xs[i] = xs[i + 1];

            xs[xs.Length - 1] = xs[xs.Length - 2] + dt;

            // === 5. Refresh plot ===
            formsPlot1MachinePerformance.Plot.Axes.AutoScaleY(); // smoother than full autoscale
            formsPlot1MachinePerformance.Refresh();
        }

        public void LiveChart(double feedRatePerSecond, int? TimeInMilliSecond)
        {
            _MachinePerformanceLiveChart();
            _MachineProductionVolumLiveChart(feedRatePerSecond);

            TimeSpan time = TimeSpan.FromMilliseconds(Convert.ToDouble(TimeInMilliSecond));

            lblTimeCounter.Text = $"{time.Hours:D2}:{time.Minutes:D2}:{time.Seconds:D2}";
        }
    }
}
