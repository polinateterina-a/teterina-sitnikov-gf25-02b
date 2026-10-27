using Dapper;
using Microsoft.Data.SqlClient;
using Model;
using System.Configuration;

namespace DataAccess
{
    /// <summary>
    /// Репозиторий на Dapper: выполняет SQL-запросы к базе данных напрямую
    /// </summary>
    /// <typeparam name="T"> Тип доменного объекта. </typeparam>
    public class DapperRepository<T> : IRepository<T>
        where T : class, IDomainObject, new()
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        /// <inheritdoc/>
        public void Create(T item)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                if (item is Student student)
                {
                    string sql = @"
                        INSERT INTO Students (Name, Speciality, [Group])
                        VALUES (@Name, @Speciality, @Group)";

                    connection.Execute(sql, student);
                }
                else
                {
                    throw new NotSupportedException(
                        "Этот тип объекта не поддерживается.");
                }
            }
        }

        /// <inheritdoc/>
        public List<T> ReadALL()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                if (typeof(T) == typeof(Student))
                {
                    string sql = @"
                        SELECT Id, Name, Speciality, [Group]
                        FROM Students
                        ORDER BY Id";

                    return connection.Query<T>(sql).ToList();
                }

                throw new NotSupportedException(
                    "Этот тип объекта не поддерживается.");
            }
        }

        /// <inheritdoc/>
        public void Delete(T item)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                if (item is Student student)
                {
                    string sql = "DELETE FROM Students WHERE Id = @Id";
                    connection.Execute(sql, new { student.Id });
                }
                else
                {
                    throw new NotSupportedException(
                        "Этот тип объекта не поддерживается.");
                }
            }
        }
    }
}
