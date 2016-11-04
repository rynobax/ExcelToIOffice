using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToIOffice
{
    class IOfficeHelper
    {
        private static IOfficeHelper instance;

        private IOfficeHelper() { }

        public static IOfficeHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new IOfficeHelper();
                }
                return instance;
            }
        }

        public class DBField
        {
            public string dbname { get; set; }
            public string readableName { get; set; }

            public DBField(string db, string read)
            {
                dbname = db;
                readableName = read;
            }
        }
        private List<DBField> databaseFields;

        public List<DBField> getDBFields()
        {
            return databaseFields;
        }

        public void getAllDatabaseFieldsFromJson(string json)
        {
            JArray jarray = JArray.Parse(json);
            JToken jtoken = jarray[0];
            JObject jobject = (JObject)jtoken;
            databaseFields = new List<DBField>();
            foreach(JProperty jproperty in jobject.Properties())
            {
                if(!Extensions.HasProperty(jproperty.Value, "Count"))
                {
                    string name = jproperty.Name;
                    if (name.Length > 6 && name.Substring(0, 6) == "custom")
                    {
                        JToken userToken = jtoken.SelectToken("$.userType.fields[?(@.code == '" + name + "')]");
                        if (userToken != null)
                        {
                            JToken nameToken = userToken.SelectToken("name");
                            databaseFields.Add(new DBField(name, nameToken.ToString()));
                        }
                    } else {
                        databaseFields.Add(new DBField(name, name));
                    }
                }
            }
            databaseFields = databaseFields.OrderBy(o=>o.readableName).ToList();
        }
    }
}
