using Store2Door.Data.Models;
using Store2Door.Repo;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Store2Door.Service
{
    public class UserService:IUserService
    {
        private IRepository<User> userRepository;
        private IRepository<UserProfile> userProfileRepository;

        public UserService(IRepository<User> userRepository, IRepository<UserProfile> userProfileRepository)
        {
            this.userRepository = userRepository;
            this.userProfileRepository = userProfileRepository;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return  await userRepository.GetAll();
        }

        public async Task<User> GetUser(long id)
        {
            return await userRepository.Get(id);
        }

        public void InsertUser(User user)
        {
            userRepository.Insert(user);
        }
        public void UpdateUser(User user)
        {
            userRepository.Update(user);
        }

        public async void DeleteUser(long id)
        {
            UserProfile userProfile = await userProfileRepository.Get(id);
            userProfileRepository.Remove(userProfile);
            User user = await GetUser(id);
            userRepository.Remove(user);
            userRepository.SaveChanges();
        }
    }

}