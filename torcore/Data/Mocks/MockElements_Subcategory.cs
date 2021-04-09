using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using torcore.Data.Interfaces;
using torcore.Data.Models;

namespace torcore.Data.Mocks
{
    public class MockElements_Subcategory : iElemSubCategory
    {
        public IEnumerable<idSubCategory_idElement> elem_subcat
        {
            get
            {
                return new List<idSubCategory_idElement> {
                    new idSubCategory_idElement{
                        idElement = 1,
                        idSubCategory = 1
                    },

                    new idSubCategory_idElement{
                        idElement = 2,
                        idSubCategory = 8
                    },
                    new idSubCategory_idElement
                    {
                        idElement = 3,
                        idSubCategory = 1
                    },
                    new idSubCategory_idElement
                    {
                        idElement = 4,
                        idSubCategory = 4
                    }
                };
            }
        }
    }
}
