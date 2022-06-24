using System;
using System.Threading.Tasks;

namespace XYB.Data.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        IBetRepository BetRepository { get; }

        Task<bool> ConfirmAsync();
    }
}
