

using Divine.Service;
// used: EntityManager
using Divine.Entity;
// used: Hero
using Divine.Entity.Entities.Units.Heroes;

namespace BetterAutoPickv2
{
    public sealed class BetterAutoPickv2 : Bootstrapper
    {
        public Hero? Me { get; set; }

        protected override void OnActivate()
        {
            Me = EntityManager.LocalHero;
            if (Me == null)
            {
                System.Console.WriteLine("hello!");
            }
        }
    }

}
