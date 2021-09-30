using System;
using System.Collections.Generic;
using System.Text;

namespace UC2InventoryManagementProgram
{
    public class Rashan
    {
        public List<TypeRice> TypeRice;
        public List<TypePulses> TypePulses;
        public List<TypeWheat> TypeWheat;
    }

    public class TypeWheat
    {
        public string name;
        public int weight;
        public int prices;
    }

    public class TypePulses
    {
        public string name;
        public int weight;
        public int prices;
    }

    public class TypeRice
    {
        public string name;
        public int weight;
        public int prices;
    }
}
