using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHartwigAssignment2
{
    class GameManager
    {
        private List<Pawn> pawns = new List<Pawn>();
        private DateTime timeStarted, timeFinished;
        private bool secondPlayersTurn;
        private string firstPlayerName;
        private string secondPlayerName;

        public GameManager(string FirstPlayerName, string SecondPlayerName)
        {
            timeStarted = DateTime.Now;
            secondPlayersTurn = false;
            if (FirstPlayerName == null)
            {
                firstPlayerName = "Player 1";
            }
            else
            {
                firstPlayerName = FirstPlayerName;
            }
            if (SecondPlayerName == null)
            {
                secondPlayerName = "Player 2";
            }
            else
            {
                secondPlayerName = SecondPlayerName;
            }
        }

        private void checkGameWin()
        {
            bool playerOneWins = false;
            bool playerTwoWins = false;
            bool staleMate = false;
            for (int i = 0; i < pawns.Count; i++)
            {

            }
        }

        private bool SpotTaken(int x, int y)
        {
            bool spotTaken = false;
            for (int i = 0; i < pawns.Count; i++)
            {
                if (pawns[i].GetXPosition() == x && pawns[i].GetYPosition() == y)
                {
                    spotTaken = true;
                    break;
                }
            }
            return spotTaken;
        }

        class Pawn
        {
            private int X_POS;
            private int Y_POS;
            private string type;

            public Pawn(string type, int xPosition, int yPosition)
            {
                this.type = type;
                X_POS = xPosition;
                Y_POS = yPosition;
            }

            public int GetXPosition()
            {
                return X_POS;
            }

            public int GetYPosition()
            {
                return Y_POS;
            }
        }

        public class GameFinishedEventArgs : EventArgs
        {
            public string Winner { get; set; }
            public DateTime TimeFinished { get; set; }
        }
    }
}
