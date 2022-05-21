using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;

namespace Server.Controllers
{
    public class QuizzController : ApiController
    {
        public static HttpClient apiClient { get; set; } = new HttpClient();
        [HttpGet]
        [Route ("hello")]
        public async Task<IHttpActionResult> Get()
        {
            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using (var response = await apiClient.GetAsync("https://opentdb.com/api.php?amount=1"))
            {
                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    Console.Write(data);
                    Quizz quizz = JsonConvert.DeserializeObject<Quizz>(data);
                    return Ok(quizz);
                }
            }
            return NotFound();
        }

    }
}
