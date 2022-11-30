using System.Drawing;
using System.Linq;
using ScottPlot.Plottable;

namespace ScottPlot.Control
{
    public class AxisConfiguration<TPlottable> where TPlottable : IPlottable
    {
        public AxisBehaviour Behaviour { get; set; }

        public TPlottable Plottable { get; set; }

        public AxisLimits AxisLimits => Plottable.GetAxisLimits();

        public PlotDimensions GetRecalculatedDimensions(PlotDimensions dims)
        {
            var signal = (SignalPlot)(IPlottable)Plottable;
            if (signal == null)
            {
                return dims;
            }

            var axisLimits = new AxisLimits(dims.XMin, dims.XMax, signal.Ys.Min(), signal.Ys.Max());

            return new PlotDimensions(
                new SizeF(dims.Width, signal.MaxY - signal.MinY),
                new SizeF(dims.DataWidth, signal.MaxY - signal.MinY),
                new PointF(dims.DataOffsetX, signal.MinY),
                axisLimits, dims.ScaleFactor);
        }
    }
}
