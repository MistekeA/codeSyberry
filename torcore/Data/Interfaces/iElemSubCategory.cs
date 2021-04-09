using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using torcore.Data.Models;

namespace torcore.Data.Interfaces
{
    public interface iElemSubCategory
    {
        IEnumerable<idSubCategory_idElement> elem_subcat { get; }
    }
}
