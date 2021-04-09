using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using torcore.Data.Interfaces;
using torcore.Data.Models;

namespace torcore.Data.Mocks
{
    public class MockElement : iElements
    {
        private readonly iSubCategories _subcategory = new MockSubCategory();
        public IEnumerable<Element> getFavElements
        {
            get;
        }

        public IEnumerable<Element> AllElements
        {
            get
            {
                return new List<Element> {
                new Element{
                        id =1,
                        nameElement = "Duna",
                        SubCategory = _subcategory.SubCategories.First(),
                        describe = "Описание стратегии Duna",
                        shortDescribe = "Короткое описание стратегии Duna",
                        isFavorite = true,
                        img = "/img/Dune_2000.jpg"
                },
                new Element{
                        id = 2,
                        nameElement = "Последний из бродячих псов",
                        SubCategory = _subcategory.SubCategories.Last(),
                        describe = "ГГ бомж с суперсилой!",
                        shortDescribe = "ГГ - бомж",
                        isFavorite = false,
                        img = "/img/dog.jpg"
                },
                new Element
                {
                        id = 3,
                        nameElement="ANNO_2020",
                        SubCategory = _subcategory.SubCategories.First(),
                        describe = "Крутая экономическая стратежка",
                        shortDescribe = "Экономическая стратежка",
                        isFavorite = false,
                        img = "/img/Anno.jpg"
                },


                new Element
                {
                    id = 4,
                    nameElement = "ARMA 3: ULTIMATE EDITION",
                    SubCategory = _subcategory.SubCategories.First(),
                    describe = "Встаньте на действительную военную службу в Arma 3 Apex и отправьтесь в совершенно новую зону боевых действий. Благодаря своим географическим особенностям архипелаг Таноа в южной части Тихого океана предлагает новые возможности для проведения самых различных военных операций. Наслаждайтесь тактическим геймплеем Arma 3, где передвижения. стрельба и командная работа действительно играют важную роль. Используйте новую технику, оружие и снаряжение, чтобы преодолевать все трудности на незнакомой вражеской территории. Дополнение Apex – это кульминация более чем 15 лет разработки Arma. Получите незабываемые впечатления от игры на ПК. Испытайте прилив адреналина во время заработанных потом и кровью побед, откройте для себя постоянно развивающуюся платформу с множеством официальных дополнений и созданным игроками контентом и присоединитесь к многотысячному сообществу Arma, чтобы познакомиться с людьми со всего света. Аутентичная, открытая и разнообразная — это образцовая военная игра для ПК. Добро пожаловать в Arma 3 Apex!",
                    shortDescribe = "Встаньте на действительную военную службу в Arma 3 Apex и отправьтесь в совершенно новую зону боевых действий. ",
                    isFavorite = true,
                    img = "/img/arma3.png"
                }
            };
            }
        }


        public Element getObgectElement(int idElement)
        {
            throw new NotImplementedException();
        }
    }

}
