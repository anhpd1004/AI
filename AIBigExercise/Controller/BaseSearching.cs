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
        public long[] AttackGrades = new long[7] { 0, 3, 24, 192, 1536, 12288, 98304 };
        public long[] DefenseGrades = new long[7] { 0, 1, 9, 81, 729, 6561, 59049 };
        public string[] XCase = { @"\sxx\s", @"\sxxxo", @"oxxx\s", @"\sxxx\s", @"\sxxxxo", @"oxxxx\s", @"\sxxxx\s", @"xxxxx" };
        public string[] OCase = { @"\soo\s", @"\sooox", @"xooo\s", @"\sooo\s", @"\soooox", @"xoooo\s", @"\soooo\s", @"ooooo" };
        public long[] point = { 10, 5, 5, 20, 40, 40, 3000, 10000 };
        public const int DEPTH = 1;
        public const int n = 20;
        public Position TL, TR, BL, BR;
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
            this.TL = TL;
            this.TR = TR;
            this.BL = BL;
            this.BR = BR;
        }
        public virtual void NewBound()
        {
            if (TL.Row - 2 >= 0)
                TL.Row -= 2;
            if (TL.Col - 2 >= 0)
                TL.Col -= 2;
            if (TR.Col + 2 <= n - 1)
                TR.Col += 2;
            if (TR.Row - 2 >= 0)
                TR.Row -= 2;
            if (BL.Row + 2 <= n - 1)
                BL.Row += 2;
            if (BL.Col - 2 >= 0)
                BL.Col -= 2;
            if (BR.Row + 2 <= n - 1)
                BR.Row += 2;
            if (BR.Col + 2 <= n - 1)
                BR.Col += 2;
        }
        public virtual long AttackGradeInRow(int CurrRow, int CurrCol)
        {
            long TongDiem = 0;
            int SoQuanTa = 0, SoQuanDich = 0;
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

        public virtual long Evaluate(Cell[,] GameBoard)
        {
            long grades = 0;
            string s = BoardToString(GameBoard);
            Regex regex1, regex2;
            for (int i = 0; i < XCase.Length; i++)
            {
                regex1 = new Regex(XCase[i], RegexOptions.IgnoreCase);
                regex2 = new Regex(OCase[i], RegexOptions.IgnoreCase);
                grades += point[i] * regex2.Matches(s).Count;
                grades -= point[i] * regex1.Matches(s).Count;
            }
            return grades;
        }
        public virtual Cell FindBestMove(Cell[,] GameBoard, Position TL, Position TR, Position BL, Position BR)
        {
            return new Cell();
        }
    }
}
