using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10_Part1
{
    internal class Alien
    {

        //public const int SNAKE_ALIEN = 0;
        //public const int OGRE_ALIEN = 1;
        //public const int MARSHALLOW_MAN_ALIEN = 2;

        //public int type;
        public int health; //0 = dead, 100 = full
        public string name;
        public int damage;

        //types of aliens
        //public enum AlienType
        //{
        //    SNAKE,
        //    OGRE,
        //    MARSHMALLOW_MAN
        //}
        //protected AlienType type;

        public Alien()
        {

        }
        public Alien(int health, string name, int damage)
        {
            //this.type = type;
            this.health = health;
            this.name = name;
            this.damage = damage;

        }

        public int getHealth()
        {
            return health;
        }
        public void setHealth(int health)
        {
            this.health = health;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public int getDamage()
        {
            return damage;
        }
        public void setDamage(int damage)
        {
            this.damage = damage;
        }

        public override string ToString()
        {
            return $"{name} (Health: {health}, Damage: {damage})";
        }


    }
}
