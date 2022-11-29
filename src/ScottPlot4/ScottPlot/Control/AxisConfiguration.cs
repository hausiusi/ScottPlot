using ScottPlot.Plottable;

namespace ScottPlot.Control
{
    public class AxisConfiguration<TPlottable> where TPlottable : IPlottable
    {
        public AxisBehaviour Behaviour { get; set; }

        public TPlottable Plottable { get; set; }

        public AxisLimits AxisLimits => Plottable.GetAxisLimits();


    }
}
