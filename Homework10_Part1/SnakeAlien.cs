using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10_Part1
{
    internal class SnakeAlien:Alien
    {

        SnakeAlien() {
            health = 0;
            name = "";
            damage = 0;
        }

       
        public SnakeAlien(int health, string name)
        {
            setDamage(10);
            setHealth(health);
            setName(name);
        }

        public override string ToString()
        {
            return $"SnakeAlien: " + name + ", health:" + health + ", damage:" + damage;
        }


    }


}
