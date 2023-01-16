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
        private Axis _axis2, _axis3, _axis4, _axis5;

        public Form1()
        {
            InitializeComponent();


            var plt = formsPlot1.Plot;
            plt.YAxis.IsVisible = false;
            plt.YAxis2.IsVisible = false;

            AxisConfigurations axisConfigurations = new();

            double[] values2 = DataGen.RandomWalk(1_000_000);
            var signal2 = new SignalPlot()
            {
                XAxisIndex = 1,
                YAxisIndex = 2,
                Ys = values2,
                SampleRate = 48_000,
                Color = Color.Green,
                Label = "Signal Plot 1",
                MinRenderIndex = default,
                MaxRenderIndex = values2.Length - 1,
                OffsetX = 0,
                UseParallel = true,
                IsVisible = true,
                StepDisplay = false,
            };

            _axis2 = plt.AddAxis(Edge.Left, signal2.YAxisIndex);
            _axis2.Line(true, signal2.Color, 2);
            _axis2.SetAxisConfiguration(axisConfigurations, signal2, AxisBehaviour.AutoAdjust);
            plt.Add(signal2);

            double[] values3 = DataGen.Full(1_000_000, 0);//DataGen.RandomWalk(1_000_000);
            var signal3 = new SignalPlot()
            {
                XAxisIndex = 1,
                YAxisIndex = 3, 
                Ys = values3,
                SampleRate = 48_000,
                Color = Color.Red,
                Label = "Signal Plot 2",
                MinRenderIndex = default,
                MaxRenderIndex = values3.Length - 1,
                OffsetX = 0,
                UseParallel = true,
                IsVisible = true,
                StepDisplay = false,
            };

            _axis3 = plt.AddAxis(Edge.Left, signal3.YAxisIndex);
            _axis3.Line(true, signal3.Color, 2);
            _axis3.SetAxisConfiguration(axisConfigurations, signal3, AxisBehaviour.AutoAdjust);
            plt.Add(signal3);

            double[] values4 = DataGen.RandomWalk(1_000_000);
            var signal4 = new SignalPlot()
            {
                XAxisIndex = 1,
                YAxisIndex = 4,
                Ys = values4,
                SampleRate = 48_000,
                Color = Color.Yellow,
                Label = "Signal Plot 3",
                MinRenderIndex = default,
                MaxRenderIndex = values2.Length - 1,
                OffsetX = 0,
                UseParallel = true,
                IsVisible = true,
                StepDisplay = false,
            };

            _axis4 = plt.AddAxis(Edge.Left, signal4.YAxisIndex);
            _axis4.Line(true, signal4.Color, 2);
            _axis4.SetAxisConfiguration(axisConfigurations, signal4, AxisBehaviour.AutoAdjust);
            plt.Add(signal4);

            double[] values5 = DataGen.RandomWalk(1_000_000);
            var signal5 = new SignalPlot()
            {
                XAxisIndex = 1,
                YAxisIndex = 5,
                Ys = values5,
                SampleRate = 48_000,
                Color = Color.Brown,
                Label = "Signal Plot 4",
                MinRenderIndex = default,
                MaxRenderIndex = values2.Length - 1,
                OffsetX = 0,
                UseParallel = true,
                IsVisible = true,
                StepDisplay = false,
            };

            _axis5 = plt.AddAxis(Edge.Left, signal5.YAxisIndex);
            _axis5.Line(true, signal5.Color, 2);
            _axis5.SetAxisConfiguration(axisConfigurations, signal5, AxisBehaviour.AutoAdjust);
            plt.Add(signal5);

            formsPlot1.Refresh();
            
        }

        private void cbxLockAxis1_CheckedChanged(object sender, EventArgs e)
        {
            _axis2.LockLimits(cbxLockAxis1.Checked);
            formsPlot1.Refresh();
        }

        private void cbxAxis3Right_CheckedChanged(object sender, EventArgs e)
        {
            _axis4.Edge = cbxAxis3Right.Checked ? Edge.Right : Edge.Left;
            formsPlot1.Refresh();
        }

        private void cbxAxis4Right_CheckedChanged(object sender, EventArgs e)
        {
            _axis5.Edge = cbxAxis4Right.Checked ? Edge.Right : Edge.Left;
            formsPlot1.Refresh();
        }

        private void cbxLockAxis3_CheckedChanged(object sender, EventArgs e)
        {
            _axis4.LockLimits(cbxLockAxis3.Checked);
            formsPlot1.Refresh();
        }

        private void cbxLockAxis4_CheckedChanged(object sender, EventArgs e)
        {
            _axis5.LockLimits(cbxLockAxis4.Checked);
            formsPlot1.Refresh();
        }

        private void cbxAxis1Lbl_CheckedChanged(object sender, EventArgs e)
        {
            _axis2.Label(cbxAxis1Lbl.Checked? "Signal 1" : "");
            formsPlot1.Refresh();
        }

        private void cbxAxis2Lbl_CheckedChanged(object sender, EventArgs e)
        {
            _axis3.Label(cbxAxis2Lbl.Checked ? "Signal 2" : "");
            formsPlot1.Refresh();
        }

        private void cbxAxis3Lbl_CheckedChanged(object sender, EventArgs e)
        {
            _axis4.Label(cbxAxis3Lbl.Checked ? "Signal 3" : "");
            formsPlot1.Refresh();
        }

        private void cbxAxis4Lbl_CheckedChanged(object sender, EventArgs e)
        {
            _axis5.Label(cbxAxis4Lbl.Checked ? "Signal 4" : "");
            formsPlot1.Refresh();
        }

        private void AxisIsVisible(object sender, EventArgs e)
        {
            _axis2.IsVisible = cbxAxis1Visible.Checked;
            _axis3.IsVisible = cbxAxis2Visible.Checked;
            _axis4.IsVisible = cbxAxis3Visible.Checked;
            _axis5.IsVisible = cbxAxis4Visible.Checked;
            formsPlot1.Refresh();
        }

        private void cbxAxis1Right_CheckedChanged(object sender, EventArgs e)
        {
            _axis2.Edge = cbxAxis1Right.Checked ? Edge.Right : Edge.Left;
            formsPlot1.Refresh();
        }

        private void cbxAxis2Right_CheckedChanged(object sender, EventArgs e)
        {
            _axis3.Edge = cbxAxis2Right.Checked ? Edge.Right : Edge.Left;
            formsPlot1.Refresh();
        }

        private void cbxLockAxis2_CheckedChanged(object sender, EventArgs e)
        {
            _axis3.LockLimits(cbxLockAxis2.Checked);
            formsPlot1.Refresh();
        }
    }
}
