using AIBigExercise.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIBigExercise.Controller
{
    class MinimaxSearching : BaseSearching
    {
        //Max player is Computer
        //depth la do sau
        public long MiniMax(Cell[,] GameBoard, int depth, bool IsMax, Position TL, Position TR, Position BL, Position BR)
        {
            long val = Evaluate(GameBoard);
            if (depth == 0)
            {
                return val;
            }
            if (IsMax)
            {
                long best = -1000000000000;
                for (int i = TL.Row; i < BL.Row + 1; i++)
                {
                    for (int j = TL.Col; j < TR.Col + 1; j++)
                    {
                        if (GameBoard[i, j].Status == Cell.EMPTY)
                        {
                            GameBoard[i, j].Status = Cell.PLAYER2;
                            best = Math.Max(best, MiniMax(GameBoard, depth - 1, !IsMax, TL, TR, BL, BR));
                            GameBoard[i, j].Status = Cell.EMPTY;
                        }
                    }
                }
                return best;
            }
            else
            {
                long best = 1000000000000;
                for (int i = TL.Row; i < BL.Row + 1; i++)
                {
                    for (int j = TL.Col; j < TR.Col + 1; j++)
                    {
                        if (GameBoard[i, j].Status == Cell.EMPTY)
                        {
                            GameBoard[i, j].Status = Cell.PLAYER1;
                            best = Math.Min(best, MiniMax(GameBoard, depth - 1, !IsMax, TL, TR, BL, BR));
                            GameBoard[i, j].Status = Cell.EMPTY;
                        }
                    }
                }
                return best;
            }
        }
        public override Cell FindBestMove(Cell[,] GameBoard, Position TL, Position TR, Position BL, Position BR)
        {
            Cell cell = new Cell();
            long BestVal = -1000000000000;
            int BestRow = -1;
            int BestCol = -1;
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
            for (int i = TL.Row; i < BL.Row + 1; i++)
            {
                for (int j = TL.Col; j < TR.Col + 1; j++)
                {
                    if (GameBoard[i, j].Status == Cell.EMPTY)
                    {
                        GameBoard[i, j].Status = Cell.PLAYER2;
                        long val = MiniMax(GameBoard, DEPTH, true, TL, TR, BL, BR);
                        GameBoard[i, j].Status = Cell.EMPTY;
                        if (val > BestVal)
                        {
                            BestVal = val;
                            BestRow = i;
                            BestCol = j;
                        }
                    }
                }
            }
            cell.Pos = new Position(BestRow, BestCol);
            cell.Location = new Point(BestCol * Cell.SIZE + 1, BestRow * Cell.SIZE + 1);
            return cell;
        }
    }
}
