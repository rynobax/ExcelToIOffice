using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToIOffice
{
    class IOfficeTools
    {
        public static List<int> addIdsFromJSON(List<int> ids, string json)
        {
            
            List<MyUser> users = JsonConvert.DeserializeObject<List<MyUser>>(json);
            foreach(MyUser user in users)
            {
                int id;
                if (Int32.TryParse(user.id, out id))
                {
                    ids.Add(id);
                }else
                {
                    System.Console.WriteLine("Was unable to parse: " + user.id);
                }
            }
            return ids;
        }

        private class MyUser
        {
            public string id;
        }
    }
}
