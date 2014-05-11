using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizuelnoProekt
{
    //author: Ivan
    class LevelGenerator
    {



        public LevelGenerator()
        {

        }
        /// <summary>
        /// Generates level3
        /// </summary>
        /// <param name="c"></param>
        /// <param name="visina">height of grid</param>
        /// <param name="sirina">width of grid</param>
        /// <param name="widthSk">width of spaceship</param>
        /// <param name="heigthSk">height of spaceship</param>
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

        /// <summary>
        /// Generates level3
        /// </summary>
        /// <param name="c"></param>
        /// <param name="visina">height of grid</param>
        /// <param name="sirina">width of grid</param>
        /// <param name="widthSk">width of spaceship</param>
        /// <param name="heigthSk">height of spaceship</param>
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
        /// <summary>
        /// Generates level3
        /// </summary>
        /// <param name="c"></param>
        /// <param name="visina">height of grid</param>
        /// <param name="sirina">width of grid</param>
        /// <param name="widthSk">width of spaceship</param>
        /// <param name="heigthSk">height of spaceship</param>
        public void generateLevel1(Controller c, int visina, int sirina, int widthSk, int heigthSk)
        {
            for (int i = 0; i < visina; i++)
            {
                c.addEnemy(new EnemySpaceShip(new Point(i * widthSk + widthSk, heigthSk + heigthSk), Properties.Resources.Alien_in_spaceship, widthSk, heigthSk, SpaceShip.Direction.left));
            }
        }


    }
}
