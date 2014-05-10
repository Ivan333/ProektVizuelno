using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizuelnoProekt
{
    public class PlayerSpaceShip : SpaceShip 
    {
        public PlayerSpaceShip(Point p, Image i, int w, int h) : base(p,i,w,h)
        {
            this.velocity = 20;
        }

        public override void move(Direction d, int mw)
        {
        
            if (d == Direction.stationary)
            {
                return;
            }
            if(!(position.X <= 0))
            if (d == Direction.left)
            {
                position = new Point(position.X - velocity, position.Y);
            }
            if(!(position.X >= mw - 2*Mw))
            if (d == Direction.right)
            {
                position = new Point(position.X + velocity, position.Y);
            }

        }
        /*
        public void deceerate(Direction d, int mw)
        {
            int velocity = 20;
            int modif = 10;
            for (int i = 0; i < 3 && velocity > 0; i++)
            {
                velocity = velocity - i * modif;
                modif -= i;
                if (d == Direction.stationary)
                {
                    return;
                }
                if (!(position.X <= 0))
                    if (d == Direction.left)
                    {
                        position = new Point(position.X - velocity, position.Y);
                    }
                if (!(position.X >= mw - 2 * Mw))
                    if (d == Direction.right)
                    {
                        position = new Point(position.X + velocity, position.Y);
                    }
        
            }
        
            
        }
        */

        
    }
}
