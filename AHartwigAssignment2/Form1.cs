/* AHartwigAssignment2
 * Tic Tac Toe by Andrew Hartwig
 * 
 * Revision:
 *   2015-10-04: Created the whole game. 
 *     -Andrew Hartwig
 *     
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHartwigAssignment2
{
    public partial class Form1 : Form
    {
        private const int MAX_TILES = 9;
        PictureBox[] pictureBoxes;
        Bitmap x, o;
        bool gameOver = false;
        int tileCount;
        bool secondPlayersTurn = false;
        int failCounter = 0;

        // Array of winning combinations
        static private int[,] Winners = new int[,] 
        {
            {0,1,2},
            {3,4,5},
            {6,7,8},
            {0,3,6},
            {1,4,7},
            {2,5,8},
            {0,4,8},
            {2,4,6}
        };
        
        // Form initialization. Shorthand the X and O bitmap resources for speed and readability
        // and create an array of all the picture boxes.
        public Form1()
        {
            InitializeComponent();

            o = AHartwigAssignment2.Properties.Resources.O;
            x = AHartwigAssignment2.Properties.Resources.X;

            pictureBoxes = new PictureBox[]
            {
                pbTL,
                pbTM,
                pbTR,
                pbML,
                pbMM,
                pbMR,
                pbBL,
                pbBM,
                pbBR
            };

            startNewGame();
        }

        // Reset and start a new game.
        private void startNewGame()
        {
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Image = null;
            }
            secondPlayersTurn = false;
            gameOver = false;
            failCounter = 0;
            tileCount = 0;
        }

        // Exit app from exit tool strip.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Method for checking if there is a winning combination. Does not return a value,
        // instead it handles the end of the game itself.
        private void checkGameWin()
        {

            if (++tileCount == MAX_TILES)
            {
                MessageBox.Show("Cats game!");
                gameOver = true;
            }
            // Loop through each possible win pattern.
            for (int i = 0; i < Winners.GetLength(0); i++)
            {
                // Assign a integer value to a b and c. If the aoPictureBoxes matches the win pattern, victory!
                int a = Winners[i, 0];
                int b = Winners[i, 1];
                int c = Winners[i, 2];

                PictureBox pb1 = pictureBoxes[a];
                PictureBox pb2 = pictureBoxes[b];
                PictureBox pb3 = pictureBoxes[c];

                // Continue for loop if one of the values is null.
                if (pb1.Image == null || pb2.Image == null || pb3.Image == null)
                {
                    continue;
                }

                if (pb1.Image == pb2.Image && pb2.Image == pb3.Image)
                {
                    gameOver = true;
                    string winnerType;
                    if (pb1.Image == x)
                    {
                        winnerType = "X";
                    }
                    else
                    {
                        winnerType = "O";
                    }

                    MessageBox.Show(String.Format("Congratulations! {0} wins!", winnerType));
                }
            }
        }

        // Handle the image click event!
        private void image_click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            if (gameOver)
            {
                DialogResult r = MessageBox.Show("Game is over. Would you like to play another?", "Error!", MessageBoxButtons.YesNo);
                switch (r)
                {
                    case DialogResult.Yes:
                        startNewGame();
                        break;
                    default:
                        break;
                }
                return;
            }

            if (!secondPlayersTurn && pb.Image == null)
            {
                pb.Image = x;
            }
            else if (secondPlayersTurn && pb.Image == null)
            {
                pb.Image = o;
            }
            else if (pb.Image != null)
            {
                if (++failCounter == 3)
                {
                    MessageBox.Show("Clearly these spots are taken... Smarten up!");
                }
                return;
            }
            secondPlayersTurn = !secondPlayersTurn;
            checkGameWin();
        }

        // Runs the start new game method to refresh the game from the file menu.
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startNewGame();
        }
    }
}
