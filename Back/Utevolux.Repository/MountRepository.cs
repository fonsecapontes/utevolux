using Microsoft.EntityFrameworkCore;

namespace Utevolux.Repository
{
    public class MountRepository : IMountRepository
    {
        private readonly UtevoLuxDbContext _context;

        public MountRepository(UtevoLuxDbContext context)
        {
            _context = context;
        }

        public async Task<List<MountEntity>> GetMounts() => await _context.Mount.ToListAsync();
    }
}
