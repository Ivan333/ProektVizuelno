using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace VizuelnoProekt
{
    

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

        public void addEnemy(EnemySpaceShip s)
        {
            enemies.Add(s);
        }

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

        public void movePlayer(SpaceShip.Direction d, int w, int h)
        {
            player.move(d, w);
        }

        public void moveEnemy(int w, int h, SpaceShip.Direction d)
        {
            foreach (EnemySpaceShip es in enemies)
            {
                es.move(d,w);
            }
        }

        public void addAttack()
        {
            pAttacks.Add(new PlayerAttack(player, skaleWidth, Height));
            
        }

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

        public void addEnemyAttacks()
        {
            foreach (EnemySpaceShip es in enemies)
            {
                if(r.Next(100) == 1)
                    eAttacks.Add(new EnemyBlaster(es,velocity,Height));
            }
        }

        public bool isWon()
        {
            return enemies.Count == 0 ? true : false;
        }

    }
}
