using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GetIOTdevicesbyParentId
{
    class Program
    {
        static void Main(string[] args)
        {
            int parentId = 7;
            int pag = 1;
            string status = "RUNNING";
            List<Datum> list = new List<Datum>();

            var devices = GetDevices(status, pag).Result;

            while (devices != null && devices.Data.Count > 0)
            {
                var temp = devices.Data.Where(x => x.Parent?.Id == parentId).ToList();
                devices = GetDevices(status, pag).Result;

                if (temp.Count > 0)
                    list.AddRange(temp);
                pag++;
            }

            decimal averageRotor = list.Sum(x => x.OperatingParams.RotorSpeed) / list.Count;

            Console.WriteLine(Math.Round(averageRotor));
        }

        private static async Task<Devices> GetDevices(string statusQuery, int pag)
        {            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://jsonmock.hackerrank.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = await client.GetAsync($"/api/iot_devices/search?status={statusQuery}&page={pag}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<Devices>(result);
                }
            }

            return null;
        }

    }

    public partial class Devices
    {
        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("per_page")]
        public long PerPage { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }

        [JsonProperty("data")]
        public List<Datum> Data { get; set; }
    }

    public partial class Datum
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("operatingParams")]
        public OperatingParams OperatingParams { get; set; }

        [JsonProperty("asset")]
        public Asset Asset { get; set; }

        [JsonProperty("parent")]
        public Asset Parent { get; set; }
    }

    public partial class Asset
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }
    }

    public partial class OperatingParams
    {
        [JsonProperty("rotorSpeed")]
        public long RotorSpeed { get; set; }

        [JsonProperty("slack")]
        public long Slack { get; set; }

        [JsonProperty("rootThreshold")]
        public double RootThreshold { get; set; }
    }

    public enum Status
    {
        Running,
        Stopped
    };
}
