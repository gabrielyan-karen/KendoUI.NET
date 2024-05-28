using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Helper.Model
{
    public class DataSource
    {
        public Transport transport { get; set; } = null;
        public Group group { get; set; }
        public Sort sort { get; set; }
        public Schema schema { get; set; }
    }
}
