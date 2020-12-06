using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLScriptByQuery
{
    public enum QueryId
    {
        Select = 1,
        SelectTop1000 = 2
    }

    public class QueryTemplate
    {
        public QueryId QueryEnumId { get; set; }
        public string NameQuery { get; set; }
        public string Query { get; set; }

        public override string ToString()
        {
            return NameQuery;
        }

        public QueryTemplate SelectQuery(string tableName)
        {
            return new QueryTemplate()
            {
                Query = $"SELECT * FROM {tableName}",
                QueryEnumId = QueryId.Select,
                NameQuery = "Select"
            };
        }

        public QueryTemplate SelectTop1000Query(string tableName)
        {
            return new QueryTemplate()
            {
                Query = $"SELECT TOP 1000 * FROM {tableName}",
                NameQuery = "Select Top 1000",
                QueryEnumId = QueryId.SelectTop1000
            };
        }
    }
}
