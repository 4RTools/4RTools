using _4RTools.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4RTools.Model
{
    internal class Advertiser
    {
        public string bannerUrl { get; set; }
        public string discordUrl { get; set; }
        public string websiteUrl { get; set; }

        private static System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();



        public Advertiser(string bannerUrl, string discordUrl, string websiteUrl) 
        { 
            this.bannerUrl = bannerUrl;
            this.discordUrl = discordUrl;
            this.websiteUrl = websiteUrl;
        }

        public static List<Advertiser> LoadAdvertiser() {
            List<Advertiser> ads = new List<Advertiser> { };

            try
            {

                var requestAccepts = httpClient.DefaultRequestHeaders.Accept;
                requestAccepts.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.UserAgent.TryParseAdd("request"); //Set the User Agent to "request"
                httpClient.Timeout = TimeSpan.FromSeconds(5);
                var response = httpClient.GetAsync(AppConfig._4RAdvertiserUrl).Result;
                var json = response.Content.ReadAsStringAsync().Result;

                Console.WriteLine(json);
                ads.AddRange(JsonConvert.DeserializeObject<List<Advertiser>>(json));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ads;
        }
    }
}
