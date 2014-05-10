using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizuelnoProekt
{
    public partial class Form2 : Form
    {
        public int score { get; set; }
        public Form2(int skor, string text)
        {
            InitializeComponent();
            label2.Text = "You have " + skor.ToString();
            this.score = skor;
        }

        private void txtboxIme_TextChanged(object sender, EventArgs e)
        {
            if (txtboxIme.Text.Trim().Length <= 2 || txtboxIme.Text.Trim().Length  >= 20)
            {
                errorProvider1.SetError(txtboxIme, "Imeto mora da sodrzi najmalku 2 karakteri, a najmnogu 20");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\UserScore.mdf;Integrated Security=True";
            SqlConnection oCon = new SqlConnection(conString);
            //Insert into "Table" (id,name,skor) values (1,'Ivan',200);
            string insertUser = "insert into \"Table\" (name,skor) values (" + "'" 
            + txtboxIme.Text + "' , " + score + " );";
            
            try
            {
                oCon.Open();
                if (oCon.State != ConnectionState.Open)
                {
                    lblPoraka.Text = "NE E OTVORENA";
                }
                SqlCommand oCommand = new SqlCommand(insertUser, oCon);
                
                oCommand.ExecuteNonQuery();
                lblPoraka.Text = "Регистрацијата е успешна";
                lblPoraka.ForeColor = Color.Green;

            }
            catch (Exception ex)
            {
                lblPoraka.Text = ex.Message;
            }
            finally
            {
                oCon.Close();
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
