using Store2Door.Data.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Store2Door.Repo
{
    public interface IRepository<T> where T : BaseEntity
    {

        Task<IEnumerable<T>> GetAll();
        Task<T> Get(long id);
         void Insert(T entity);
         void Update(T entity);
         void  Delete(T entity);
         void Remove(T entity);
         void SaveChanges();

    }
}