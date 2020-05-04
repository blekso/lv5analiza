using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace lv5analiza.components
{
    class LoggerProxyDataset : IDataset
    {
        private Dataset dataset;
        private ConsoleLogger logger;
        private string filePath;

        public LoggerProxyDataset(string filePath)
        {
            this.filePath = filePath;
            this.logger = ConsoleLogger.GetInstance();
        }

        public ReadOnlyCollection<List<string>> GetData()
        {
            if (dataset == null)
            {
                dataset = new Dataset(filePath);
            }
            logger.Log("request:");
            return dataset.GetData();
        }
    }
}
