namespace Feriados
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Date
    {
        public string iso { get; set; }
        public Datetime datetime { get; set; }
    }

    public class Datetime
    {
        public int? year { get; set; }
        public int? month { get; set; }
        public int? day { get; set; }
    }

    public class Holiday
    {
        public string name { get; set; }
        public string description { get; set; }
        public Date date { get; set; }
        public List<string> type { get; set; }
    }

    public class Meta
    {
        public int? code { get; set; }
    }

    public class Response
    {
        public List<Holiday> holidays { get; set; }
    }

    public class Root
    {
        public Meta meta { get; set; }
        public Response response { get; set; }
    }


}
