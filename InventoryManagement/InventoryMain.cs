namespace InventoryManagement
{
    public class InventoryMain
    {
        
        List<InventoryData> wheatList = new List<InventoryData>();
        List<InventoryData> riceList = new List<InventoryData>();
        List<InventoryData> pulsesList = new List<InventoryData>();

        public InventoryFactory factory = new InventoryFactory();

        public void Read(string filepath)
        {
            try
            {
                using(StreamReader reader  = new StreamReader(filepath))
                {
                    var json = reader.ReadToEnd();
                    var isAvailable = JsonConvert.DeserializeObject<InventoryFactory>(json);
                  

                    foreach (var item in isAvailable)
                    {
                        if (item.Key.contains("WheatList"))
                        {
                            wheatList = item.value;
                        }

                       if (item.Key.contains("RiceList"))
                        {
                            riceList = item.value;
                        }

                        if (item.Key.contains("PulsesList"))
                        {
                            pulsesList = item.value;
                        }

                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Exception Occured...."+ex.Message);
            }
        }

        public void WriteData(string filepath, InventoryData idata, string Key)
        {
            if (Key == "WheatList")
            {
                wheatList.Add(idata);
            }
            if (Key == "RiceList")
            {
                riceList.Add(idata);
            }
            if (Key == "PulsesList")
            {
                pulsesList.Add(idata);
            }

            factory.WheatList = wheatList;
            factory.RiceList = riceList;
            factory.PulsesList = pulsesList;

            var getJson = JsonConvert.serializeObject(factory);
            StreamWriter writerData = new StreamWriter();
            writerData.Write(getJson);
        }
    }
}

