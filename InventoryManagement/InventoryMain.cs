namespace InventoryManagement
{
    public class InventoryMain
    {
        public void Read(string filepath)
        {
            try
            {
                using(StreamReader reader  = new StreamReader(filepath));
                {
                    var json = reader.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<InventoryData>>(json);
                    System.Console.WriteLine("name \t price \t weight \t total amount ");

                    foreach (var item in items)
                    {
                        System.Console.WriteLine(item.Name+"\t"+item.Price+"\t"+item.Weight+"\t"+item.Price*item.Weight);
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Exception Occured...."+ex.Message);
            }
        }
    }
}

