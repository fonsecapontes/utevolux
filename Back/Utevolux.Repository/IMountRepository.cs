namespace Utevolux.Repository
{
    public interface IMountRepository
    {
        Task<List<MountEntity>> GetMounts();
    }
}
