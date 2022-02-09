using System;

namespace InventoryManagement
{
    public class Program
    {

        string filename = @"D:\Nits\OOPs\InventoryManagement\InventoryData.json";
        InventoryMain inventory = new InventoryMain();

        inventory.Read(filename);
    }
}