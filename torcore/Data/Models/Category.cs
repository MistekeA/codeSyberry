 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace torcore.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string nameCategory { get; set; }
        public string description { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }
}
