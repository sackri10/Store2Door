using Store2Door.Data.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Store2Door.Service
{
    public interface IUserProfile
    {
        Task<UserProfile> GetUserProfile(long id);
    }
}