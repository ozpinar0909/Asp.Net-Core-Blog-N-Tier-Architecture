using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{

    public class CategoryRepository : ICategoryDal
    {
        CoreContext _coreContext;
        public void Delete(Category entity)
        {
            _coreContext.Remove(entity);
            _coreContext.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return _coreContext.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _coreContext.Set<Category>().Find(id);
        }

        public void Insert(Category entity)
        {
            _coreContext.Add(entity);
            _coreContext.SaveChanges();
        }

        public void Update(Category entity)
        {
            _coreContext.Update(entity);
            _coreContext.SaveChanges();
        }
    }
}

