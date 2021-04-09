using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Mvc;
using torcore.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using torcore.ViewModels;

namespace torcore.Controllers
{
    public class ElementsController : Controller
    {
        private readonly iElements _elements;
        private readonly iSubCategories _subCategories;
        private readonly iCategories _categories;
        private readonly iMetaDatas _metaDatas;
        //private readonly iElemSubCategory _elemSubCategory;
        //private readonly iElemMeta _elemMeta;

        public ElementsController(iCategories iCategories, iSubCategories iSubCategories, iElements iElements, iMetaDatas iMetaDatas/*, iElemMeta iElemMeta, iElemSubCategory iElemSubCategory*/)
        {
            _categories = iCategories;
            _subCategories = iSubCategories;
            _elements = iElements;
            _metaDatas = iMetaDatas;
            //_elemMeta = iElemMeta;
            //_elemSubCategory = iElemSubCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Титул Элементов";
            var element = _elements.AllElements;

            ElementsListViewModel sending_obj = new ElementsListViewModel();
            sending_obj.allElements = _elements.AllElements;
            sending_obj.elementCategory = "Элементы";
            sending_obj.allMetaDatas = _metaDatas.allMtaDatas;
            

            //ElementsViewListModels obj = new ElementsViewListModels();
            //obj.allElements = _elements.AllElements;
            //obj.currCategory = "Стратегии";
            //return View(obj);
            return View(sending_obj);
        }
    }

}
