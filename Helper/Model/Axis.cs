namespace Helper.Model
{
    public class Axis
    {
        public string name { get; set; }
        public string[] categories { get; set; } = null;
        public bool? justified { get; set; }
        public GridLines majorGridLines { get; set; }
        public Labels labels { get; set; }
        public string field { get; set; }
        public Title title { get; set; }
        public double[] axisCrossingValues { get; set; } = null;
        public Crosshair crosshair { get; set; }
        public double? min { get; set; }
        public double? max { get; set; }
        public double? zIndex { get; set; }
        public string color { get; set; }
    }
}