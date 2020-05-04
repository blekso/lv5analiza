using System;
using System.Collections.Generic;
using System.Text;

namespace lv5analiza.components
{
    class DataConsolePrinter
    {
        public void DisplayItems(IDataset proxy)
        {
            IList<List<string>> listdata = proxy.GetData();
            foreach (List<string> liststring in listdata)
            {
                foreach(string str in liststring)
                {
                    Console.Write(str + " ");
                }
                Console.WriteLine("\n");
            }
        } 
    }
}
