using Helper.Model;

namespace Helper
{
    public class example
    {
        public example()
        {
            Chart chart = new Chart(){
                title = new Title(){
                    text = "Stock Prices"
                },
                legend = new Legend(){
                    position = "bottom"
                },
                valueAxis = new Axis(){
                    labels = new Labels(){
                        format = "${0}",
                        skip = 2,
                        step = 2
                    }
                },
                categoryAxis = new Axis(){
                    labels = new Labels(){
                        format = "MMM"
                    }
                }
            };

            DataSource dataSource = new DataSource() {
                transport = new Transport(){
                    read = new Read(){
                        url = "path to data json file",
                        dataType = "json"
                    }
                },
                group = new Group(){
                    field = "symbol"
                },
                sort = new Sort(){
                    field = "date",
                    dir = "asc"
                },
                schema = new Schema(){
                    model = new Model.Model(){
                        fields =  new Fields(){
                            date = new Date(){
                                type = "date"
                            }
                        }
                    }
                }
            };

            string chartJS = Newtonsoft.Json.JsonConvert.SerializeObject(chart, new Newtonsoft.Json.JsonSerializerSettings
                    {
                        NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                        MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore
                    });

            string dataSourceJS = Newtonsoft.Json.JsonConvert.SerializeObject(dataSource, new Newtonsoft.Json.JsonSerializerSettings
                    {
                        NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                        MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore
                    });
        }
    }
}
