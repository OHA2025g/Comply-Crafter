using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using ComplyCrafter_Data;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Channels;
using static QRCoder.PayloadGenerator;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ComplyCrafter_BL
{
    public interface IApiLog
    {
        ApiLog Search(string input = "", string url = "", string method = "");
        ApiLog? Save(ApiLog obj);
        Task<string> HitApi(string url, object reqBody, HttpMethod method);
    }

        public class ApiLogRepository : IApiLog
    {
        string TABLE_NAME = "tbl_api_log";
        public ApiLog Search(string input = "", string url = "", string method = "")
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {TABLE_NAME} where input = @input and url = @url and method = @method",
               new Dictionary<string, object>
               {
                    { "@input", input.ToLower() },
                    { "@url", url },
                    { "@method", method },
               }, ThrowError: true)
               .ParseList<ApiLog>().FirstOrDefault();
            return dt;
        }
        public ApiLog? Save(ApiLog obj)
        {
            obj.CreatedOn = DateTime.Now;
            if (obj.Id == 0)
            {
                obj.Id = obj.InsertIntoDBOutIdentity(R.ConnectionString, TABLE_NAME, "id");
                if (obj.Id > 0)
                    return obj;
                return null;
            }
            else
                obj.UpdateIntoDB(R.ConnectionString, TABLE_NAME, "id", obj.Id);
            return obj;
        }

        async public Task<string?> HitApi(string url, object reqBody,HttpMethod method) {
            var requestBody = JsonConvert.SerializeObject(reqBody);
            var s = Search(requestBody, url, method.Method);
            if (s != null) return s.Output;

            using (HttpClient _httpClient = new HttpClient())
            {
                var content = new StringContent(requestBody, Encoding.UTF8, "application/json");

                var request = new HttpRequestMessage(method, url)
                {
                    Content = content
                };

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", R.AppSet("SurePass:Bearer"));

                try
                {
                    var response = await _httpClient.SendAsync(request);
                    var responseBody = await response.Content.ReadAsStringAsync();
                    JObject jsonObj = JObject.Parse(responseBody);
                    if (jsonObj["success"] == null || !bool.TryParse(jsonObj["success"].ToString(), out bool success) || !success)
                    {
                        return null;
                    }
                    if (response.IsSuccessStatusCode)
                    {
                        Save(new ApiLog() { 
                            URL = url,
                            Method = method.Method,
                            Input = requestBody.ToLower(),
                            Output = responseBody
                        });
                        return responseBody;
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    return null;
                }
            }
        }

    }
}
