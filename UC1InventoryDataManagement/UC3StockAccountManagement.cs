using System;

namespace UC3StockAccountManagement
{
    class Program
    {
        private int numStocks;
        private string shareName;
        private int numShare;
        private int sharePrice;
        public int _numStocks
        {
            set
            {
                this.numStocks = value;
            }
            get
            {
                return this.numStocks;
            }
        }
        public string _shareName
        {
            set
            {
                this.shareName = value;
            }
            get
            {
                return this.shareName;
            }
        }
        public int _numShare
        {
            set
            {
                this.numShare = value;
            }
            get
            {
                return this.numShare;
            }
        }
        public int _sharePrice
        {
            set
            {
                this.sharePrice = value;
            }
            get
            {
                return this.sharePrice;
            }
        }
        static void Main(string[] args)
        {
            //N number of Stocks, for Each Stock Read In the Share Name, Number of Share, and Share Price
            Program obj = new Program();
            obj.numShare = 10;
            obj.numStocks = 4;
            obj.shareName = "Special Stock";
            obj.sharePrice = 267;
            Console.WriteLine(obj.shareName + " is : " + obj.numShare * obj.numStocks * obj.sharePrice);
        }
    }
}
