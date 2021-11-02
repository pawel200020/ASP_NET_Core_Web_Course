using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace VideoGameDependency
{
    class Program
    {
        static void Main(string[] args)
        {
            HeroAnyGun hero1 = new HeroAnyGun { Name = "Jonh", Weapon = new Granade { Name = "Granade" } };
            hero1.attack();
            HeroAnyGun hero2 = new HeroAnyGun { 
                Name = "Joe", 
                Weapon = new Gun
                {
                    Name = "Gun1",
                    Bullets = new List<Bullet>
                        {
                            new Bullet { Name = "Shooter", GramsOfPowder = 10 },
                            new Bullet { Name = "Shooter2", GramsOfPowder = 20 },
                            new Bullet { Name = "Shooter3", GramsOfPowder = 30 }
                        }
                }
            };
            hero2.attack();
            hero2.attack();
            hero2.attack();
            hero2.attack();

            //servicecollection is the conatiner of all registredted dependecies
            ServiceCollection services = new ServiceCollection();
            //set default weapon
            services.AddTransient<IWeapon, Granade>(grenade=> new Granade { Name = "explosion" });
            //all new heros will be "Johny by default
            services.AddTransient<IHero, HeroAnyGun>(hero1 => new HeroAnyGun { Name = "Johny", Weapon = hero1.GetService<IWeapon>() });
            ServiceProvider provider = services.BuildServiceProvider();
            var hero3 = provider.GetService<IHero>();
            hero3.attack();
        }
    }
}
