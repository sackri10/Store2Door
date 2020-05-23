using Store2Door.Data.Models;
using Store2Door.Repo;
using System.Threading.Tasks;
namespace Store2Door.Service
{
    public class UserProfileService : IUserProfile
    {
        private IRepository<UserProfile> userProfileRepository;

        public UserProfileService(IRepository<UserProfile> userProfileRepository)
        {
            this.userProfileRepository = userProfileRepository;
        }

        public async Task<UserProfile> GetUserProfile(long id)
        {
            return await userProfileRepository.Get(id);
        }
    }
}