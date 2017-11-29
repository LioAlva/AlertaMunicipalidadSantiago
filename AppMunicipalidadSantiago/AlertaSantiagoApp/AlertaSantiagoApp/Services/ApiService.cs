
using AlertaSantiagoApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AlertaSantiagoApp.Services
{
    public class ApiService
    {
        public ApiService()
        {

        }

        public async Task<Response> Login(string email, string password)
        {
            try
            {
           

                var client = new HttpClient();

                var url = "http://tdmdigitalqa.azurewebsites.net/Service1.svc/accesoLoginCliente?param1=" + email + "&param2=" + password + "&param3=1";
                var response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }

                var loginRequest = new User
                {
                    Email = email,
                    Password = password,
                };

                var result = await response.Content.ReadAsStringAsync();
                var respuestaLogin = JsonConvert.DeserializeObject<ResponseLogin>(result);
                return new Response
                {
                    IsSuccess = respuestaLogin.status.Equals("OK") ? true : false,
                    Message = respuestaLogin.message,
                    Result = loginRequest
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
