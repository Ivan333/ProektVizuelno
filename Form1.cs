using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace VizuelnoProekt
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            soundPlayer = new SoundPlayer("pesna.wav");
            //Form1.MaximizeBox = false;
            // nemoze so mouse da se zgolemuva no Maximase seuste raboti,a naredbava Form1.MaximazeBox ne mi ja prifakase neso,nez zaso.
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           soundPlayer.PlayLooping();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            LevelPicker lp = new LevelPicker();
            soundPlayer.Stop();
            lp.ShowDialog();
            
            
            soundPlayer.PlayLooping();
        }

        private void btnNewGame_MouseHover(object sender, EventArgs e)
        {
            btnNewGame.ForeColor = Color.Green;
        }

        private void btnNewGame_MouseLeave(object sender, EventArgs e)
        {
            btnNewGame.ForeColor = Color.Black;
        }

        private void btnInstructions_MouseHover(object sender, EventArgs e)
        {
            btnInstructions.ForeColor = Color.Green;
        }

        private void btnInstructions_MouseLeave(object sender, EventArgs e)
        {
            btnInstructions.ForeColor = Color.Black;
        }

        private void btnScores_MouseHover(object sender, EventArgs e)
        {
            btnScores.ForeColor = Color.Green;
        }

        private void btnScores_MouseLeave(object sender, EventArgs e)
        {
            btnScores.ForeColor = Color.Black;
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            Application.Exit();
            

        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            
            HighScores h = new HighScores();
            h.ShowDialog();
        }

       
   
    

        
    }
}
