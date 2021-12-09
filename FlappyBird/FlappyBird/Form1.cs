using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;




        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            PipeDown.Left -= pipeSpeed;
            PipeTop.Left -= pipeSpeed;
            ScoreText.Text = "Score: " + score;
        
          if(PipeDown.Left < -50)
          {
                PipeDown.Left = 800;
                score++;
          }
          
            
          if(PipeTop.Left < -50)
          {
                PipeTop.Left = 800;
                score++;
          }
        
          if(Bird.Bounds.IntersectsWith(PipeDown.Bounds) ||
             Bird.Bounds.IntersectsWith(PipeTop.Bounds) ||
             Bird.Bounds.IntersectsWith(Ground.Bounds)
             )
          { 
                endGame();
          }


        
        }


        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
         if(e.KeyCode == Keys.Space)
         {
                gravity = -15;
         }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }
      private void endGame()
      {
            GameTimer.Stop();
            ScoreText.Text += " Game Over! ";
      }
        
    
    }
}




//Code tutorial link: https://www.youtube.com/watch?v=yUCCv-sFUDQ&t=23s //