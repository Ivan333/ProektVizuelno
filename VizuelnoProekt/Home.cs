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
using System.Reflection;
using System.IO;


namespace VizuelnoProekt
{
    //author: Ivan

    /// <summary>
    /// Starscreen Form
    /// </summary>
    public partial class Home : Form
    {
        private SoundPlayer soundPlayer;
        public Home()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //Pesnata treba nekako da se vcita preku metod od clasata Song,probaj importni-ja bibliotekata Microsoft.Xna.Framework.Media

            Assembly assembly;
            assembly = Assembly.GetExecutingAssembly();
            
            soundPlayer = new SoundPlayer(Resource1.pesna);
            soundPlayer.PlayLooping(); 
            //Form1.MaximizeBox = false;
            // nemoze so mouse da se zgolemuva no Maximase seuste raboti,a naredbava Form1.MaximazeBox ne mi ja prifakase neso,nez zaso.
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
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
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            
            HighScores h = new HighScores();
            h.ShowDialog();
        }

       
   
    

        
    }
}
