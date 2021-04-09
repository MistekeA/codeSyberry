using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace torcore.Data.Models
{
    public class SubCategory
    {
        public int id { get; set; }
        public string nameSubCategory { get; set; }
        public int idCategory { get; set; }
        public string description { get; set; }

        public virtual Category Category { get; set; }
        public List<Element> Elements { get; set; }

    }
}
