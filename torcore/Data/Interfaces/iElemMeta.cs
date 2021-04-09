using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using torcore.Data.Models;

namespace torcore.Data.Interfaces
{
    public interface iElemMeta
    {
        IEnumerable<idElement_idMetaData> idElement_IdMetaDatas { get; }
    }
}
