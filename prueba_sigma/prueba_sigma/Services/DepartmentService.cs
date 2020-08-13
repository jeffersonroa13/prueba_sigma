using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace prueba_sigma.Services
{
    public class DepartmentService
    {
        string endpoint = "https://sigma-studios.s3-us-west-2.amazonaws.com/test/colombia.json";
        public async  Task<Dictionary<string, string[]>> getStates()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync($"{endpoint}"))
                {
                    var status = response.StatusCode;
                    if (status == HttpStatusCode.NotFound)
                    {
                        return null;
                    }
                    else if (status == HttpStatusCode.OK)
                    {
                        response.EnsureSuccessStatusCode();
                        var obj = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(await response.Content.ReadAsStringAsync());
                        return obj;
                    }
                }
            }
            return null;
        }
    }
}
