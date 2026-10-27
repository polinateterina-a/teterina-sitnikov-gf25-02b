using Model;


namespace DataAccess
{
    /// <summary>
    /// Репозиторий на Entity Framework: хранит объекты в базе данных SQL Server (LocalDB).
    /// </summary>
    /// <typeparam name="T">Тип доменного объекта.</typeparam>
    public class EntityRepository<T> : IRepository<T> where T : class, IDomainObject, new()
    {
       /// <inheritdoc/>
        public void Create(T item)
        {
            using (var context = new Context())
            {
                context.Database.EnsureCreated();
                context.Set<T>().Add(item);
                context.SaveChanges();
            }
        }

        /// <inheritdoc/>
        public List<T> ReadALL()
        {
            using (var context = new Context())
            {
                context.Database.EnsureCreated();
                return context.Set<T>().OrderBy(x => x.Id).ToList();
            }
        }

        /// <inheritdoc/>
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
