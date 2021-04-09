using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using torcore.Data.Models;

namespace torcore.ViewModels
{
    public class ElementsListViewModel
    {
        public IEnumerable<Element> allElements { get; set; }
        public IEnumerable<MetaData> allMetaDatas { get; set; }
        public string elementCategory { get; set; }
    }
}
