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
    public partial class LevelPicker : Form
    {
        public LevelPicker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game g = new Game(1);
            this.Visible = false;
            g.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game g = new Game(2);
            this.Visible = false;
            g.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game g = new Game(3);
            this.Visible = false;
            g.ShowDialog();
            this.Visible = true;
        }
    }
}
