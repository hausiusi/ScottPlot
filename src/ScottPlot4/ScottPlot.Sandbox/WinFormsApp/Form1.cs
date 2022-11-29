using System;
using ScottPlot;
using System.Drawing;
using System.Windows.Forms;
using ScottPlot.Control;
using ScottPlot.Plottable;
using ScottPlot.Renderable;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private Axis _axis2, _axis3;

        public Form1()
        {
            InitializeComponent();


            var plt = formsPlot1.Plot;
            plt.YAxis.IsVisible = false;
            plt.YAxis2.IsVisible = false;

            double[] values1 = DataGen.RandomWalk(1_000_000);
            var signal = new SignalPlot()
            {
                XAxisIndex = 1,
                YAxisIndex = 2,
                Ys = values1,
                SampleRate = 48_000,
                Color = Color.Green,
                Label = "Signal Plot 1",
                MinRenderIndex = default,
                MaxRenderIndex = values1.Length - 1,
                OffsetX = 0,
                UseParallel = true,
                IsVisible = true,
                StepDisplay = false,
            };

            _axis2 = plt.AddAxis(Edge.Left, signal.YAxisIndex);
            _axis2.Line(true, signal.Color, 2);
            _axis2.SetAxisConfiguration(signal, AxisBehaviour.AutoAdjust);
            plt.Add(signal);

            double[] values2 = DataGen.RandomWalk(1_000_000);
            var signal2 = new SignalPlot()
            {
                XAxisIndex = 1,
                YAxisIndex = 3,
                Ys = values2,
                SampleRate = 48_000,
                Color = Color.Red,
                Label = "Signal Plot 2",
                MinRenderIndex = default,
                MaxRenderIndex = values2.Length - 1,
                OffsetX = 0,
                UseParallel = true,
                IsVisible = true,
                StepDisplay = false,
            };

            _axis3 = plt.AddAxis(Edge.Left, signal2.YAxisIndex);
            _axis3.Line(true, signal2.Color, 2);
            _axis3.SetAxisConfiguration(signal2, AxisBehaviour.AutoAdjust);
            plt.Add(signal2);

            formsPlot1.Refresh();
        }

        private void cbxLockAxis1_CheckedChanged(object sender, EventArgs e)
        {
            _axis2.LockLimits(cbxLockAxis1.Checked);
        }

        private void cbxLockAxis2_CheckedChanged(object sender, EventArgs e)
        {
            _axis3.LockLimits(cbxLockAxis2.Checked);
        }
    }
}
