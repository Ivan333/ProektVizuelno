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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //listBox1.Text = op.opis;//ima problem neso ne go prikazuva tekstot...
            // Ivan : znam listbox si stavil.
            textBox1.Text = "Играта е базирана на познатата аркадна видое игра Space Invaders. Играва се содржи од три нивоа секое со разлицна тезина. Целта е да се уништат непријателските вселенски бродови, а со тоа и да се освојат што повеке поени. Контроли: Спејс е за пукање, левац и десна стрелка од тастатурата служат за движење лево или десно.";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
