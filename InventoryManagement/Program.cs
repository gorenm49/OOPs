using System;

namespace InventoryManagement
{
    public class Program
    {

        string filename = @"D:\Nits\OOPs\InventoryManagement\InventoryData.json";
        InventoryMain inventory = new InventoryMain();

        List<InventoryData> item = new List<InventoryData>();

        inventory.Read(filename);
        inventory.WriteData(filename,item, "RiceList");
    }
}