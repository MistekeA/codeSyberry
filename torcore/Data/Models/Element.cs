using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace torcore.Data.Models
{
    public class Element
    {
        public int id { get; set; }
        public string nameElement { get; set; }
        public int idSubCategory { get; set; }
        public string describe { get; set; }
        public string shortDescribe { get; set; }
        public bool isFavorite { get; set; }
        public string img { get; set; }

        public virtual SubCategory SubCategory { get; set; }
        public List<MetaData> MetaDatas { get; set; }

    }
}
