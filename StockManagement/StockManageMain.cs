using System;

namespace StockManagement
{
    public class StockManageMain
    {
        public void ReadStock(string filepath)
        {
            try
            {
                using(StreamReader reader = new StreadReader (filepath))
                {
                    var json = reader.ReadtoEnd();
                    var item = JsonConvert.DeserializeObject<List<StockInventory>>(json);
                    System.Console.WriteLine("Stock Name \t Stock Price \t Availability");

                    foreach (var data in item)
                    {
                        System.Console.WriteLine(data.StockName+"\t"+data.StockPrice+"\t"+Availability);
                    }
                }
            }
            catch (System.Exception ex)
            {
                 System.Console.WriteLine("Exception Occured.."+ex.Message);
            }
        }
    }
}