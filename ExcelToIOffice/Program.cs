using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExcelToIOffice
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            bool windows = true;
            if (windows)
            {
                SiteSelectForm initialScreen = new SiteSelectForm();
                //TestForm initialScreen = new TestForm();

                Application.EnableVisualStyles();
                Application.Run(initialScreen);
            }
            else
            {
                string file = @"C:\Users\Ryan\Documents\Code\ExcelToIOffice\test.xlsx";

                ExcelManager em = ExcelManager.Instance;
                em.openFile(file);
                em.SetActiveSheet(1);
                em.setIgnoreFirstRow(true);

                ExcelUserModel um = new ExcelUserModel();
                um.addField("firstName", "a");
                um.addField("lastName", "c");
                um.addField("email", "d");
                um.addField("username", "g");

                JSONBuilder jb = new JSONBuilder(em, um);

                NetworkManager nm = new NetworkManager("training", "FMsite12", "https://clemson.ricohtrac.com");

                /*string json;

                while ((json = jb.getNextUserJson() ) != "NO MORE ROWS"){
                    System.Console.WriteLine("Pretending to send this to the network!");
                    //nm.SendAddUserRequest("", json);
                }*/

                /*string userJson = nm.SendGetUserRequest("62570");
                IOfficeUser user = JsonConvert.DeserializeObject<IOfficeUser>(usersJson);
                System.Console.WriteLine(user.lastName);
                IOfficeUser.UT.field[] fields = user.userType.fields;
                foreach(IOfficeUser.UT.field field in fields)
                {
                    System.Console.WriteLine(field.id + ": " + field.name);
                }*/

                Console.WriteLine("about to start network");

                Console.WriteLine("network done, about to get ids into array");

                List<int> ids = new List<int>(0);
                int startAt = 0;
                int increment = 50;
                string allUsersJSON = nm.SendGetUsersRequest(increment, startAt);
                do
                {
                    IOfficeTools.addIdsFromJSON(ids, allUsersJSON);
                    startAt += increment;
                    allUsersJSON = nm.SendGetUsersRequest(increment, startAt);
                    Console.WriteLine("size is now " + ids.Count());
                } while (allUsersJSON != "[]");

                Console.WriteLine("ids are in array, lets sort");
                ids.Sort();
                Console.WriteLine("ids are done sorting, lets print");

                foreach (int id in ids)
                {
                    Console.WriteLine("id: " + id);
                }

                Console.Read();
            }
        }
    }
}

/* Things to add 
    
    ---------------------
    *Core*
    UI
    ?Delete with id
    ---------------------

    ---------------------
    *Error Prevention*
    Deal with empty columns
    Deal with failed network calls
    ---------------------

    ---------------------
    *Extra*
    Asynchornous
    Highlight fields that need to be changed
        after an error
    Allow returning from mapping to select dif sheet
    Add remove button to relations
    ---------------------
    */
