using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIBigExercise.Objects
{
    class Position
    {
        private int _Row;
        private int _Col;
        public Position()
        {
            _Row = 0;
            _Col = 0;
        }
        public Position(int row, int col)
        {
            this._Row = row;
            this._Col = col;
        }
        public int Row
        {
            get { return this._Row; }
            set { this._Row = value; }
        }
        public int Col
        {
            get { return this._Col; }
            set { this._Col = value; }
        }

    }
}
