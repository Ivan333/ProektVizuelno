using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizuelnoProekt
{
    public class EnemySpaceShip : SpaceShip
    {
        public Direction d {get; set;}
        public EnemySpaceShip(Point p, Image i, int m, int h, SpaceShip.Direction d)
            : base(p, i, m, h)
        {
            this.d = d;
        }
         
        public override void move(Direction d , int mw)
        {
            if (d == Direction.stationary)
            {
                return;
            }
            else if (d == Direction.left)
            {
                position = new Point(position.X - velocity, position.Y);
            }
            else if (d == Direction.right)
            {
                position = new Point(position.X + velocity, position.Y);
            }
        }


        public int isValid(int mw)
        {
            if (position.X <= 0)
                return 1;
            if (position.X >= mw - 2 * Mw)
                return 2;
            return 0;
        }

    }
}
