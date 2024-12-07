using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10_Part1
{
    internal class MarshmallowmanAlien:Alien
    {

        MarshmallowmanAlien()
        {
            health = 0;
            name = "";
            damage = 0;
        }


        public MarshmallowmanAlien(int health, string name)
        {
            setDamage(1);
            setHealth(health);
            setName(name);
        }

        public override string ToString()
        {
            return $"MarshamallowmanAlien: " + name + ", health:" + health + ", damage:" + damage;
        }

    }
}
