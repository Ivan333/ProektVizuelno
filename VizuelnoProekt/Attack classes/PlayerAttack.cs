﻿using System;
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
    /// Player attack class
    /// </summary>
    /// 
    public class PlayerAttack : Attack
    {
        public Point position { get; set; }
        public int velocity { get; set; }
        public int Height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p">PlayerSpaseship objekt</param>
        /// <param name="v">velocity of attack</param>
        /// <param name="h">height of grid</param>        
        public PlayerAttack(PlayerSpaceShip p, int v, int h)
        {
            SoundPlayer soundPlayerAttack;

            soundPlayerAttack = new SoundPlayer(Resource1.playerBlaster);
            soundPlayerAttack.Play();


            position = new Point(p.position.X + v/2, p.position.Y + 2);
            velocity = v;
            Height = h;
            
        }

        public void move()
        {
            position = new Point(position.X, position.Y - velocity);
        }

        /// <summary>
        /// Checks for colision with enemy
        /// </summary>
        /// <param name="p">player spaceship</param>
        /// <param name="skale">skale of player spaceship</param>
        /// <returns>true if attack has collided with player</returns>
        public bool detectColisionWithEnemy(EnemySpaceShip p, int skale)
        {
            if(position.Y <= p.position.Y + skale && position.X >= p.position.X && position.X <= p.position.X + skale)
                return true;
            return false;
        }


        public void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Red), position.X, position.Y,2,6);
        }


        public void detectColision()
        {
            throw new NotImplementedException();
        }

        public bool isOutOfRange(int h)
        {
            if (position.Y <= 0)
                return true;
            return false;
        }

    }
}
