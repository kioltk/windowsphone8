using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using RestSharp;
namespace wp8.Server
{

    public class User
        {
            public string name
            {
                get;
                set;
            }
            public User()
            {
            }
        }
    public static class DataBase
    {
        public static bool IsValidEmail(string email)
        {




            if (!Regex.IsMatch(email, @"[0-9a-zA-Z_.]+@(\w+)?\w+\.\w+"))
                return false;
            try
            {


                return true;
            }
            catch
            {
                return false;
            }





        }
        static RestClient Client = new RestClient("http://nocompany.azurewebsites.net/api/");

        public static RestRequestAsyncHandle Get(Action<User> PageCallBack)
        {
            var request = new RestRequest("user/{method}", Method.GET);
            request.AddUrlSegment("method" , "getbyid");
            request.AddParameter("id", "1014");

            
            return Client.ExecuteAsync<User>(request, response =>
            {
                PageCallBack(response.Data);
            });
            
        }

        public static void test()
        {
            
        }


        public static RestRequestAsyncHandle Invite(string email, string type, Action<Response> PageCallBack)
        {
            var request = new RestRequest("account/{method}", Method.GET);
            request.AddUrlSegment("method", "invite");
            request.AddParameter("email", email);
            request.AddParameter("type", type); 
            request.AddParameter("requester", "windowsphone8testApplication");


            return Client.ExecuteAsync<Response>(request, response =>
            {
                PageCallBack(response.Data);
            });
        }
        public class Response
        {
            public int code
            {
                get;
                set;
            }
            public string body
            {
                get;
                set;
            }
            public string response
            {
                get;
                set;
            }
            public Response()
            {
            }
        }
    }
}
