using Store2Door.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Store2Door.Service
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(long id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(long id);
    }
}