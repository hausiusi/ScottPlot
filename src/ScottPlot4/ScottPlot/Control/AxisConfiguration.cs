using System.Drawing;
using System.Linq;
using ScottPlot.Plottable;
using ScottPlot.Renderable;

namespace ScottPlot.Control
{
    public class AxisConfiguration<TPlottable> where TPlottable : IPlottable
    {
        public AxisBehaviour Behaviour { get; set; }

        public TPlottable Plottable { get; set; }

        public AxisLimits AxisLimits => Plottable.GetAxisLimits();

        public float AxisWidth { get; set; }

        public Axis Axis { get; set; }

        public PlotDimensions PlotDimensions { get; set; }

        public float OffsetX { get; set; }

        public SizeF AxisSize
        {
            get
            {
                if (Plottable is SignalPlot signal)
                {
                    return new SizeF(AxisWidth, signal.YMaxPx - signal.YMinPx);
                }
                return new SizeF(0, 0);
            }
        }

        public PointF AxisPosition
        {
            get
            {
                if (Plottable is SignalPlot signal)
                {
                    var x = (float)(PlotDimensions.XMin - AxisWidth) + OffsetX;
                    var y = signal.YMinPx;
                    return new PointF(x, y);
                }
                return new PointF(0, 0);
            }
        }

        public bool SharesVerticalLine(Axis other)
        {
            var configuration2 = other.Configuration;
            if (configuration2 == null)
            {
                return false;
            }

            var leftLineCheck1= IsInRange(this.AxisPosition.X, configuration2.AxisPosition.X,
                configuration2.AxisPosition.X + configuration2.AxisWidth);

            var rightLineCheck1 = IsInRange(this.AxisPosition.X + this.AxisWidth, configuration2.AxisPosition.X,
                configuration2.AxisPosition.X + configuration2.AxisWidth);

            var leftLineCheck2 = IsInRange(configuration2.AxisPosition.X, this.AxisPosition.X,
                this.AxisPosition.X + this.AxisWidth);

            var rightLineCheck2 = IsInRange(configuration2.AxisPosition.X + configuration2.AxisWidth, this.AxisPosition.X,
                this.AxisPosition.X + this.AxisWidth);

            return leftLineCheck1 || rightLineCheck1 || leftLineCheck2 || rightLineCheck2;
        }

        public bool SharesHorizontalLine(Axis other)
        {
            var configuration2 = other.Configuration;
            if (configuration2 == null)
            {
                return false;
            }

            var upperLineCheck1 = IsInRange(this.AxisPosition.Y, configuration2.AxisPosition.Y,
                configuration2.AxisPosition.Y + configuration2.AxisSize.Height);

            var bottomLineCheck1 = IsInRange(this.AxisPosition.Y + this.AxisSize.Height, configuration2.AxisPosition.Y,
                configuration2.AxisPosition.Y + configuration2.AxisSize.Height);

            var upperLineCheck2 = IsInRange(configuration2.AxisPosition.Y, this.AxisPosition.Y,
                this.AxisPosition.Y + this.AxisSize.Height);

            var bottomLineCheck2 = IsInRange(configuration2.AxisPosition.Y + configuration2.AxisSize.Height, this.AxisPosition.Y,
                this.AxisPosition.Y + this.AxisSize.Height);

            return upperLineCheck1 || bottomLineCheck1 || upperLineCheck2 || bottomLineCheck2;
        }

        public bool Bounds(Axis other)
        {
            return SharesVerticalLine(other) && SharesHorizontalLine(other);
        }

        private bool IsInRange(float n, float low, float high)
        {
            return n >= low && n <= high;
        }

        public PlotDimensions GetRecalculatedDimensions(PlotDimensions dims)
        {
            var signal = (SignalPlot)(IPlottable)Plottable;
            if (signal == null)
            {
                return dims;
            }

            PlotDimensions = dims;

            //var axisLimits = new AxisLimits(dims.XMin, dims.XMax, signal.Ys.Min(), signal.Ys.Max());

            return new PlotDimensions(
                new SizeF(dims.Width, signal.YMaxPx - signal.YMinPx),
                new SizeF(dims.DataWidth, signal.YMaxPx - signal.YMinPx),
                new PointF(dims.DataOffsetX, signal.YMinPx),
                AxisLimits, dims.ScaleFactor);
        }
    }
}
