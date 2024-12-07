using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AlienPack alienPack = new AlienPack(3);
            AlienPack alienPack2;




            SnakeAlien snakeAlien = new SnakeAlien(100, "Snake1 ");
            OgreAlien ogreAlien = new OgreAlien(100, "Ogre1 ");
            MarshmallowmanAlien marshmallowmanAlien = new MarshmallowmanAlien(100, "Marshmallow1");
            //add snake alien to alien pack
            alienPack.AddAlien(snakeAlien, 0);
            //add ogre alien to alien pack
            alienPack.AddAlien(ogreAlien, 1);
            //add marshmallowman alien to alien pack
            alienPack.AddAlien(marshmallowmanAlien, 2);
            Console.WriteLine( alienPack);
            Console.WriteLine("Total damage = " + alienPack.CalculateDamage());

        }
    }
}
