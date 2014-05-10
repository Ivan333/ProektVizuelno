using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizuelnoProekt
{
    public interface Attack
    {
        void move();
        void detectColision();
        void Draw(Graphics g);
        bool isOutOfRange(int h);
    }
}
