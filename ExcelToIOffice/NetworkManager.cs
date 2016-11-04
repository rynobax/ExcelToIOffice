using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ExcelToIOffice
{
    class NetworkManager
    {
        private string auth_username;
        private string auth_password;
        private string base_url;
        public NetworkManager(string username, string password, string url)
        {
            auth_username = username;
            auth_password = password;
            base_url = url + "/external/api/rest/v2/";
        }
        public bool SendAddUserRequest(string json)
        {
            byte[] jsonbytes = Encoding.ASCII.GetBytes(json);

            WebRequest request = (HttpWebRequest) WebRequest.Create(base_url + "users");
            request.Method = "POST";
            request.ContentLength = jsonbytes.Length;
            request.ContentType = "application/json";
            request.Headers.Add("x-auth-username", auth_username);
            request.Headers.Add("x-auth-password", auth_password);

            Console.WriteLine("Trying to get data stream");
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(jsonbytes, 0, jsonbytes.Length);
            } 

            Console.Write("Got data stream!");

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    int statusCode = (int)response.StatusCode;
                    Console.WriteLine("Response code is: " + statusCode);
                    //Console.Write(responseStream.ReadByte());

                    if(statusCode != 201)
                    {
                        Logger.Instance.Log("Oh no!  Got code" + statusCode + "when adding user with info" + json);
                    }
                    request.Abort();
                    responseStream.Close();
                }
            }
                
            return true;
        }

        public string SendGetUserRequest(string id)
        {
            WebRequest request = (HttpWebRequest)WebRequest.Create(base_url + "users/" + id);
            request.Method = "GET";
            request.Headers.Add("x-auth-username", auth_username);
            request.Headers.Add("x-auth-password", auth_password);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    int statusCode = (int)response.StatusCode;
                    Console.WriteLine("Response code is: " + statusCode);

                    if (statusCode != 200)
                    {
                        Logger.Instance.Log("Oh no!  Got code" + statusCode + "when trying to get users");
                    }

                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    String responseString = reader.ReadToEnd();

                    request.Abort();
                    responseStream.Close();

                    return responseString;
                }
            }
        }

        public string SendGetUsersRequest(int limit, int startAt)
        {
            WebRequest request = (HttpWebRequest)WebRequest.Create(base_url + "users/" + "?limit="+limit + "&" + "startAt="+startAt);
            request.Method = "GET";
            request.Headers.Add("x-auth-username", auth_username);
            request.Headers.Add("x-auth-password", auth_password);


            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    int statusCode = (int)response.StatusCode;
                    Console.WriteLine("Response code is: " + statusCode);

                    if (statusCode != 200)
                    {
                        Logger.Instance.Log("Oh no!  Got code" + statusCode + "when trying to get users");
                    }

                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    String responseString = reader.ReadToEnd();

                    request.Abort();
                    responseStream.Close();

                    return responseString;
                }
            }
        }
    }
}
