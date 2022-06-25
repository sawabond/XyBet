using System;
using System.Threading.Tasks;

namespace XYB.Data.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        IBetRepository BetRepository { get; }

        IUserRepository UserRepository { get; }

        Task<bool> ConfirmAsync();
    }
}
