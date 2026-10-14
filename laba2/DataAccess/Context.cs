using Microsoft.EntityFrameworkCore;
using Model;
using System.Configuration;

namespace DataAccess
{
    /// <summary>
    /// Контекст Entity Framework: описывает таблицы и подключение к базе данных.
    /// </summary>
    public class Context : DbContext
    {
        /// <summary>
        /// Таблица студентов в базе данных.
        /// </summary>
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
