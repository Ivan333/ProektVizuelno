using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizuelnoProekt
{
    public abstract class SpaceShip
    {
        public Point position { get; set; }
        public int velocity { get; set; }
        public Image pic { get; set; }
        public int Mh { get; set; }
        public int Mw { get; set; }
        public Attack attack { get; set; }

        public enum Direction
        {
            left,
            right,
            stationary
        }
        public abstract void move(Direction d, int mw);
        public SpaceShip(Point p, Image i, int w, int h) 
        {
            position = p;
            pic = i;
            velocity = w;
            Mh = h;
            Mw = w;
        }



        public void draw(Graphics g, int widht = 0,int height = 0)
        {
            g.DrawImage(pic, position.X, position.Y,widht,height);
        }


    }
}
