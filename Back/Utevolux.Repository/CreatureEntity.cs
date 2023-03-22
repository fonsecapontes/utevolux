namespace Utevolux.Repository
{
    public class CreatureEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; } = string.Empty;
        public bool Boss { get; set; }
        public int Class { get; set; }
    }
}
