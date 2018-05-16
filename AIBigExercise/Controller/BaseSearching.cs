using AIBigExercise.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AIBigExercise.Controller
{
    class BaseSearching
    {

        //mảng điểm số
        //public long[] AttackGrades = new long[7] { 0, 3, 24, 192, 1536, 12288, 98304 };
        //public long[] DefenseGrades = new long[7] { 0, 1, 9, 81, 729, 6561, 59049 };
        //public string[] XCase = { @"o(\w){1,5}o",  @"\sxx\s", @"oxx\sx\s", @"\sx\sxxo", @"ox\sxx\s", @"\sxx\sxo", @"\sxxxo", @"oxxx\s",@"\sxxx\s",
        //                            @"xx\sx",@"x\sxx", 
        //                            @"[^o]\sxxxxo", @"oxxxx\s[^o]", @"\sxxxx\s", 
        //                            @"\sxxxxxo", @"oxxxxx\s" };
        //public string[] OCase = {@"x(\w){1,5}x", @"\soo\s", @"xoo\so", @"o\soox",@"xo\soo\s", @"\soo\sox", @"\sooox", @"xooo\s", @"\sooo\s",
        //                            @"oo\so", @"o\soo", 
        //                            @"[^x]\soooox", @"xoooo\s[^x]", @"\soooo\s",
        //                            @"\sooooox", @"xooooo\s" };
        //public long[] point = { 0, 10, 8, 8, 15, 15, 20, 20, 400,
        //                          40, 40,
        //                          1000, 1000, 3000,
        //                          10000, 10000};
        public String[] XCase = { @"\sxx\s", @"oxxx\s", @"\sxxxo", @"\sxxx\s", @"[^o]\sxxxxo", @"oxxxx\s[^o]", @"\sxxxx\s", @"\wxxxxx\s", @"\sxxxxx\w" };
        public String[] OCase = { @"\soo\s", @"xooo\s", @"\sooox", @"\sooo\s", @"[^x]\soooox", @"xoooo\s[^x]", @"\soooo\s", @"\wooooo\s", @"\sooooo\w" };
        public long[] point = { 3, 40, 40, 100, 1000, 1000, 1000, 10000, 10000 };
        public const int DEPTH = 5;
        public const int n = 20;
        //public Cell[,] GameBoard;

        //public void Copy(Cell[,] cells)
        //{
        //    this.GameBoard = new Cell[n, n];
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            this.GameBoard[i, j].Status = cells[i, j].Status;
        //        }
        //    }
        //}
        public virtual void GetBound(Position TL, Position TR, Position BL, Position BR)
        {
            return;
        }
        //xem có thể thay đổi top left đc không từ row và col
        private void TopLeft(ref Position TL, int row, int col)
        {
            if (row < TL.Row)
                TL.Row = row;
            if (col < TL.Col)
                TL.Col = col;
        }
        private void TopRight(ref Position TR, int row, int col)
        {
            if (row < TR.Row)
                TR.Row = row;
            if (col > TR.Col)
                TR.Col = col;
        }
        private void BottomLeft(ref Position BL, int row, int col)
        {
            if (row > BL.Row)
                BL.Row = row;
            if (col < BL.Col)
                BL.Col = col;
        }
        private void BottomRight(ref Position BR, int row, int col)
        {
            if (row > BR.Row)
                BR.Row = row;
            if (col > BR.Col)
                BR.Col = col;
        }
        public virtual void NewBound(Position NewMove, ref Position TL, ref Position TR, ref Position BL, ref Position BR)
        {
            TopLeft(ref TL, NewMove.Row, NewMove.Col);
            TopRight(ref TL, NewMove.Row, NewMove.Col);
            BottomLeft(ref TL, NewMove.Row, NewMove.Col);
            BottomRight(ref TL, NewMove.Row, NewMove.Col);
        }
        public virtual void NewScope()
        {

        }
        public virtual Stack<Position> Abilities(Stack<Cell> StackMoved)
        {
            bool[,] VisitedCell = new bool[n, n];
            foreach (Cell c in StackMoved)
            {
                VisitedCell[c.Pos.Row, c.Pos.Col] = true;
            }
            Stack<Position> StackAbilities = new Stack<Position>();
            for (int i = 0; i < StackMoved.Count; i++)
            {
                Cell c = StackMoved.ElementAt(i);
                int row = c.Pos.Row;
                int col = c.Pos.Col;
                for (int x = row - 1; x < row + 2; x++)
                {
                    for (int y = col - 1; y < col + 2; y++)
                    {
                        if (0 <= x && x < n && 0 <= y && y < n)
                        {
                            if (!VisitedCell[x, y])
                            {
                                StackAbilities.Push(new Position(x, y));
                                VisitedCell[x, y] = true;
                            }
                        }
                    }
                }
            }
            return StackAbilities;
        }
        //sinh cac nuoc di co hieu qua
        public virtual List<Position> GenMoves(Cell[,] GameBoard, int CellState, Stack<Cell> StackMoved, ref int count)
        {
            Stack<Position> StackAbilities = Abilities(StackMoved);
            Dictionary<Position, long> movings = new Dictionary<Position, long>();
            List<Position> movingList = new List<Position>();
            //sap xep giam dan theo value
            //movings.OrderByDescendin();
            while (StackAbilities.Count > 0)
            {
                Position p = StackAbilities.Pop();
                int i = p.Row;
                int j = p.Col;
                GameBoard[i, j].Status = CellState;
                long x = Evaluate(GameBoard, Cell.PLAYER2);
                long value = CellState == Cell.PLAYER2 ? x : -x;
                //if (value < 0)
                //{
                //    GameBoard[i, j].Status = Cell.PLAYER1;
                //    value = Math.Abs(Evaluate(GameBoard, Cell.PLAYER2));
                //}
                GameBoard[i, j].Status = Cell.EMPTY;
                movings.Add(new Position(i, j), value);
            }
            //long l = Evaluate(GameBoard, CellState);
            //if (l >= 0)
            //{
            //    while (StackAbilities.Count > 0)
            //    {
            //        Position p = StackAbilities.Pop();
            //        int i = p.Row;
            //        int j = p.Col;
            //        GameBoard[i, j].Status = CellState;
            //        long value = Math.Abs(Evaluate(GameBoard, Cell.PLAYER2));
            //        GameBoard[i, j].Status = Cell.EMPTY;
            //        movings.Add(new Position(i, j), value);
            //    }
            //}
            //else
            //{
            //    while (StackAbilities.Count > 0)
            //    {
            //        Position p = StackAbilities.Pop();
            //        int i = p.Row;
            //        int j = p.Col;
            //        GameBoard[i, j].Status = Cell.PLAYER2;
            //        long valueMax = Math.Abs(Evaluate(GameBoard, Cell.PLAYER2));
            //        GameBoard[i, j].Status = Cell.PLAYER1;
            //        long valueMin = Math.Abs(Evaluate(GameBoard, Cell.PLAYER2));
            //        GameBoard[i, j].Status = Cell.EMPTY;
            //        movings.Add(new Position(i, j), (valueMax > valueMin ? valueMax : valueMin));
            //    }
            //}
            //for (int i = TL.Row; i <= BL.Row; i++)
            //{
            //    for (int j = TL.Col; j <= TR.Col; j++)
            //    {
            //        if (GameBoard[i, j].Status == Cell.EMPTY)
            //        {
            //            GameBoard[i, j].Status = Cell.PLAYER2;
            //            long value = Math.Abs(Evaluate(GameBoard, Cell.PLAYER2));
            //            GameBoard[i, j].Status = Cell.EMPTY;
            //            movings.Add(new Position(i, j), value);
            //        }
            //    }
            //}
            //for (int i = TL.Row; i <= BL.Row; i++)
            //{
            //    for (int j = TL.Col; j <= TR.Col; j++)
            //    {
            //        if (GameBoard[i, j].Status == Cell.EMPTY)
            //        {
            //            GameBoard[i, j].Status = Cell.PLAYER1;
            //            long value = Math.Abs(Evaluate(GameBoard, Cell.PLAYER2));
            //            GameBoard[i, j].Status = Cell.EMPTY;
            //            movings.Add(new Position(i, j), value);
            //        }
            //    }
            //}
            Dictionary<Position, long> sortedDict = movings.OrderByDescending(entry => entry.Value).ToDictionary(entry => entry.Key, entry => entry.Value);
            int dem = 0;
            foreach (Position p in sortedDict.Keys)
            {
                movingList.Add(p);
                dem++;
                if (dem >= 4)
                {
                    break;
                }
            }
            return movingList;
        }
        public virtual void GenMoves1()
        {

        }
        public virtual long GradeInRow(Cell[,] GameBoard)
        {

            return 0;
        }
        public virtual String BoardToString(Cell[,] GameBoard)
        {
            String s = "";
            for (int i = 0; i < n; i++)
            {
                //hang ngang
                for (int j = 0; j < n; j++)
                {
                    if (GameBoard[i, j].Status == Cell.EMPTY)
                        s += " ";
                    else
                    {
                        s += (GameBoard[i, j].Status == Cell.PLAYER1) ? "x" : "o";
                    }
                }
                s += ";";
                //hang doc
                for (int j = 0; j < n; j++)
                {
                    if (GameBoard[j, i].Status == Cell.EMPTY)
                        s += " ";
                    else
                    {
                        s += (GameBoard[j, i].Status == Cell.PLAYER1) ? "x" : "o";
                    }
                }
                s += ";";
            }
            //cheo xuoi, nua tren
            for (int i = 0; i < n - 4; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    int state = GameBoard[j, i + j].Status;
                    s += (state == Cell.EMPTY) ? " " : (state == Cell.PLAYER1 ? "x" : "o");
                }
                s += ";";
            }
            //cheo xuoi, nua duoi
            for (int i = n - 5; i > 0; i--)
            {
                for (int j = 0; j < n - i; j++)
                {
                    int state = GameBoard[i + j, j].Status;
                    s += (state == Cell.EMPTY) ? " " : (state == Cell.PLAYER1 ? "x" : "o");
                }
                s += ";";
            }
            //cheo nguoc nua tren
            for (int i = 4; i < n; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    int state = GameBoard[i - j, j].Status;
                    s += (state == Cell.EMPTY) ? " " : (state == Cell.PLAYER1 ? "x" : "o");
                }
                s += ";";
            }
            //cheo nguoc, nua duoi
            for (int i = 1; i < n - 4; i++)
            {
                for (int j = n - 1; j > i - 1; j--)
                {
                    int state = GameBoard[n + i - j - 1, j].Status;
                    s += (state == Cell.EMPTY) ? " " : (state == Cell.PLAYER1 ? "x" : "o");
                }
                s += ";";
            }
            return s;
        }
        public virtual String LineToString(Cell[,] GameBoard, Position currPos)
        {
            String s = "";
            int row = currPos.Row;
            int col = currPos.Col;
            return s;
        }
        public virtual long Evaluate(Cell[,] GameBoard, int CellState)
        {
            long grades = 0;
            string s = BoardToString(GameBoard);
            Regex regex1, regex2;
            for (int i = 0; i < XCase.Length; i++)
            {
                regex1 = new Regex(XCase[i], RegexOptions.IgnoreCase);
                regex2 = new Regex(OCase[i], RegexOptions.IgnoreCase);
                if (CellState == Cell.PLAYER2)
                {
                    if (i == 6)
                    {
                        if (regex2.Matches(s).Count > 0)
                        {
                            grades += point[i];
                        }
                        if (regex1.Matches(s).Count > 0)
                        {
                            grades -= point[i];
                        }
                    }
                    else
                    {
                        grades += point[i] * regex2.Matches(s).Count;
                        grades -= point[i] * regex1.Matches(s).Count;
                    }
                    //grades += point[i] * regex2.Matches(s).Count;
                    //grades -= point[i] * regex1.Matches(s).Count;
                }
                else
                {
                    if (i == 6)
                    {
                        if (regex2.Match(s) != null)
                        {
                            grades -= point[i];
                        }
                        if (regex1.Match(s) != null)
                        {
                            grades += point[i];
                        }
                    }
                    else
                    {
                        grades -= point[i] * regex2.Matches(s).Count;
                        grades += point[i] * regex1.Matches(s).Count;
                    }
                    //grades -= point[i] * regex2.Matches(s).Count;
                    //grades += point[i] * regex1.Matches(s).Count;
                }
            }
            return grades;
        }
    }
}
