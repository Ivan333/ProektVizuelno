using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace VizuelnoProekt
{
    // author: Ivan    

    
    public class Controller
    {
        public PlayerSpaceShip player { get; set; }
        public List<EnemySpaceShip> enemies { get; set; }
        public int skaleWidth { get; set; }
        public int skaleHeight { get; set; }
        public List<PlayerAttack> pAttacks { get; set; }
        public List<EnemyBlaster> eAttacks { get; set; }
        
        public int velocity { get; set; }
        public int Height { get; set; }
        Random r { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p">PlayerSpaceship object</param>
        /// <param name="w">width of spaceship</param>
        /// <param name="h">height of spaceship</param>
        /// <param name="v">velocity</param>
        /// <param name="H">height of board</param>
        public Controller(PlayerSpaceShip p, int w, int h, int v, int H)
        {
            enemies = new List<EnemySpaceShip>();
            pAttacks = new List<PlayerAttack>();
            player = p;
            skaleWidth = w;
            skaleHeight = h;
            velocity = v;
            Height = H;
            r = new Random();
            eAttacks = new List<EnemyBlaster>();
            
        }
        /// <summary>
        /// add an enemy
        /// </summary>
        /// <param name="s">EnemySpaceShip to add</param>
        public void addEnemy(EnemySpaceShip s)
        {
            enemies.Add(s);
        }
        /// <summary>
        /// Draws all enemies, player and all attacks
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            if(player != null)
                player.draw(g,skaleWidth,skaleHeight);
            foreach (EnemySpaceShip sp in enemies)
            {
                sp.draw(g, skaleWidth, skaleHeight);
            }
            foreach (PlayerAttack pa in pAttacks)
            {
                pa.Draw(g);
            }
            foreach (Attack item in eAttacks)
            {
                item.Draw(g);
            }
        }
        /// <summary>
        /// Moves player
        /// </summary>
        /// <param name="d">Direction of spaceship</param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        public void movePlayer(SpaceShip.Direction d, int w, int h)
        {
            player.move(d, w);
        }
        /// <summary>
        /// Moves enemy
        /// </summary>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <param name="d"></param>
        public void moveEnemy(int w, int h, SpaceShip.Direction d)
        {
            foreach (EnemySpaceShip es in enemies)
            {
                es.move(d,w);
            }
        }
        /// <summary>
        /// adds player attack;
        /// </summary>
        public void addAttack()
        {
            pAttacks.Add(new PlayerAttack(player, skaleWidth, Height));
            
        }
        /// <summary>
        /// moves all attacks
        /// </summary>
        public void moveAttacks()
        {
            foreach (PlayerAttack at in pAttacks)
            {
                at.move();
            }
            foreach (Attack item in eAttacks)
            {
                item.move();
            }
        }

        /// <summary>
        /// Checks for colison and returns points for player
        /// </summary>
        /// <returns>points for player</returns>
        public int checkColision()
        {
            int poeni = 0;
            for (int i = pAttacks.Count - 1; i >= 0; i--)
            {
                for (int j = enemies.Count - 1; j >= 0; j--)
                {
                    bool b = ((PlayerAttack)pAttacks.ElementAt(i)).detectColisionWithEnemy(enemies.ElementAt(j),skaleHeight);
                    if (b)
                    {
                        enemies.RemoveAt(j);
                        pAttacks.RemoveAt(i);
                        poeni += 100;
                        break;
                    }
                    else if (((PlayerAttack)pAttacks.ElementAt(i)).isOutOfRange(Height))
                    {
                        pAttacks.RemoveAt(i);
                        break;
                    }
                }
            }
            return poeni;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>true if Player is dead</returns>
        public bool checkIsPlayerDead()
        {
            for (int i = eAttacks.Count - 1; i >= 0; i--)
            {
                if (eAttacks.ElementAt(i).detectColisionWithEnemy(player, velocity))
                {
                    return true;
                }
                else if (eAttacks.ElementAt(i).isOutOfRange(Height))
                {
                    eAttacks.RemoveAt(i);
                    break;
                }
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public int areValidEnemeis(int w)
        {
            foreach (EnemySpaceShip et in enemies)
            {
                if (et.isValid(w) != 0)
                {
                    return et.isValid(w);
                }
            }
            return 0;
        }
        /// <summary>
        /// adds enemy attack
        /// </summary>
        public void addEnemyAttacks()
        {
            foreach (EnemySpaceShip es in enemies)
            {
                if(r.Next(100) == 1)
                    eAttacks.Add(new EnemyBlaster(es,velocity,Height));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>true if player has won</returns>
        public bool isWon()
        {
            return enemies.Count == 0 ? true : false;
        }

    }
}
