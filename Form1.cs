using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BrickBreakerGame
{
    public partial class Form1 : Form
    {
        // Game state variables
        bool GoLeft; // Tracks left movement of the paddle
        bool GoRight; // Tracks right movement of the paddle
        bool IsGameOver; // Tracks whether the game is over

        // Game mechanics variables
        int Score; // Tracks the player's score
        int Ballx; // Horizontal movement speed of the ball
        int Bally; // Vertical movement speed of the ball
        int PlayerSpeed; // Speed of the paddle movement

        Random rnd = new Random(); // Random generator for ball direction and block colors

        PictureBox[] blockArray; // Array to hold block objects

        // Create an instance of the SoundManager
        private SoundManager soundManager;

        // Constructor: Initializes the form and places blocks
        public Form1()
        {
            InitializeComponent();
            soundManager = new SoundManager(); // Initialize the SoundManager
            PlaceBlocks();
        }

        // Sets up the game environment for a new game
        private void SetUpGame()
        {
            IsGameOver = false; // Reset game-over state
            Score = 0; // Reset score
            Ballx = 5; // Initialize ball horizontal speed
            Bally = 5; // Initialize ball vertical speed
            PlayerSpeed = 12; // Initialize paddle speed
            txtScore.Text = "Score: " + Score; // Display score

            // Reset ball and paddle positions
            Ball.Left = 376;
            Ball.Top = 328;
            BAT.Left = 347;

            GameTimer.Start(); // Start the game timer

            // Randomize block colors
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    x.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }
            }
        }

        // Ends the game and displays a message
        private void GameOver(string message)
        {
            IsGameOver = true; // Set game-over state
            GameTimer.Stop(); // Stop the timer
            txtScore.Text = "Score: " + Score + "  " + message; // Display game-over message
        }

        // Places blocks on the form
        private void PlaceBlocks()
        {
            pictureBoxloser.Visible = false; // Hide loser image
            pictureBoxwin.Visible = false; // Hide winner image
            blockArray = new PictureBox[15]; // Create an array of 15 blocks

            int a = 0; // Tracks the number of blocks in a row
            int Top = 50; // Initial top position
            int Left = 100; // Initial left position

            // Create and position each block
            for (int i = 0; i < blockArray.Length; i++)
            {
                blockArray[i] = new PictureBox();
                blockArray[i].Height = 32; // Set block height
                blockArray[i].Width = 100; // Set block width
                blockArray[i].Tag = "blocks"; // Tag the block for identification
                blockArray[i].BackColor = Color.White; // Set initial color

                // Move to a new row if 5 blocks are placed
                if (a == 5)
                {
                    Top = Top + 50; // Move down
                    Left = 100; // Reset left position
                    a = 0; // Reset row counter
                }
                if (a < 5)
                {
                    a++; // Increment row counter
                    blockArray[i].Left = Left; // Set block's left position
                    blockArray[i].Top = Top; // Set block's top position
                    this.Controls.Add(blockArray[i]); // Add block to the form
                    Left = Left + 130; // Move to the next column
                }
            }
            SetUpGame(); // Start the game
        }

        // Removes all blocks from the form
        private void RemoveBlock()
        {
            foreach (PictureBox x in blockArray)
            {
                this.Controls.Remove(x); // Remove each block
            }
        }

        // Main game loop that handles the ball movement and collision
        private void MainGameTimer(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + Score; // Update score

            // Move the paddle left
            if (GoLeft == true && BAT.Left > 0)
            {
                BAT.Left -= PlayerSpeed;
            }

            // Move the paddle right
            if (GoRight == true && BAT.Left < 700)
            {
                BAT.Left += PlayerSpeed;
            }

            // Move the ball
            Ball.Left += Ballx;
            Ball.Top += Bally;

            // Bounce the ball off the left or right walls
            if (Ball.Left < 0 || Ball.Left > 775)
            {
                Ballx = -Ballx;
            }

            // Bounce the ball off the top wall
            if (Ball.Top < 0)
            {
                Bally = -Bally;
            }

            // Bounce the ball off the paddle
            if (Ball.Bounds.IntersectsWith(BAT.Bounds))
            {
                Ball.Top = 463;
                Bally = rnd.Next(5, 12) * -1;

                if (Ballx < 0)
                {
                    Ballx = rnd.Next(5, 12) * -1;
                }
                else
                {
                    Ballx = rnd.Next(5, 12);
                }
            }

            // Check for ball collision with blocks
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (String)x.Tag == "blocks")
                {
                    if (Ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        Score += 10; // Increase score
                        soundManager.PlayHitSound(); // Play hit sound

                        Bally = -Bally; // Reverse ball direction
                        this.Controls.Remove(x); // Remove the block
                    }
                }
            }

            // Check for win condition
            if (Score == 150)
            {
                GameOver("You Win! Press Enter to Play Again");
                soundManager.PlayWinSound(); // Play win sound
                pictureBoxwin.Visible = true; // Show win image
            }

            // Check for loss condition
            if (Ball.Top > 580)
            {
                GameOver("You Lose! Press Enter to Play Again");
                soundManager.PlayLossSound(); // Play loss sound
                pictureBoxloser.Visible = true; // Show lose image
            }
        }

        // Handles key press events
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                GoLeft = true; // Move paddle left
            }
            if (e.KeyCode == Keys.Right)
            {
                GoRight = true; // Move paddle right
            }
            if(e.KeyCode == Keys.E)
            {
                Application.Exit();
            }
        }

        // Handles key release events
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                GoLeft = false; // Stop moving left
            }
            if (e.KeyCode == Keys.Right)
            {
                GoRight = false; // Stop moving right
            }
            if (e.KeyCode == Keys.Enter && IsGameOver == true)
            {
                RemoveBlock(); // Remove existing blocks
                PlaceBlocks(); // Place new blocks for a new game
            }
        }
        //Handles Mouse Movement
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Ensure the paddle follows the mouse on the X-axis within the form's width bounds
            if (e.X > 0 && e.X < this.Width - BAT.Width)
            {
                BAT.Left = e.X - (BAT.Width / 2); // Center the paddle under the mouse cursor
            }
        }
    }
}
