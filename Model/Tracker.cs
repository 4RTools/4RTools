using _4RTools.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _4RTools.Model
{
    sealed class TrackerSingleton
    {
        private static Tracker _tracker;

        public static Tracker Instance() { 
            if(_tracker == null)
                _tracker = new Tracker();

            return _tracker;
        }
    }

    class TrackerData
    {
        public string action { get; set; }
        public string label { get; set; }
        public string category { get; set; }

        public TrackerData(string action, string label, string category)
        {
            this.action = action;
            this.label = label;
            this.category = category;
        }
    }

    internal class Tracker
    {
        private HttpClient _httpClient;

        public Tracker()
        {
            this._httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(10);
        }

        public async void SendEvent(string action, string category, string label)
        {
            try
            {
                TrackerData tD = new TrackerData(action, label, category);
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri(AppConfig._4RApiHost + "/analytics/public/sendMetrics"),
                    Method = HttpMethod.Post,
                    Content = new StringContent(JsonConvert.SerializeObject(tD), Encoding.UTF8, "application/json")
                };
                await this._httpClient.SendAsync(request);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
                
          
        }
    }
}
