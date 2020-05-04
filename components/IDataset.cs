using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace lv5analiza.components
{
    interface IDataset
    {
        ReadOnlyCollection<List<string>> GetData();
    }
}
