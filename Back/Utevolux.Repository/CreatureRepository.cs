using Microsoft.EntityFrameworkCore;

namespace Utevolux.Repository
{
    public class CreatureRepository : ICreatureRepository
    {
        private readonly UtevoLuxDbContext _context;

        public CreatureRepository(UtevoLuxDbContext context)
        {
            _context = context;
        }

        public async Task<List<CreatureEntity>> GetCreatures() => await _context.Creature.ToListAsync();
    }
}