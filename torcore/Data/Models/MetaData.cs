using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace torcore.Data.Models
{
    public class MetaData
    {
        public int Id { get; set; }
        public string nameMetaData { get; set; }

        public List<Element> Elements { get; set; }
    }
}
