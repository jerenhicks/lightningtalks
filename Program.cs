using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace neolightningtalks
{
    class Program
    {
        static void Main(string[] args)
        {
            LightningTalkOutput();
        }

        async static void LightningTalkOutput()
        {
            HttpClient client = new HttpClient();

            string uri = "https://lightningapi.sandbox.avitureinc.com/lightningTalkRoundService";
            client.BaseAddress = new Uri(uri);
            try {
                HttpResponseMessage response = client.GetAsync("").Result;

                string contentString = await response.Content.ReadAsStringAsync();
                dynamic parsedJson = JsonConvert.DeserializeObject<LightningTalks>(contentString);
                List<string> output = new List<string>();
                foreach (var individualDay in parsedJson.items) {
                    foreach(var slot in individualDay.nonNullSlots()) {
                        output.Add(slot.getOutputString(individualDay.getStartDateTimeObj(), false));
                    }
                }
                await File.WriteAllLinesAsync("lightningtalkoutput.txt", output.ToArray());
            } catch (Exception e) {
                Console.WriteLine("There was an error: " + e);
            }

        }
    }
}
