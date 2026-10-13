using Model;


namespace DataAccess
{
    public class EntityRepository<T> : IRepository<T> where T : class, IDomainObject
    {
        public void Create(T item)
        {
            using (var context = new Context())
            {
                context.Database.EnsureCreated();
                context.Set<T>().Add(item);
                context.SaveChanges();
            }
        }

        public List<T> ReadALL()
        {
            using (var context = new Context())
            {
                context.Database.EnsureCreated();
                return context.Set<T>().OrderBy(x => x.Id).ToList();
            }
        }

        public void Delete(T item)
        {
            using (var context = new Context())
            {
                context.Set<T>().Remove(item);
                context.SaveChanges();
            }
        }
    }
}
