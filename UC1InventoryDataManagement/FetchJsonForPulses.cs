using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UC1InventoryDataManagement
{
    class FetchJsonForPulses
    {
        public Pulses Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    var searializerSettings = new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    };
                    Console.WriteLine(json);
                    return JsonConvert.DeserializeObject<Pulses>(json, searializerSettings);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Problem Read file");
                    return null;
                }
            }
        }
    }
}
