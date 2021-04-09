using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using torcore.Data.Interfaces;
using torcore.Data.Models;

namespace torcore.Data.Mocks
{
    public class MockElenent_Metadata : iElemMeta
    {
        public IEnumerable<idElement_idMetaData> idElement_IdMetaDatas
        {
            get {
                return new List<idElement_idMetaData>
                    {
                        new idElement_idMetaData
                        {
                           idElement = 1,
                           idMetaData = 1,
                           value =  "2000 год"
                        },

                        new idElement_idMetaData
                        {
                            idElement = 1,
                            idMetaData = 2,
                            value = "11.05.2020"
                        },

                        new idElement_idMetaData
                        {
                            idElement = 1,
                            idMetaData = 3,
                            value = "2 Gb"
                        },

                        new idElement_idMetaData
                        {
                            idElement = 1,
                            idMetaData = 4,
                            value = "Eng"
                        },

                       new idElement_idMetaData
                        {
                           idElement = 2,
                           idMetaData = 1,
                           value =  "2019 год"
                        },

                        new idElement_idMetaData
                        {
                            idElement = 2,
                            idMetaData = 2,
                            value = "11.05.2020"
                        },

                        new idElement_idMetaData
                        {
                            idElement = 2,
                            idMetaData = 3,
                            value = "44 Gb"
                        },

                        new idElement_idMetaData
                        {
                            idElement = 2,
                            idMetaData = 4,
                            value = "Jpn"
                        },

                       new idElement_idMetaData
                        {
                           idElement = 3,
                           idMetaData = 1,
                           value =  "2010 год"
                        },

                        new idElement_idMetaData
                        {
                            idElement = 3,
                            idMetaData = 2,
                            value = "21.04.2020"
                        },

                        new idElement_idMetaData
                        {
                            idElement = 3,
                            idMetaData = 3,
                            value = "3,5 Gb"
                        },

                        new idElement_idMetaData
                        {
                            idElement = 3,
                            idMetaData = 4,
                            value = "Eng"
                        },
                      new idElement_idMetaData
                        {
                           idElement = 4,
                           idMetaData = 1,
                           value =  "2018 год"
                        },

                        new idElement_idMetaData
                        {
                            idElement = 4,
                            idMetaData = 2,
                            value = "20.11.2020"
                        },

                        new idElement_idMetaData
                        {
                            idElement = 4,
                            idMetaData = 3,
                            value = "7 Gb"
                        },

                        new idElement_idMetaData
                        {
                            idElement = 4,
                            idMetaData = 4,
                            value = "Рус"
                        },

                        new idElement_idMetaData
                        {
                            idElement = 4,
                            idMetaData = 4,
                            value = "Eng"
                        }
                    };
                }
        }
    }
}
