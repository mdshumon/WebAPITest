using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Workflow.Models;

namespace Workflow.WebAPI
{
    public class MapPhotos : IPhotos
    {
        List<Photos> photos { get; set; }       
        public async Task<List<Photos>> GetAllPhotosAsync(string url)
        {
            if (string.IsNullOrEmpty(url)) return null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Add("User-Agent", "Runpath API Test");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    var resp = await response.Content.ReadAsStringAsync();
                    photos = JsonConvert.DeserializeObject<List<Photos>>(resp);
                }
                return photos;
            }
        }
    }
}
