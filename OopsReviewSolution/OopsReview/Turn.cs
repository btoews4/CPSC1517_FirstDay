using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsReview
{
    class Turn
    {
        private int _player1Result;
        private int _player2Result;

        public Turn()
        {
            //Leaving the empty will set the variables to their defualt.
            //Ints = 0
            //strings = null
        }

        public Turn(int player1Result, int player2Result)
        {
            Player1Result = player1Result;
            Player2Result = player2Result;
        }

        public int Player1Result
        {
            get
            {
                return _player1Result;
            }
            set
            {
                _player1Result = value;
            }
        }

        public int Player2Result
        {
            get
            {
                return _player2Result;
            }
            set
            {
                _player2Result = value;
            }
        }

        public override string ToString()
        {
            return "Player 1 Result: " + Player1Result + ", Player 2 Result: " + Player2Result;
        }
    }
}
