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
    public class EnemyBlaster : Attack
    {
        public SoundPlayer soundEnemyAttack;
        public Point position { get; set; }
        public int velocity { get; set; }
        public int Height { get; set; }

        public EnemyBlaster(EnemySpaceShip p, int v, int h)
        {
            position = new Point(p.position.X + v/2, p.position.Y + 2);
            velocity = v;
            Height = h;

            
            Assembly assembly;
            assembly = Assembly.GetExecutingAssembly();

            soundEnemyAttack = new SoundPlayer(assembly.GetManifestResourceStream
                (@"VizuelnoProekt.Sound.enemyBlaster.wav"));
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
