﻿using AIBigExercise.Objects;
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
        public long MiniMax(ref Cell[,] GameBoard, ref Stack<Cell> StackMoved, int depth, bool IsMax, Position TL, Position TR, Position BL, Position BR, ref int count)
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
            CaroGame cg = new CaroGame();
            if (cg.TerminalCheck(StackMoved, GameBoard))
            {
                count++;
                return Evaluate(GameBoard, Cell.PLAYER2);
            }
            if (depth == 0)
            {
                count++;
                return Evaluate(GameBoard, Cell.PLAYER2);
            }
            if (IsMax)
            {
                long best = -1000000000000;
                List<Position> list = GenMoves(GameBoard, Cell.PLAYER2, StackMoved);
                for (int x = 0; x < list.Count; x++)
                {
                    int i = list[x].Row;
                    int j = list[x].Col;
                    if (GameBoard[i, j].Status == Cell.EMPTY)
                    {
                        GameBoard[i, j].Status = Cell.PLAYER2;
                        StackMoved.Push(new Cell(new Position(i, j), new Point(), Cell.PLAYER2));
                        long v = MiniMax(ref GameBoard, ref StackMoved, depth - 1, !IsMax, TL, TR, BL, BR, ref count);
                        GameBoard[i, j].Status = Cell.EMPTY;
                        StackMoved.Pop();
                        if (v > best)
                        {
                            best = v;
                        }
                    }
                }
                return best;
            }
            else
            {
                long best = 1000000000000;
                List<Position> list = GenMoves(GameBoard, Cell.PLAYER1, StackMoved);
                for (int x = 0; x < list.Count; x++)
                {
                    int i = list[x].Row;
                    int j = list[x].Col;
                    if (GameBoard[i, j].Status == Cell.EMPTY)
                    {
                        GameBoard[i, j].Status = Cell.PLAYER1;
                        StackMoved.Push(new Cell(new Position(i, j), new Point(), Cell.PLAYER1));
                        long v = MiniMax(ref GameBoard, ref StackMoved, depth - 1, !IsMax, TL, TR, BL, BR, ref count);
                        GameBoard[i, j].Status = Cell.EMPTY;
                        StackMoved.Pop();
                        if (v < best)
                        {
                            best = v;
                        }
                    }
                }
                return best;
            }
        }
        public void FindBestMove(ref Cell[,] GameBoard, ref Stack<Cell> StackMoved, Position TL, Position TR, Position BL, Position BR, ref Position result, ref int count)
        {
            long BestVal = -1000000000000;
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
            List<Position> list = GenMoves(GameBoard, Cell.PLAYER2, StackMoved);
            for (int x = 0; x < list.Count; x++)
            {
                int i = list[x].Row;
                int j = list[x].Col;
                if (GameBoard[i, j].Status == Cell.EMPTY)
                {
                    long val = MiniMax(ref GameBoard, ref StackMoved, DEPTH, true, TL, TR, BL, BR, ref count);
                    if (val > BestVal)
                    {
                        BestVal = val;
                        result = new Position(i, j);
                    }
                }
            }
        }
    }
}
