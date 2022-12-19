using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using QueueFiles.Entities;
using QueueFiles.Model;
using System.Collections.Generic;

namespace QueueFiles.MicroServer
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string min = req.Query["min"];
            string max = req.Query["max"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            //name = name ?? data?.name;

            string responseMessage = MainManager.Instance.randomValue.GetRandomBetween(int.Parse(min), int.Parse(max)).ToString();

            /*
            //convert class to json text
            Item item = new Item()
            {
                value = "1"
            };
            string responseMessage2 = System.Text.Json.JsonSerializer.Serialize(item);

            //convert json text to object of type(generic) 
            Item item2=System.Text.Json.JsonSerializer.Deserialize<Item>(responseMessage2);

            //convert class to json text
            Dictionary<int, Item> list = new Dictionary<int, Item>();
            list.Add(0, new Item() { value="ofer"});
            list.Add(1, new Item() { value = "yael" });
            list.Add(2, new Item() { value = "eden" });

            string responseMessage3 = System.Text.Json.JsonSerializer.Serialize(list);

            //convert json text to object of type(generic) 
            Dictionary<int, Item> list2 = System.Text.Json.JsonSerializer.Deserialize<Dictionary<int, Item>>(responseMessage3);
*/
            return new OkObjectResult(responseMessage);
        }
    }
}
