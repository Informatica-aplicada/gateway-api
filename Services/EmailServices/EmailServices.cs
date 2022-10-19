using System;

namespace gateway_api.Services.EmailServices
{
    public class EmailServices
    {

         public async Task<List<PersonEmail>> listemail([FromBody] int[] year)
        {

            List<PersonEmail> list = new List<PersonEmail>();
            var json = JsonConvert.SerializeObject(year);

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("http://localhost:5401/api/person/listPersonEmail"),
                Content = new StringContent(json)
                {
                    Headers =
        {
            ContentType = new MediaTypeHeaderValue("application/json")
        }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                list = JsonConvert.DeserializeObject<List<PersonEmail>>(body);
                Console.WriteLine(body);
            }

            return list;

        }
        
    }
}
