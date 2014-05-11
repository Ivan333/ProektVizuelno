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
    //author: Ivan

    /// <summary>
    /// Klasa za prikazuvanje na rezultati od baza
    /// </summary>
    public partial class HighScores : Form
    {
        public HighScores()
        {
            InitializeComponent();
        }

        private void HighScores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userScoreDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.userScoreDataSet.Table);
            // TODO: This line of code loads data into the 'userScoreDataSet.Table' table. You can move, or remove it, as needed.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void fillBy1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
