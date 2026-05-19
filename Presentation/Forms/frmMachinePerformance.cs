using ScottPlot.Plottables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Presentation.Forms
{
    public partial class frmMachinePerformance : Form
    {
        public frmMachinePerformance()
        {
            InitializeComponent();
            timer1.Start();
        }
        double[] buffer = new double[100];   // circular buffer
        double[] plotData = new double[100]; // ordered data for plotting
        double[] xs;

        int index = 0;

        Random rand = new Random();
        double t = 0;
        double dt = 0.05;

        SignalXY signal;

        double[] prodBuffer = new double[200];
        double[] prodPlotData = new double[200];
        double[] prodXs;

        double prodIndex = 0;
        double prodTime = 0;

        double feedSpeed = 11.0 / 60.0; // m/s
        double area = 0.2 * 0.03;       // m²

        SignalXY prodSignal;


        private void frmMachinePerformance_Load(object sender, EventArgs e)
        {
            xs = Enumerable.Range(0, plotData.Length)
                           .Select(i => i * dt)
                           .ToArray();

            signal = formsPlot1.Plot.Add.SignalXY(xs, plotData);

            signal.LineWidth = 3;
            signal.Color = ScottPlot.Colors.BurlyWood;

            formsPlot1.Plot.Title("Simulated Shaft Torque vs Time");
            formsPlot1.Plot.XLabel("Time (s)");
            formsPlot1.Plot.YLabel("Torque (Nm)");

            // =========================
            // NEW: Production chart
            // =========================

            prodXs = Enumerable.Range(0, prodPlotData.Length)
                               .Select(i => i * dt)
                               .ToArray();
            prodSignal = formsPlot2.Plot.Add.SignalXY(prodXs, prodPlotData);

            prodSignal.LineWidth = 3;
            prodSignal.Color = ScottPlot.Colors.DodgerBlue;

            formsPlot2.Plot.Title("Cumulative Wood Production Over Time");
            formsPlot2.Plot.XLabel("Time (s)");
            formsPlot2.Plot.YLabel("Volume (m³)");


            formsPlot2.Refresh();
            formsPlot1.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
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

            formsPlot1.Plot.Axes.SetLimitsX(xMin, xMax);



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
            formsPlot1.Plot.Axes.AutoScaleY(); // smoother than full autoscale


            // ======================================================
            // NEW SECTION: PRODUCTION CHART (formsPlot2)
            // ======================================================

            double speedNoise = (rand.NextDouble() - 0.5) * 0.02;
            double currentSpeed = feedSpeed + speedNoise;

            double rate = currentSpeed * area; // m³/s

            prodBuffer[(int)prodIndex] += rate * dt;

            prodIndex = (prodIndex + 1) % prodBuffer.Length;

            prodTime += dt;

            // reorder production buffer
            int k = 0;

            for (int i = (int)prodIndex; i < prodBuffer.Length; i++)
                prodPlotData[k++] = prodBuffer[i];

            for (int i = 0; i < prodIndex; i++)
                prodPlotData[k++] = prodBuffer[i];

            // prodSignal.Data = prodPlotData;

            double prodWindow = prodXs.Length * dt;
            double prodXMax = prodTime;
            double prodXMin = prodXMax - prodWindow;

            formsPlot2.Plot.Axes.SetLimitsX(prodXMin, prodXMax);

            formsPlot2.Plot.Axes.AutoScaleY();

            formsPlot1.Refresh();
            formsPlot2.Refresh();

        }
    }
}
