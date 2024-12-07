using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10_Part1
{
    internal class OgreAlien:Alien
    {

        OgreAlien()
        {
            health = 0;
            name = "";
            damage = 0;
        }


        public OgreAlien(int health, string name)
        {
            setDamage(5);
            setHealth(health);
            setName(name);
        }

        public override string ToString()
        {
            return $"OgreAlien: " + name + ", health:" + health + ", damage:" + damage;
        }

    }
}
