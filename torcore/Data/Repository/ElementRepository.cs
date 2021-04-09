using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using torcore.Data.Interfaces;
using torcore.Data.Models;
using torcore.Data;
using Microsoft.EntityFrameworkCore;

namespace torcore.Data.Repository
{
    public class ElementRepository 
    {
        private readonly AppDBContext appDBContext;

        public ElementRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<Element> Elements => appDBContext.Elements.Include(e => e.SubCategory);

        public IEnumerable<Element> getFavElements => appDBContext.Elements.Include(p => p.SubCategory);
        
        public Element getObgectElement(int idElement)
        {
            throw new NotImplementedException();
        }
    }
}
