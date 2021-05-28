using BasicProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BasicProject.Common
{
    public class HttpRequestCommon
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public static async Task<Account> GetAccount(string token, string idApp, string userAgent)
        {
            _httpClient.DefaultRequestHeaders.Add("user-agent", userAgent);
            using (var form = new MultipartFormDataContent())
            {
                form.Add(new StringContent(token, Encoding.UTF8), "access_token");
                HttpResponseMessage response = await _httpClient.PostAsync($"https://graph.facebook.com/v10.0/{idApp}/accounts", form);
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<Account>(responseContent);
                    return result;
                }
                return null;
            }
        }

        public static async Task<TokenApp> GetTokenApp(string idApp, string secrec)
        {
            var response = await _httpClient.GetAsync($"https://graph.facebook.com/oauth/access_token?client_id={idApp}&client_secret={secrec}&grant_type=client_credentials");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<TokenApp>(responseContent);
                return result;
            }
            return null;
        }
    }
}
