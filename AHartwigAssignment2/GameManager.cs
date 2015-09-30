using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHartwigAssignment2
{
    class GameManager
    {


        public GameManager()
        {

        }

        class Pawn
        {
            private int X_POS;
            private int Y_POS;
            private string type;

            public Pawn(string type, int xPosition, int yPosition)
            {
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
    }
}
