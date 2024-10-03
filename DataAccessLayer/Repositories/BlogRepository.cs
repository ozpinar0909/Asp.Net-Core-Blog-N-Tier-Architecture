using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        CoreContext _coreContext;
        public void Delete(Blog entity)
        {
            _coreContext.Remove(entity);
            _coreContext.SaveChanges();
                    
        }

        public List<Blog> GetAll()
        {
            return _coreContext.Blogs.ToList();
        }

        public Blog GetById(int id)
        {
         return _coreContext.Blogs.Find(id);
        }

        public void Insert(Blog entity)
        {
            _coreContext.Add(entity);
            _coreContext.SaveChanges();
        }

        public void Update(Blog entity)
        {
            _coreContext.Update(entity);
        }
    }
}
