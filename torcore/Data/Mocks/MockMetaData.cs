using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using torcore.Data.Interfaces;
using torcore.Data.Models;

namespace torcore.Data.Mocks
{
    public class MockMetaData : iMetaDatas
    {
        public IEnumerable<MetaData> allMtaDatas
        {
            get
            {
                return new List<MetaData>
                {
                    new MetaData
                    {
                       Id = 1,
                       nameMetaData = "Дата Выхода"
                    },

                    new MetaData
                    {
                        Id = 2,
                        nameMetaData = "Дата загрузки"
                    },

                    new MetaData
                    {
                        Id = 3,
                        nameMetaData = "Объем архива"
                    },

                    new MetaData
                    {
                        Id = 4,
                        nameMetaData="Язык издания"
                    }
                };
            }
        }

       
        public MetaData MetaData(int idMetaData)
        {
            throw new NotImplementedException();
        }
    }
}
