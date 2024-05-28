namespace Helper.Model
{
    public class Chart
    {
        public Title title { get; set; }
        public string dataSource { get; set; }
        public Area chartArea { get; set; }
        public Legend legend { get; set; }
        public Series[] series { get; set; } = null;
        public Axis valueAxes { get; set; } = null;
        public Axis valueAxis { get; set; } = null;
        public Axis categoryAxis { get; set; }
        public Tooltip tooltip { get; set; }
        public Defaults seriesDefaults { get; set; }
        public Pannable pannable { get; set; }
        public Zoomable zoomable { get; set; }
        public Source pdf { get; set; }
        public string render { get; set; }
    }
}