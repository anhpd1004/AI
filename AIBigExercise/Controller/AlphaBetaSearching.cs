using AIBigExercise.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIBigExercise.Controller
{
    class AlphaBetaSearching : BaseSearching
    {
        public long AlBe(Cell[,] GameBoard, int depth, bool IsMax, Position TL, Position TR, Position BL, Position BR, ref Position result)
        {
            if (depth == DEPTH)
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
            if (depth == 0)
            {
                return Evaluate(GameBoard);
            }
            long BestMax = -1000000000000;
            long BestMin = 1000000000000;
            if (IsMax)
            {
                for (int i = TL.Row; i < BL.Row + 1; i++)
                {
                    for (int j = TL.Col; j < TR.Col + 1; j++)
                    {
                        if (GameBoard[i, j].Status == Cell.EMPTY)
                        {
                            GameBoard[i, j].Status = Cell.PLAYER2;
                            long v = AlBe(GameBoard, depth - 1, !IsMax, TL, TR, BL, BR, ref result);
                            GameBoard[i, j].Status = Cell.EMPTY;
                            if (v >= BestMin)
                                break;
                            if (v > BestMax)
                            {
                                result.Row = i;
                                result.Col = j;
                                BestMax = v;
                            }
                        }
                    }
                }
                return BestMax;
            }
            else
            {
                for (int i = TL.Row; i < BL.Row + 1; i++)
                {
                    for (int j = TL.Col; j < TR.Col + 1; j++)
                    {
                        if (GameBoard[i, j].Status == Cell.EMPTY)
                        {
                            GameBoard[i, j].Status = Cell.PLAYER1;
                            long v = AlBe(GameBoard, depth - 1, !IsMax, TL, TR, BL, BR, ref result);
                            GameBoard[i, j].Status = Cell.EMPTY;
                            if (v <= BestMax)
                                break;
                            if (v < BestMin)
                            {
                                result.Row = i;
                                result.Col = j;
                                BestMin = v;
                            }
                        }
                    }
                }
                return BestMin;
            }
        }
    }
}
