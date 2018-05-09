using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AIBigExercise.Objects
{
    class Cell
    {
        public const int SIZE = 20;

        public const int EMPTY = 0;
        public const int PLAYER1 = 1;
        public const int PLAYER2 = 2;

        private Position _Pos;
        //coordinate of a cell
        private Point _Location;
        //0 is Empty
        //1 is player1
        //2 is player2
        private int _Status;

        public Cell()
        {
            this._Location = new Point();
            this._Pos = new Position();
            this._Status = 0;
        }

        public Cell(Position pos, Point loc, int status)
        {
            this._Pos = pos;
            this._Location = loc;
            this._Status = status;  
        }

        public Position Pos
        {
            get { return this._Pos; }
            set { this._Pos = value; }
        }
        public Point Location
        {
            get { return this._Location; }
            set { this._Location = value; }
        }
        public int Status
        {
            get { return this._Status; }
            set { this._Status = value; }
        }
    }
}
