namespace Utevolux.Repository
{
    public interface ICreatureRepository
    {
        Task<List<CreatureEntity>> GetCreatures();
        Task<List<CreatureEntity>> GetBosses();
    }
}
