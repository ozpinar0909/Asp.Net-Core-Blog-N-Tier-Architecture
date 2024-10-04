using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

public class GenericRepository<T> : IGenericDal<T> where T : class
{
    private readonly CoreContext _context;
    public GenericRepository()
    {
        _context=new CoreContext(); 
    }
    public void Insert(T entity)
    {
        _context.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        _context.Remove(entity);
        _context.SaveChanges();
    }

    public List<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public T GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public void Update(T entity)
    {
        _context.Update(entity);
        _context.SaveChanges();
    }
}