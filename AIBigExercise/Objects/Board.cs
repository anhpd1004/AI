using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIBigExercise.Objects
{
    class Board
    {
        public const int MAX_ROW = 30;
        public const int MAX_COL = 30;

        //ket qua
        public const int DRAW = 0;
        public const int PLAYER1_WIN = 1;
        public const int PLAYER2_WIN = 2;
        public const int COM_WIN = 3;

        //luot di chuyen
        public const int UNDEFINED_MOVE = 0;
        public const int PLAYER1_MOVE = 1;
        public const int PLAYER2_MOVE = 2;
        public const int COM_MOVE = 3;

        //trang thai game
        public const int IS_STOP = 2;
        public const int IS_PLAY = 1;
        public const int NO_STATE = 0;

        private int _Size = 0;
        private Cell[,] _GameBoard;
        private int _GameState;
        private int _GameMove;
        private int _GameResult;

        public Board()
        {
            this._GameMove = UNDEFINED_MOVE;
            this._GameState = NO_STATE;
            this._GameResult = DRAW;
        }
        public Board(int size)
        {
            this._Size = size;
            this._GameMove = UNDEFINED_MOVE;
            this._GameState = NO_STATE;
            this._GameResult = DRAW;
        }
        public int Size
        {
            get { return this._Size; }
            set { this._Size = value; }
        }
        public Cell[,] GameBoard
        {
            get { return this._GameBoard; }
            set { this._GameBoard = value; }
        }
        public int GameState
        {
            get { return this._GameState; }
            set { this._GameState = value; }
        }
        public int GameMove
        {
            get { return this._GameMove; }
            set { this._GameMove = value; }
        }
        public int GameResult
        {
            get { return this._GameResult; }
            set { this._GameResult = value; }
        }

        //cac phuong thuc xu li
        public void PaintBoard(Graphics g)
        {
            Pen pen = new Pen(Color.LightGray);
            for (int i = 0; i <= this._Size; i++)
            {
                g.DrawLine(pen, 0, i * this._Size, 20 * this._Size, i * this._Size);
                g.DrawLine(pen, i * this._Size, 0, i * this._Size, 20 * this._Size);
            }
        }
        //ve quan co
        public int PaintXorY(int x, int y, int MoveState, int CellState, Graphics g)
        {
            if (CellState != Cell.EMPTY)
                return 0;
            int size = Cell.SIZE;
            if (x % size == 0)
                return 0;
            if (y % size == 0)
                return 0;
            int row = y / size;
            int col = x / size;
            if (MoveState == Board.PLAYER1_MOVE)
            {
                //player1 danh X
                Pen pen = new Pen(Color.Black, 2f);
                g.DrawLine(pen, col * size + 3, row * size + 3, (col + 1) * size - 3, (row + 1) * size - 3);
                g.DrawLine(pen, (col + 1) * size - 3, row * size + 3, col * size + 3, (row + 1) * size - 3);
                return Cell.PLAYER1;
            }
            else if (MoveState == Board.PLAYER2_MOVE || MoveState == Board.COM_MOVE)
            {
                //player2 danh O
                Pen pen = new Pen(Color.Red, 2f);
                g.DrawEllipse(pen, col * size + 3, row * size + 3, size - 6, size - 6);
                return Cell.PLAYER2;
            }
            return 0;
        }
        public void ResetCell(Cell cell, Graphics g)
        {
            SolidBrush sb = new SolidBrush(Color.White);
            g.FillRectangle(sb, cell.Pos.Col * Cell.SIZE + 1, cell.Pos.Row * Cell.SIZE + 1, Cell.SIZE - 2, Cell.SIZE - 2);
        }
    }
}
