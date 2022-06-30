using System.Collections.Generic;
using XYB.Data.Entities;

namespace XYB.API.Services.Abstractions
{
    public interface ITokenService
    {
        string CreateToken(AppUser user, ICollection<string> roles);
    }
}
