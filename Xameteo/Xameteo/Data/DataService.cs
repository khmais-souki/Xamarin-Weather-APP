using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Xameteo.Data 
{
    public class DataService
    {
        public static async Task<dynamic> getDataFromService(string queryString)
        {
            HttpClient client = new HttpClient();
            var reply = await client.GetAsync(queryString);
            dynamic data = null;
            if(reply != null)
            {
                string json = reply.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject(json);

            }
            return data;
        }
    }
}
