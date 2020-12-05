using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLScriptByQuery
{
    public class SqlDataObject
    {
        public List<string> FieldNames { get; set; }
        public List<object> Values { get; set; }
        public List<string> DataType { get; set; }

        public SqlDataObject()
        {
            FieldNames = new List<string>();
            Values = new List<object>();
            DataType = new List<string>();
        }
    }
}
