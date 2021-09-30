using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UC2InventoryManagementProgram
{
    class FetchJsonForRashan
    {
        public Rashan Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Rashan>(json);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Problem Reading file");
                    return null;
                }
            }
        }
    }
}
