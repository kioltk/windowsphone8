using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        
    }
}
