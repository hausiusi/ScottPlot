using ScottPlot.Plottable;
using ScottPlot.Renderable;
using System;
using System.Drawing;

namespace ScottPlot.Control
{
    public class AxisConfiguration<TPlottable> where TPlottable : IPlottable
    {
        public AxisBehaviour Behaviour { get; set; }

        public TPlottable Plottable { get; set; }

        public AxisLimits AxisLimits => Plottable.GetAxisLimits();

        public float AxisWidth { get; set; }

        public float AxisLabelWidth { get; set; }

        public float AxisTickLabelHeight { get; set; }

        public Axis Axis { get; set; }

        public PlotDimensions PlotDimensions { get; set; }

        public float OffsetX { get; set; }

        public SizeF AxisSize
        {
            get
            {
                if (Plottable is SignalPlot signal)
                {
                    var height = signal.YMaxPx - signal.YMinPx;
                    return new SizeF(AxisWidth, height > 0 ? height : AxisTickLabelHeight);
                }
                return new SizeF(0, 0);
            }
        }

        public PointF AxisPosition
        {
            get
            {
                if (Plottable is SignalPlot signal && PlotDimensions != null)
                {
                    var x = (float)(PlotDimensions.XMin - AxisSize.Width) + OffsetX;
                    var y = signal.YMinPx;
                    if (Math.Abs(AxisSize.Height - AxisTickLabelHeight) < 0.1)
                    {
                        y -= AxisTickLabelHeight / 2;
                    }

                    return new PointF(x, y);
                }
                return new PointF(0, 0);
            }
        }

        public bool SharesVerticalLine(Axis other)
        {
            if (!other.IsVisible)
            {
                return false;
            }

            if (other.Edge != this.Axis.Edge)
            {
                return false;
            }

            if (!this.Axis.IsVisible || !other.IsVisible)
            {
                return false;
            }

            var configuration2 = other.Configuration;
            if (configuration2 == null)
            {
                return false;
            }

            var leftLineCheck1 = IsInRange(this.AxisPosition.X, configuration2.AxisPosition.X,
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
            if (!other.IsVisible)
            {
                return false;
            }

            if (other.Edge != this.Axis.Edge)
            {
                return false;
            }

            if (!this.Axis.IsVisible || !other.IsVisible)
            {
                return false;
            }

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
                new SizeF(dims.Width, AxisSize.Height),
                new SizeF(dims.DataWidth, AxisSize.Height),
                new PointF(dims.DataOffsetX, AxisPosition.Y),
                AxisLimits, dims.ScaleFactor);
        }
    }
}
