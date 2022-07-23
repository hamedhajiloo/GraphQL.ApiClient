using System.Collections.Generic;
using System.Text;

namespace GraphQL.ApiClient.Models
{

    public class Result
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public List<Courses> courses { get; set; }
        public override string ToString()
        {
            if (courses is null)
            {
                return "null";
            }

            var strBuilder = new StringBuilder();
            foreach (var course in courses)
            {
                strBuilder.AppendLine(course.ToString());
            }

            return strBuilder.ToString();
        }
    }

    public class Courses
    {
        public string name { get; set; }
        public string id { get; set; }
        public override string ToString()
        {
            var strBuilder = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(id))
            {
                strBuilder.Append($"id={id} ");
            }
            if (!string.IsNullOrWhiteSpace(name))
            {
                strBuilder.Append($"name={name} ");
            }

            return strBuilder.ToString().Trim();
        }
    }
}
