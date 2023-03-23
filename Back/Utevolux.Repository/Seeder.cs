﻿using Newtonsoft.Json;

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

                salesContext.SaveChanges();
            }

            if (!salesContext.Mount.Any())
            {
                var creatures = new List<MountEntity>()
                {
                    new MountEntity() {Name = "Mount 1", Image = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"},
                    new MountEntity() {Name = "Mount 2", Image = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"},
                    new MountEntity() {Name = "Mount 3", Image = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"}
                };
                salesContext.AddRange(creatures);
                salesContext.SaveChanges();
            }
        }
    }
}
