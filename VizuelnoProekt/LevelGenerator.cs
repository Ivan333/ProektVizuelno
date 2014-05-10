using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizuelnoProekt
{
    class LevelGenerator
    {



        public LevelGenerator()
        {

        }

        public void generateLevel3(Controller c, int visina, int sirina,int widthSk, int heigthSk)
        {
            for (int i = 0; i < visina; i++)
            {
                for (int j = 0; j < sirina; j++)
                {
                    c.addEnemy(new EnemySpaceShip(new Point(i * widthSk + widthSk, j * heigthSk + heigthSk), Properties.Resources.Alien_in_spaceship, widthSk, heigthSk, SpaceShip.Direction.left));
                }
            }
        }
        public void generateLevel2(Controller c, int visina, int sirina, int widthSk, int heigthSk)
        {
            for (int i = 0; i < visina; i++)
            {
                for (int j = 0; j < sirina; j++)
                {
                    if(i % 2 == 0)
                    c.addEnemy(new EnemySpaceShip(new Point(i * widthSk + widthSk, j * heigthSk + heigthSk), Properties.Resources.Alien_in_spaceship, widthSk, heigthSk, SpaceShip.Direction.left));

                }
            }
        }
        public void generateLevel1(Controller c, int visina, int sirina, int widthSk, int heigthSk)
        {
            for (int i = 0; i < visina; i++)
            {
                c.addEnemy(new EnemySpaceShip(new Point(i * widthSk + widthSk, heigthSk + heigthSk), Properties.Resources.Alien_in_spaceship, widthSk, heigthSk, SpaceShip.Direction.left));
            }
        }


    }
}
