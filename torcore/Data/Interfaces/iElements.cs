using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using torcore.Data.Models;

namespace torcore.Data.Interfaces
{
    public interface iElements
    {
        IEnumerable<Element> AllElements { get; }
        IEnumerable<Element> getFavElements { get; }

        Element getObgectElement(int idElement);

    }
}
