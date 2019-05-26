using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemClassLibrary
{
    public class AuthManager
    {
        public async Task<User> AuthorityVerify(string login, string password)
        {
            User user = null;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44345");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                
                HttpResponseMessage auth = await client.PostAsJsonAsync(
                "api/AccountController/Login",new { login,password});
                if (auth.IsSuccessStatusCode)
                {
                    HttpResponseMessage res = await client.GetAsync("api/UsersController/Index/"+login);
                    if (res.IsSuccessStatusCode)
                    {
                        user = await res.Content.ReadAsAsync<User>();
                    }
                }
            }
            return user;
        }

    }
}
