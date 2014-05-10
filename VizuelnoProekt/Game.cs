using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizuelnoProekt
{
    public partial class Game : Form
    {
        public Image img { get; set; }
        public Controller c { get; set; }
        public static readonly int PANEL_WIDTH = 500;
        public static readonly int PANEL_HEIGHT = 500;
        public static readonly int TIMER_INTERVAL = 100;
        public static readonly int WIDTH_SKALE = 20;
        public static readonly int HEIGTH_SKALE = 20;
        public SpaceShip.Direction d { get; set; }
        public int time { get; set; }
        public bool arrowDown { get; set; }
        public bool spaceDown { get; set; }
        public bool leftDown { get; set; }
        public bool rightDown { get; set; }

        public bool timerDown { get; set; }
        public int poeni { get; set; }


        public Game(int level)
        {

            poeni = 0;
            InitializeComponent();
            DoubleBuffered = true;
            this.Width = PANEL_WIDTH;
            this.Height = PANEL_HEIGHT;
            img = Properties.Resources.Pixel_Ship;
            d = SpaceShip.Direction.left;
            time = 0;
            

            PlayerSpaceShip pss = new PlayerSpaceShip(new Point(  PANEL_WIDTH/2 - WIDTH_SKALE , PANEL_HEIGHT - HEIGTH_SKALE * 3), img, WIDTH_SKALE, HEIGTH_SKALE);
            c = new Controller(pss, WIDTH_SKALE, HEIGTH_SKALE, WIDTH_SKALE, PANEL_HEIGHT);
            LevelGenerator lg = new LevelGenerator();
            if(level == 1)
            lg.generateLevel1(c, 3, 3 , WIDTH_SKALE, HEIGTH_SKALE);
            if (level == 2)
                lg.generateLevel2(c, 5, 3, WIDTH_SKALE, HEIGTH_SKALE);
            if (level == 3)
                lg.generateLevel3(c, 15, 5, WIDTH_SKALE, HEIGTH_SKALE);
            timer = new Timer();
            timer.Interval = TIMER_INTERVAL;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            c.Draw(g);
        }
        void timer_Tick(object sender, EventArgs e)
        {
            int a = c.areValidEnemeis(PANEL_WIDTH);
            if (a == 1)
            {
                d = SpaceShip.Direction.right;
            }
            else if (a == 2)
            {
                d = SpaceShip.Direction.left;
            }
            if (time == 1000)
            {
                c.moveEnemy(PANEL_WIDTH, PANEL_HEIGHT, d);
                time = 0;
            }
            else
            {
                time += TIMER_INTERVAL;
            }
            if (timerDown && time % 3 == 0)
            {
                c.addAttack();
            }

            if (spaceDown)
            {
                timerDown = true;
            }
            else
            {
                timerDown = false;
            }
            
            c.addEnemyAttacks();
            c.moveAttacks();
            
            poeni += c.checkColision();
            label1.Text = "Score: " + poeni.ToString();

            Invalidate();
                
                if (c.isWon())
                {
                    String[] st = label1.Text.Split(new char[1]{' '});
                    timer.Stop();
                    Form2 f2 = new Form2(int.Parse(st[1]), "Win");
                    f2.ShowDialog();
                    this.Close();
                }
                if (c.checkIsPlayerDead())
                {
                    timer.Stop();
                    String[] st = label1.Text.Split(new char[1]{' '});
                    Form2 f2 = new Form2(int.Parse(st[1]), "Win");
                    f2.ShowDialog();
                    this.Close();
                }
            
        }


        public Timer timer { get; set; }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                arrowDown = false;
                leftDown = false;
            }
            else if (e.KeyData == Keys.Right)
            {
                arrowDown = false;
                leftDown = false;
            }

            if (e.KeyData == Keys.Space)
            {
                spaceDown = false;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

                
                if (e.KeyData == Keys.Left)
                {
                    arrowDown = true;
                    leftDown = true;
                }
                else if (e.KeyData == Keys.Right)
                {
                    arrowDown = true;
                    rightDown = true;
                }
                if (e.KeyData == Keys.Space && !spaceDown)
                {
                    c.addAttack();
                    spaceDown = true;
                    c.moveAttacks();
                    c.checkColision();       
                }
                if (arrowDown)
                {
                    if(leftDown)
                        c.movePlayer(SpaceShip.Direction.left, PANEL_WIDTH, PANEL_HEIGHT);
                    else c.movePlayer(SpaceShip.Direction.right, PANEL_WIDTH, PANEL_HEIGHT);
                }
                Invalidate();
                
                
            }
        }
    }
