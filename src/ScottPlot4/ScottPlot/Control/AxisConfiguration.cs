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
                    height = (height > AxisTickLabelHeight ? height : AxisTickLabelHeight);

                    return new SizeF(AxisWidth, height);
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

            var conf1X1 = this.AxisPosition.X - this.AxisTickLabelHeight;
            var conf1X2 = this.AxisPosition.X + this.AxisWidth;
            var conf2X1 = configuration2.AxisPosition.X - configuration2.AxisTickLabelHeight;
            var conf2X2 = configuration2.AxisPosition.X + configuration2.AxisWidth;

            var leftLineCheck1 = IsInRange(this.AxisPosition.X, conf2X1, conf2X2);
            var rightLineCheck1 = IsInRange(this.AxisPosition.X + this.AxisWidth, conf2X1, conf2X2);
            var leftLineCheck2 = IsInRange(configuration2.AxisPosition.X, conf1X1, conf1X2);
            var rightLineCheck2 = IsInRange(configuration2.AxisPosition.X + configuration2.AxisWidth, conf1X1, conf1X2);

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

            var actualHeight1 = Math.Max(this.AxisSize.Height + this.AxisTickLabelHeight, this.AxisLabelWidth);
            var actualHeight2 = Math.Max(configuration2.AxisSize.Height + this.AxisTickLabelHeight, configuration2.AxisLabelWidth);
            var center1 = this.AxisPosition.Y + (AxisSize.Height / 2);
            var center2 = configuration2.AxisPosition.Y + (configuration2.AxisSize.Height / 2);

            var conf1Y1 = center1 - actualHeight1 / 2;
            var conf1Y2 = center1 + actualHeight1 / 2;
            var conf2Y1 = center2 - actualHeight2 / 2;
            var conf2Y2 = center2 + actualHeight2 / 2;

            var upperLineCheck1 = IsInRange(conf1Y1, conf2Y1, conf2Y2);
            var bottomLineCheck1 = IsInRange(conf1Y2, conf2Y1, conf2Y2);
            var upperLineCheck2 = IsInRange(conf2Y1, conf1Y1, conf1Y2);
            var bottomLineCheck2 = IsInRange(conf2Y2, conf1Y1, conf1Y2);

            return upperLineCheck1 || bottomLineCheck1 || upperLineCheck2 || bottomLineCheck2;
        }

        public bool Bounds(Axis other)
        {
            return this.Axis != other && SharesVerticalLine(other) && SharesHorizontalLine(other);
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

            var limitsTmp = signal.GetAxisLimits();
            var yMin = signal.YMinVisible;
            var yMax = signal.YMaxVisible;

            if (Math.Abs(yMin - yMax) < 0.0001)
            {
                yMin -= 0.0001;
                yMax += 0.0001;
            }

            var axisLimits = new AxisLimits(limitsTmp.XMin, limitsTmp.XMax, yMin, yMax);

            return new PlotDimensions(
                new SizeF(dims.Width, AxisSize.Height),
                new SizeF(dims.DataWidth, AxisSize.Height),
                new PointF(dims.DataOffsetX, AxisPosition.Y),
                axisLimits, dims.ScaleFactor);
        }
    }
}
