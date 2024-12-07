using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Homework10_Part1
{
    internal class AlienPack
    {
        protected Alien[] aliens;
        protected int count;

        //default constructor
        public AlienPack() { }
        public AlienPack(int numAliens)
        {
            aliens = new Alien[numAliens];
        }

        public void AddAlien(Alien alien, int index)
        {
            aliens[index] = alien;
            count++;
        }
        public Alien[] GetAliens()
        {
            return aliens;
        }

        public int CalculateDamage()
        {
            //int damage = 0;

            //foreach (Alien a in aliens)
            //{
            //    if (a.type == Alien.SNAKE_ALIEN)
            //    {
            //        damage += 10;
            //    }
            //    else if (a.type == Alien.OGRE_ALIEN)
            //    {
            //        damage += 6;
            //    }
            //    else if (a.type == Alien.MARSHALLOW_MAN_ALIEN)
            //    {
            //        damage += 1;
            //    }
            //}
            //return damage;
            int damage = 0;
            for (int i = 0; i < count; i++)
            {
                damage += aliens[i].getDamage();
            }
            return damage;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Alien Pack:");
            for (int i = 0; i < count; i++)
            {
                sb.AppendLine(aliens[i].ToString());
            }
            return sb.ToString();
        }


    }
}
