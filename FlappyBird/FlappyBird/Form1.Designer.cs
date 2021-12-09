namespace FlappyBird
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
            this.components = new System.ComponentModel.Container();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.PipeDown = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // Bird
            // 
            this.Bird.Image = global::FlappyBird.Properties.Resources.bird;
            this.Bird.Location = new System.Drawing.Point(68, 420);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(83, 65);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 0;
            this.Bird.TabStop = false;
            this.Bird.Click += new System.EventHandler(this.gameTimerEvent);
            // 
            // PipeTop
            // 
            this.PipeTop.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.PipeTop.Location = new System.Drawing.Point(469, -5);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(100, 270);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 1;
            this.PipeTop.TabStop = false;
            // 
            // PipeDown
            // 
            this.PipeDown.Image = global::FlappyBird.Properties.Resources.pipe;
            this.PipeDown.Location = new System.Drawing.Point(469, 758);
            this.PipeDown.Name = "PipeDown";
            this.PipeDown.Size = new System.Drawing.Size(100, 294);
            this.PipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeDown.TabIndex = 2;
            this.PipeDown.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.Image = global::FlappyBird.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-4, 1050);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(757, 72);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Font = new System.Drawing.Font("Technic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ScoreText.Location = new System.Drawing.Point(9, 9);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(214, 51);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "Score: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(747, 1112);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.PipeDown);
            this.Controls.Add(this.PipeTop);
            this.Name = "Form1";
            this.Text = "FlappyBird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox PipeDown;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer GameTimer;
    }
}

