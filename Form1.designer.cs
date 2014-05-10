namespace VizuelnoProekt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnScores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(12, 377);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(99, 23);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "Start New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            this.btnNewGame.MouseLeave += new System.EventHandler(this.btnNewGame_MouseLeave);
            this.btnNewGame.MouseHover += new System.EventHandler(this.btnNewGame_MouseHover);
            // 
            // btnInstructions
            // 
            this.btnInstructions.Location = new System.Drawing.Point(364, 426);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(98, 23);
            this.btnInstructions.TabIndex = 2;
            this.btnInstructions.Text = "About the game";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            this.btnInstructions.MouseLeave += new System.EventHandler(this.btnInstructions_MouseLeave);
            this.btnInstructions.MouseHover += new System.EventHandler(this.btnInstructions_MouseHover);
            // 
            // btnScores
            // 
            this.btnScores.Location = new System.Drawing.Point(12, 403);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(98, 23);
            this.btnScores.TabIndex = 3;
            this.btnScores.Text = "High Scores";
            this.btnScores.UseVisualStyleBackColor = true;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            this.btnScores.MouseLeave += new System.EventHandler(this.btnScores_MouseLeave);
            this.btnScores.MouseHover += new System.EventHandler(this.btnScores_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VizuelnoProekt.Properties.Resources.slika1;
            this.ClientSize = new System.Drawing.Size(470, 455);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnScores;
    }
}

