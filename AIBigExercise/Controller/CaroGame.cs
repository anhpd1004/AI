using AIBigExercise.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIBigExercise.Controller
{
    class CaroGame
    {
        public const int SIZE = 20;

        public const byte PLAYER_VS_PLAYER = 1;
        public const byte PLAYER_VS_COM = 2;

        private static readonly DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        private int _Move = Board.UNDEFINED_MOVE;
        private Board _GameBoard;
        //phạm vi những nước đã đánh
        public Position TL;//TopLeft
        public Position TR;//TopRight
        public Position BL;//BottomLeft
        public Position BR;//BottomRight
        private Cell[,] _CellArray;
        private Stack<Cell> _StackMoved;
        private Stack<Cell> _StackUndo;
        private bool _IsReady;
        private int _Result;//kết quả của trận đấu
        private byte _Mode;//chế độ chơi
        private MinimaxSearching minimax;
        private AlphaBetaSearching albe;
        private StreamWriter swmini;
        //StreamWriter swalbe = File.CreateText(@"AlphaBeta.txt");
        

        #region Construstor
        public CaroGame()
        {
            this._IsReady = false;
            this._GameBoard = new Board(SIZE);
            _StackMoved = new Stack<Cell>();
            _StackUndo = new Stack<Cell>();
            minimax = new MinimaxSearching();
            albe = new AlphaBetaSearching();
            InitialCellArray();
        }
        //khởi tạo mảng các ô cờ trên bàn cờ
        public void InitialCellArray()
        {
            this._CellArray = new Cell[SIZE, SIZE];
            Position pos = new Position();
            Point loc = new Point();

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    pos.Row = i;
                    pos.Col = j;
                    loc.X = j * Cell.SIZE + 1;
                    loc.Y = i * Cell.SIZE + 1;
                    this._CellArray[i, j] = new Cell(pos, loc, Cell.EMPTY);
                }
            }

            TL = new Position((SIZE - 1) / 2, (SIZE - 1) / 2);
            TR = new Position((SIZE - 1) / 2, (SIZE - 1) / 2);
            BL = new Position((SIZE - 1) / 2, (SIZE - 1) / 2);
            BR = new Position((SIZE - 1) / 2, (SIZE - 1) / 2);
        }
        #endregion
        #region property cho cac bien
        public byte Mode
        {
            get { return this._Mode; }
        }
        public Stack<Cell> StackMoved
        {
            get { return this._StackMoved; }
            set { this._StackMoved = value; }
        }
        public Stack<Cell> StackUndo
        {
            get { return this._StackUndo; }
            set { this._StackUndo = value; }
        }
        public Cell[,] CellArray
        {
            get { return this._CellArray; }
            set { this._CellArray = value; }
        }
        public bool IsReady
        {
            get { return this._IsReady; }
            set { this._IsReady = value; }
        }
        public int Result
        {
            get { return this._Result; }
            set { this._Result = value; }
        }
        public Board GameBoard
        {
            get { return this._GameBoard; }
            set { this._GameBoard = value; }
        }
        #endregion
        //xem có thể thay đổi top left đc không từ row và col
        private void TopLeft(int row, int col)
        {
            if (row < TL.Row)
                TL.Row = row;
            if (col < TL.Col)
                TL.Col = col;
        }
        private void TopRight(int row, int col)
        {
            if (row < TR.Row)
                TR.Row = row;
            if (col > TR.Col)
                TR.Col = col;
        }
        private void BottomLeft(int row, int col)
        {
            if (row > BL.Row)
                BL.Row = row;
            if (col < BL.Col)
                BL.Col = col;
        }
        private void BottomRight(int row, int col)
        {
            if (row > BR.Row)
                BR.Row = row;
            if (col > BR.Col)
                BR.Col = col;
        }

        //convert time from 1970 to now to MillisSeconds
        public static long CurrentTimeMillis()
        {
            return (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
        }
        //danh nuoc co'
        public bool Move(int x, int y, int CellState, Graphics g)
        {
            int state = _GameBoard.PaintXorY(x, y, _Move, CellState, g);
            if (state == 0)
            {
                return false;
            }
            int size = Cell.SIZE;
            int row = y / size;
            int col = x / size;
            TopLeft(row, col);
            TopRight(row, col);
            BottomLeft(row, col);
            BottomRight(row, col);
            if (state == 1)
            {
                _CellArray[row, col].Status = Cell.PLAYER1;
                _Move = _Mode == CaroGame.PLAYER_VS_PLAYER ? Board.PLAYER2_MOVE : Board.COM_MOVE;
            }
            else
            {
                _CellArray[row, col].Status = Cell.PLAYER2;
                _Move = Board.PLAYER1_MOVE;
            }
            _CellArray[row, col].Pos = new Position(row, col);
            _CellArray[row, col].Location = new Point(x, y);
            _StackMoved.Push(_CellArray[row, col]);
            _StackUndo = new Stack<Cell>();
            //if (_StackMoved.Count == 9 && _Mode == CaroGame.PLAYER_VS_PLAYER)
            //    _Mode = CaroGame.PLAYER_VS_COM;
            return true;
        }
        public void RePaintBoard(Graphics g)
        {
            //foreach (Cell cell in _StackMoved)
            //{
            //    _GameBoard.PaintXorY(cell.Location.X, cell.Location.Y, cell.Status, cell.Status, g);
            //}
            for (int i = 0; i < _StackMoved.Count; i++)
            {
                Cell cell = _StackMoved.ElementAt(i);
                _GameBoard.PaintXorY(cell.Location.X, cell.Location.Y, cell.Status, cell.Status, g);
            }
        }
        public void StartPlayerVsPlayer(Graphics g)
        {
            this._IsReady = true;
            Random r = new Random();
            this._Move = r.Next(1, 3);
            String name = this._Move == 1 ? "Player 1" : "Player 2";
            MessageBox.Show(name + " chơi trước.", "Information");
            this._Mode = CaroGame.PLAYER_VS_PLAYER;
            _StackMoved = new Stack<Cell>();
            _StackUndo = new Stack<Cell>();
            InitialCellArray();
            _GameBoard.PaintBoard(g);
        }
        public void StartPlayerVsCom(Graphics g)
        {
            swmini = File.CreateText("Minimax.txt");
            this._IsReady = true;
            _Move = 3;
            this._Mode = CaroGame.PLAYER_VS_COM;
            _StackMoved = new Stack<Cell>();
            _StackUndo = new Stack<Cell>();
            InitialCellArray();
            _GameBoard.PaintBoard(g);
            ComMoveByAlBe(g);
        }
        #region Undo Redo
        public void Undo(Graphics g)
        {
            if (_StackMoved.Count > 0)
            {
                Cell cell = _StackMoved.Pop();
                _StackUndo.Push(cell); 
                _GameBoard.ResetCell(cell, g);
                _CellArray[cell.Pos.Row,cell.Pos.Col].Status = Cell.EMPTY;
                _Move = (_Move == Board.PLAYER1_MOVE) ? Board.PLAYER2_MOVE : Board.PLAYER1_MOVE;
            }
        }
        public void Redo(Graphics g)
        {
            if (_StackUndo.Count > 0)
            {
                Cell cell = _StackUndo.Pop();
                _StackMoved.Push(cell);
                GameBoard.PaintXorY(cell.Location.X, cell.Location.Y, _Move, cell.Status, g);
                _CellArray[cell.Pos.Row, cell.Pos.Col].Status = _Move;
                    _Move = (_Move == Board.PLAYER1_MOVE) ? Board.PLAYER2_MOVE : Board.PLAYER1_MOVE;
            }
        }
        #endregion
        #region Xu ly thang 
        //kết thúc trò chơi
        public void TerminalGame()
        {
            swmini.Close();
            String winner = (_Result == Board.DRAW) ? "Draw game" 
                : (_Result == Board.PLAYER1_WIN ? "Player 1 win" 
                :(_Result == Board.PLAYER2_WIN ? "Player 2 win" : "Computer win"));
            MessageBox.Show(winner);
        }
        //kiểm tra trạng thái kết thúc trò chơi
        public bool TerminalCheck()
        {
            if (_StackMoved.Count == SIZE * SIZE)
            {
                _Result = Board.DRAW;
                return true;
            }
            if (_StackMoved.Count < 9)
                return false;
            for (int i = 0; i < _StackMoved.Count; i++)
            {
                Cell cell = _StackMoved.ElementAt(i);
                int CellState = cell.Status;
                int row = cell.Pos.Row;
                int col = cell.Pos.Col;
                if (   CheckFiveInCol(row, col, CellState)
                    || CheckFiveInRow(row, col, CellState)
                    || CheckFiveInDiagonalLeftToRight(row, col, CellState)
                    || CheckFiveInDiagonalRightToLeft(row, col, CellState)
                    )
                {
                    _Result = (CellState == Cell.PLAYER1) ? Board.PLAYER1_WIN : Board.PLAYER2_WIN;
                    return true;
                }
            }
            return false;
        }

        //Các cách kiểm tra thắng
        //Hàng dọc
        private bool CheckFiveInCol(int row, int col, int CellState)
        {
            
            if (row > SIZE - 5)
                return false;
            int count;
            for (count = 1; count < 5; count++)
            {
                if (_CellArray[row + count, col].Status != CellState)
                    return false;
            }
            if (row == 0 || row == SIZE - 5)
                return true;
            if (_CellArray[row - 1, col].Status == Cell.EMPTY || _CellArray[row + 5, col].Status == Cell.EMPTY)
                return true;
            return false;
        }
        //Hàng ngang
        private bool CheckFiveInRow(int row, int col, int CellState)
        {
            if (col > SIZE - 5)
                return false;
            int count;
            for (count = 1; count < 5; count++)
            {
                if (_CellArray[row, col + count].Status != CellState)
                    return false;
            }
            if (col == 0 || col == SIZE - 5)
                return true;
            if (_CellArray[row, col - 1].Status == Cell.EMPTY || _CellArray[row, col + 5].Status == Cell.EMPTY)
                return true;
            return false;
        }
        //Đường chéo trái sang phải
        private bool CheckFiveInDiagonalLeftToRight(int row, int col, int CellState)
        {
            if (row > SIZE - 5)
                return false;
            if (col > SIZE - 5)
                return false;
            int count;
            for (count = 1; count < 5; count++)
            {
                if (_CellArray[row + count, col + count].Status != CellState)
                    return false;
            }
            if (row == 0 || row == SIZE - 5)
                return true;
            if (col == 0 || col == SIZE - 5)
                return true;
            if (_CellArray[row - 1, col - 1].Status == Cell.EMPTY || _CellArray[row + 5, col + 5].Status == Cell.EMPTY)
                return true;
            return false;
        }
        //Đường chéo phải sang trái
        private bool CheckFiveInDiagonalRightToLeft(int row, int col, int CellState)
        {
            if (row > SIZE - 5)
                return false;
            if (col < 4)
                return false;
            int count;
            for (count = 1; count < 5; count++)
            {
                if (_CellArray[row + count, col - count].Status != CellState)
                    return false;
            }
            if (row == 0 || row == SIZE - 5)
                return true;
            if (col == 4 || col == SIZE - 1)
                return true;
            if (_CellArray[row - 1, col + 1].Status == Cell.EMPTY || _CellArray[row + 5, col - 5].Status == Cell.EMPTY)
                return true;
            return false;
        }
        #endregion
        #region Minimax and AnphaBeta

        public void ComMoveByMinimax(Graphics g)
        {
            if (_StackMoved.Count == 0 && _Move == 3)
            {
                Move((SIZE - 1) / 2 * Cell.SIZE + 1, (SIZE - 1) / 2 * Cell.SIZE + 1, Cell.EMPTY, g);
            }
            else if(_StackMoved.Count >= 1)
            {
                long start = CurrentTimeMillis();
                Position p = new Position();
                minimax.FindBestMove(ref _CellArray, TL, TR, BL, BR, ref p);
                long end = CurrentTimeMillis();
                long time = end - start;
                swmini.WriteLine(time);
                Move(p.Col * Cell.SIZE + 1, p.Row * Cell.SIZE + 1, Cell.EMPTY, g);
            }
        }
        public void ComMoveByAlBe(Graphics g)
        {
            if (_StackMoved.Count == 0)
            {
                Move((SIZE - 1) / 2 * Cell.SIZE + 1, (SIZE - 1) / 2 * Cell.SIZE + 1, Cell.EMPTY, g);
            }
            else
            {
                long start = CurrentTimeMillis();
                Position p = new Position();
                albe.FindBestMove(ref _CellArray, TL, TR, BL, BR, ref p);
                long end = CurrentTimeMillis();
                long time = end - start;
                //System.IO.File.WriteAllText(@"Runtimes\AlphaBeta.txt", time + "\n");
                Move(p.Col * Cell.SIZE + 1, p.Row * Cell.SIZE + 1, Cell.EMPTY, g);
            }
        }
        #endregion
    }
}
