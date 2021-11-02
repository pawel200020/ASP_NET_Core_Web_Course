using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameDependency
{
    class HeroAnyGun: IHero
    {
        public string Name { get; set; }
        public IWeapon Weapon { get; set; }

        public void attack()
        {
            Console.WriteLine(Name + " prepares to attack");
            Weapon.AttackWith();
        }
    }
}
