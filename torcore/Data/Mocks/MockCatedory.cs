using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using torcore.Data.Interfaces;
using torcore.Data.Models;

namespace torcore.Data.Mocks
{

    public class MockCategory : iCategories
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category> {
                                new Category{id = 1, nameCategory = "Games", description = "Длинное описание Категории -Игры-"},
                                new Category{id = 2, nameCategory = "Comixes", description = "Длинное описание Категории -Comixes-"},
                                new Category{id = 3, nameCategory = "Pictures", description = "Длинное описание Категории -Картинки-"},
                                new Category{id = 4, nameCategory="Boocks", description = "Длинное описание Категории -Книги-"},
                                new Category{id = 5, nameCategory = "Cartoon", description = "Мультипликационные фильмы"}
                            };
            }
        }


        //public IEnumerable<Element> getFavElements => new List<Element> {
        //        new Element{idElement=1, nameElement = "Duna", idSubCategory = 1, describe = "Описание стратегии Duna", shortDescribe = "Короткое описание стратегии Duna", isFavorite = true}
        //};

        public Category getObgectCategory(int idCategiry)
        {
            throw new NotImplementedException();
        }
    }

    //public class MockSubcategory : iSubCategories
    //{
    //    public IEnumerable<SubCategory> SubCategories => new List<SubCategory>
    //    {
    //        new SubCategory{idSubCategory = 1, nameSubCategory ="Strategy", description = "Длинное описание Подкатегории -Стратегии-", idCategory = 1},
    //        new SubCategory{idSubCategory = 2, nameSubCategory = "Manga", description = "Японские комиксы", idCategory = 2 }
    //    };
    //}
}
