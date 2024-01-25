using System.Data.Entity;
using System.Linq.Expressions;

namespace Gym.Data
{
    public class GenericRepository<TEntity> where TEntity : class 
{
    private readonly GymDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository(GymDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _dbSet = _context.Set<TEntity>();
    }

    public IQueryable<TEntity> GetAll()
    {
        return _dbSet;
    }

    public IQueryable<TEntity> GetByCondition(Expression<Func<TEntity, bool>> condition)
    {
        return _dbSet.Where(condition);
    }

    public TEntity GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public void Insert(TEntity entity)
    {
        _dbSet.Add(entity);
    }

    public void Update(TEntity entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
    }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }
        public void Save()
    {
        _context.SaveChanges();
    }
}
}
