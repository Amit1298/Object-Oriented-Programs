using System;

namespace UC2InventoryManagementProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            FetchJsonForRashan fetchJsonforRashan = new FetchJsonForRashan();
            Rashan rashanData = fetchJsonforRashan.Read("L:/Rashan.json");
            for (int i = 0; i < rashanData.TypeRice.Count; i++)
            {
                var nameRice = rashanData.TypeRice[i].name;
                var weightRice = rashanData.TypeRice[i].weight;
                var pricesRice = rashanData.TypeRice[i].prices;
                Console.WriteLine(nameRice + "=" + (weightRice * pricesRice));
            }
            Console.WriteLine("-------------------------------------------");

            for (int j = 0; j < rashanData.TypeWheat.Count; j++)
            {
                var nameWheat = rashanData.TypeWheat[j].name;
                var weightWheat = rashanData.TypeWheat[j].weight;
                var pricesWheat = rashanData.TypeWheat[j].prices;
                Console.WriteLine(nameWheat + "=" + (weightWheat * pricesWheat));
            }

            Console.WriteLine("-------------------------------------------");
            for (int k = 0; k < rashanData.TypeRice.Count; k++)
            {
                var namePulses = rashanData.TypePulses[k].name;
                var weightPulses = rashanData.TypePulses[k].weight;
                var pricesPulses = rashanData.TypePulses[k].prices;
                Console.WriteLine(namePulses + "=" + (weightPulses * pricesPulses));
            }

        }
    }
}
