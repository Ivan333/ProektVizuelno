using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VizuelnoProekt
{

    // author: Ivan
    /// <summary>
    /// Enemy attack class
    /// </summary>
    /// 
    public class EnemyBlaster : Attack
    { 
        public Point position { get; set; }
        public int velocity { get; set; }
        public int Height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p">EnemySpaceship objekt</param>
        /// <param name="v">velocity of attack</param>
        /// <param name="h">height of grid</param>
        public EnemyBlaster(EnemySpaceShip p, int v, int h)
        {
            position = new Point(p.position.X + v/2, p.position.Y + 2);
            velocity = v;
            Height = h;
            SoundPlayer soundEnemyAttack;
            soundEnemyAttack = new SoundPlayer(Resource1.enemyBlaster);
            soundEnemyAttack.Play();
        }


        public void move()
        {
            position = new Point(position.X, position.Y + velocity);
        }

        public void detectColision()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Checks for colision with player
        /// </summary>
        /// <param name="p">player spaceship</param>
        /// <param name="skale">skale of player spaceship</param>
        /// <returns>true if attack has collided with player</returns>
        public bool detectColisionWithEnemy(PlayerSpaceShip p, int skale)
        {
            if (position.Y   >= p.position.Y && position.Y <= p.position.Y + skale   && position.X >= p.position.X && position.X <= p.position.X + skale)
                return true;
            return false;
        }
        
        public void Draw(System.Drawing.Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Black), position.X, position.Y, 2, 6);
        }
        
        public bool isOutOfRange(int h)
        {
            if (position.Y >= h )
                return true;
            return false;
        }
    }
}
