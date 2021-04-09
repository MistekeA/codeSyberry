using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using torcore.Data.Interfaces;
using torcore.Data.Models;

namespace torcore.Data.Mocks
{
    public class MockSubCategory : iSubCategories

    {
        public IEnumerable<SubCategory> SubCategories
        {
            get
            {
                return new List<SubCategory>
                        {
                            new SubCategory{id = 1, nameSubCategory ="Strategy", description = "Длинное описание Подкатегории -Стратегии-", idCategory = 1},
                            new SubCategory{id = 2, nameSubCategory = "Manga", description = "Японские комиксы", idCategory = 2 },
                            new SubCategory{id = 3, nameSubCategory = "RPG", description = "Role-Playing Game", idCategory = 1},
                            new SubCategory{id = 4, nameSubCategory = "Simulator", description = "Симулятор", idCategory = 1},
                            new SubCategory{id = 5, nameSubCategory = "Sport", description = "Спортивные игры", idCategory = 1},
                            new SubCategory{id = 6, nameSubCategory = "Quest", description ="Квестовые игры", idCategory = 1},
                            new SubCategory{id = 7, nameSubCategory = "Cartoon", description = "Рисованные коминксы", idCategory = 2},
                            new SubCategory{id = 8, nameSubCategory = "Anime", description = "Категория японских рисовонных произведений"}
                        };
            }
        }

        //есть подозрение, что понадобиться прописать обращение к объекту типа SubCategory через его id

    }

}
