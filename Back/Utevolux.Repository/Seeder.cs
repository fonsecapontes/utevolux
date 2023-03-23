using Newtonsoft.Json;

namespace Utevolux.Repository
{
    public static class Seeder
    {
        public static void Seed(this UtevoLuxDbContext salesContext)
        {
            if (!salesContext.Creature.Any())
            {
                string json = File.ReadAllText("../creatures_data.json");
                var creatures = JsonConvert.DeserializeObject<List<CreatureEntity>>(json);

                foreach (var creature in creatures)
                {
                    creature.Image = creature.Name.Replace(" ", "_") + ".gif";
                }

                salesContext.AddRange(creatures);

                json = File.ReadAllText("../bosses_data.json");
                var bosses = JsonConvert.DeserializeObject<List<CreatureEntity>>(json);

                foreach (var boss in bosses)
                {
                    boss.Image = boss.Name.Replace(" ", "_") + ".gif";
                    boss.Boss = true;
                }

                salesContext.AddRange(bosses);
            }

            if (!salesContext.Mount.Any())
            {
                string json = File.ReadAllText("../mounts_data.json");
                var mounts = JsonConvert.DeserializeObject<List<MountEntity>>(json);

                foreach (var mount in mounts)
                {
                    mount.Image = mount.Name.Replace(" ", "_") + ".gif";
                }

                salesContext.AddRange(mounts);
            }

            salesContext.SaveChanges();
        }
    }
}
