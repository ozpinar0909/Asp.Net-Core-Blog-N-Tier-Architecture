﻿using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    public class CategoryManager : ICategoryService
    {
     EfCategoryRepository _efCategoryRepository;
        public CategoryManager()
        {
                _efCategoryRepository = new EfCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
        _efCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
           _efCategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
           _efCategoryRepository.Update(category);
        }

        public Category GetById(int  id)
        {
          return  _efCategoryRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return _efCategoryRepository.GetAll();
        }
    }
}
