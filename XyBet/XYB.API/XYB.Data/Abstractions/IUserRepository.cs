using System.Threading.Tasks;
using XYB.Data.Entities;

namespace XYB.Data.Abstractions
{
    public interface IUserRepository : IRepository<AppUser>
    {
        Task<AppUser> GetByUserNameAsync(string name);
    }
}
