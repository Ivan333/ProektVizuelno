using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizuelnoProekt
{
    //author: Ivan

    /// <summary>
    /// interface for Attack classes
    /// </summary>
    public interface Attack
    {
        /// <summary>
        /// Moves the attack
        /// </summary>
        void move();

        void detectColision();
        /// <summary>
        /// Draws the attack
        /// </summary>
        /// <param name="g"></param>
        void Draw(Graphics g);
        /// <summary>
        /// Checks is attack out of grid
        /// </summary>
        /// <param name="h">height of grid</param>
        /// <returns>true attack is out of greed false otherwise</returns>
        bool isOutOfRange(int h);
    }
}
