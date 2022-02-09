using System;

namespace StockManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filename = @"D:\Nits\OOPs\StockManagement\StockInventory.json";
            StockManageMain stock = new StockManageMain();

            stock.ReadStock(filename);
        }
    }
}