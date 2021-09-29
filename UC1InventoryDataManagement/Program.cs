using Newtonsoft.Json;
using System;

namespace UC1InventoryDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            FetchJsonForRice fetchJsonForRice = new FetchJsonForRice();
            var data = fetchJsonForRice.Read("L:/Rice.json");
            Console.WriteLine(JsonConvert.SerializeObject(data));

            FetchJsonForWheats fetchJsonForWheats = new FetchJsonForWheats();
            var data1 = fetchJsonForWheats.Read("L:/Wheats.json");
            Console.WriteLine(JsonConvert.SerializeObject(data1));

            FetchJsonForPulses fetchJsonForPulses = new FetchJsonForPulses();
            var data2 = fetchJsonForPulses.Read("L:/Pulses.json");
            Console.WriteLine(JsonConvert.SerializeObject(data2));
        }
    }
}
