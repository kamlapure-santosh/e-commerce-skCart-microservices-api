using Microsoft.EntityFrameworkCore;
using Orders.Core.Entities;

namespace Orders.Data
{
    public  interface IUserProfileRepository
    {
        Task<UserProfile?> GetUserProfileAsync(string adObjId);
    }
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly SkCartDbContext _dbContext;

        public UserProfileRepository(SkCartDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<UserProfile?> GetUserProfileAsync(string adObjId)
        {
            return _dbContext.UserProfiles.FirstOrDefaultAsync(propa => propa.AdObjId == adObjId);
        }
    }
}
