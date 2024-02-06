using DesignPractise.Models;
using Org.Apache.Http.Authentication;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DesignPractise.Services
{
    public class AuthService
    {
        HttpClient httpClient;

        public AuthService()
        {
            httpClient = new HttpClient();
        }


        public async Task<String> LoginAsync()
        {
            
            Uri uri = new Uri(string.Format("https://localhost:7022/api/UserAuth/auth", string.Empty));

            try
            {
                User user = new User();
                user.Username = "harsh@gmail.com";
                user.Password = "jhsjdfhdsj";
                  
                string json = JsonSerializer.Serialize(user);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
               
                    response = await httpClient.PostAsync(uri, content);

                var result = "";
                if (response.IsSuccessStatusCode)
                {
                     result  = await response.Content.ReadAsStringAsync();   
                    Debug.WriteLine(@"\tLogin successful.");
                    return result;

                }
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
            return "";
        }
    }
}
