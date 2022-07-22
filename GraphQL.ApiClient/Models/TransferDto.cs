using System.Collections.Generic;

namespace GraphQL.ApiClient.Models
{

    public class Result
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public List<Courses> courses { get; set; }
    }

    public class Courses
    {
        public string name { get; set; }
        public string id { get; set; }
    }
}
