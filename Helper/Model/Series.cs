namespace Helper.Model
{
    public class Series
    {
        public string type { get; set; }
        public int[] data { get; set; } = null;
        public string name { get; set; }
        public string color { get; set; }
        public string axis { get; set; }
        public string field { get; set; }
        public string categoryField { get; set; }
        public bool? visible { get; set; } = true;
        public Markers markers { get; set; }
    }
}