using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameDependency
{
    class HeroWithSword
    {
        public string  Name { get; set; }
        public void Attack()
        {
            Sword s1 = new Sword { Name = "Janek" };
            s1.AttackWith();
        }
    }
}
