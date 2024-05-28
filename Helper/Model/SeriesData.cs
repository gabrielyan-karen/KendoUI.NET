namespace Helper.Model
{
    public class SeriesData 
    {
        public string name { get; set; }
        public string axis { get; set; }
        public string type { get; set; }
        public string field { get; set; }
        public string color { get; set; }
        public double[] data { get; set; } = null;
        public bool? visible { get; set; }
        public Markers markers { get; set; }
        public Border border { get; set; }
        public NegativeValues negativeValues { get; set; }
    }
}