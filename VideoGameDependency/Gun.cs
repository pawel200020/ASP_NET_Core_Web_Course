using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameDependency
{
    class Gun : IWeapon
    {
        public string Name { get; set; }
        public List<Bullet> Bullets { get; set; }

        public void AttackWith()
        {
            if (Bullets.Count > 0)
            {
                Console.WriteLine(Name + " fires around called " + Bullets[0].Name);
                Bullets.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("Gun has no bullets");
            }
        }
    }
}
