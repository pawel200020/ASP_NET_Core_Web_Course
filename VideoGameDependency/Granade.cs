using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameDependency
{
    class Granade : IWeapon
    {
        public string Name { get; set; }

        public void AttackWith()
        {
            Console.WriteLine(Name + " granade is being used for beating all enemies");
        }
    }
}
