using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLScriptByQuery
{
    public class Proceso : IDisposable
    {
        public SqlConnection Connection { get; set; }

        public Proceso(string connectionString)
        {
            Connection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            Connection.Open();
        }

        public StringBuilder BuildScriptData(string script, string tableName)
        {
            var data = GetDbData(script);
            var scriptResult = BuildString(data, tableName);
            return scriptResult;
        }

        public List<SqlDataObject> GetDbData(string script)
        {
            this.OpenConnection();
            var sqlObjects = new List<SqlDataObject>();

            SqlCommand command = new SqlCommand(script, Connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var fields = new List<string>();
                var values = new List<object>();
                var dataTypes = new List<string>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dynamic fieldMetaData = new ExpandoObject();

                    var columnName = reader.GetName(i);
                    var value = reader[i];
                    var dotNetType = reader.GetFieldType(i);
                    var sqlType = reader.GetDataTypeName(i);
                    var specificType = reader.GetProviderSpecificFieldType(i);

                    fieldMetaData.columnName = columnName;
                    fieldMetaData.value = value;
                    fieldMetaData.dotNetType = dotNetType;
                    fieldMetaData.sqlType = sqlType;
                    fieldMetaData.specificType = specificType;

                    fields.Add(columnName);
                    dataTypes.Add(reader.GetFieldType(i).Name);
                    values.Add(reader.GetValue(i));
                }

                var tableName = reader.GetSchemaTable().Rows[0]["BaseTableName"];

                var completeRow = new SqlDataObject();

                completeRow.Values = values;
                completeRow.DataType = dataTypes;
                completeRow.FieldNames = fields;

                sqlObjects.Add(completeRow);
            }
            return sqlObjects;
        }

        public StringBuilder BuildString(List<SqlDataObject> sqlDataObject, string tableName)
        {
            StringBuilder builder = new StringBuilder();

            foreach (var sqlData in sqlDataObject)
            {
                builder.Append($"INSERT INTO {tableName} (");

                for (int i = 0; i < sqlData.FieldNames.Count; i++)
                {
                    var fieldName = sqlData.FieldNames[i];

                    if (sqlData.FieldNames.Count - 1 == i)
                        builder.Append($"[{fieldName}])");
                    else
                        builder.Append($"[{fieldName}], ");
                }

                builder.Append("VALUES (");

                for (int i = 0; i < sqlData.Values.Count; i++)
                {
                    var value = sqlData.Values[i];

                    this.AppendValue(value, sqlData.DataType[i], builder);

                    if (sqlData.FieldNames.Count - 1 == i)
                        builder.Append(")");
                    else
                        builder.Append(", ");
                }

                builder.AppendLine("");
            }

            return builder;
        }

        public void AppendValue(object value, string DataType, StringBuilder builder)
        {
            if (HandleNullValue(value))
            {
                builder.Append($"NULL");
            }
            else
            {
                switch (DataType.ToUpper())
                {
                    case "STRING":
                        builder.Append($"N'{value}'");
                        break;

                    case "DATETIME":
                        var date = DateTime.Parse(value.ToString());
                        builder.Append($"CAST(N'{date.ToString("yyyy-MM-dd HH:mm:ss")}' AS DateTime2)");
                        break;

                    case "DOUBLE":
                        value = value.ToString().Replace(",", ".");
                        builder.Append($"{value}");
                        break;

                    case "SINGLE":
                        builder.Append($"{value}");
                        break;

                    case "INT16":
                        builder.Append($"{value}");
                        break;

                    case "INT32":
                        builder.Append($"{value}");
                        break;

                    case "BOOLEAN":
                        if (Convert.ToBoolean(value))
                            builder.Append("1");
                        else
                            builder.Append("0");
                        break;

                    default:
                        builder.Append($"{value}");
                        break;
                }
            }
        }

        public bool HandleNullValue(object value)
        {
            return value.GetType().Name.ToUpper() == "DBNULL";
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}
