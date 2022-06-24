using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Threading.Tasks;
using XYB.Data.Abstractions;
using XYB.Data.Repositories;

namespace XYB.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            BetRepository = new BetRepository(context);
        }

        public IBetRepository BetRepository { get; private set; }

        public async Task<bool> ConfirmAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
