//using AIBigExercise.Objects;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AIBigExercise.Controller
//{
//    class AlphaBetaSearching : BaseSearching
//    {
//        public long Albe(ref Cell[,] GameBoard, int depth, bool IsMax, Position TL, Position TR, Position BL, Position BR)
//        {
//            if (depth == DEPTH)
//            {
//                if (TL.Row - 2 >= 0)
//                    TL.Row -= 2;
//                if (TL.Col - 2 >= 0)
//                    TL.Col -= 2;
//                if (TR.Col + 2 <= n - 1)
//                    TR.Col += 2;
//                if (TR.Row - 2 >= 0)
//                    TR.Row -= 2;
//                if (BL.Row + 2 <= n - 1)
//                    BL.Row += 2;
//                if (BL.Col - 2 >= 0)
//                    BL.Col -= 2;
//                if (BR.Row + 2 <= n - 1)
//                    BR.Row += 2;
//                if (BR.Col + 2 <= n - 1)
//                    BR.Col += 2;
//            }
//            long BestMax = -1000000000000;
//            long BestMin = 1000000000000;
//            if (depth == 0)
//            {
//                return Evaluate(GameBoard, Cell.PLAYER2);
//            }
//            if (IsMax)
//            {
//                List<Position> list = GenMoves(GameBoard, Cell.PLAYER2, TL, TR, BL, BR);
//                for (int x = 0; x < list.Count; x++)
//                {
//                    int i = list[x].Row;
//                    int j = list[x].Col;
//                    if (GameBoard[i, j].Status == Cell.EMPTY)
//                    {
//                        GameBoard[i, j].Status = Cell.PLAYER2;
//                        long v = Albe(ref GameBoard, depth - 1, !IsMax, TL, TR, BL, BR);
//                        GameBoard[i, j].Status = Cell.EMPTY;
//                        if (v <= BestMin)
//                        {
//                            return BestMax;
//                        }
//                        if (v > BestMax)
//                        {
//                            BestMax = v;
//                        }
//                    }
//                }
//                return BestMax;
//            }
//            else
//            {
//                List<Position> list = GenMoves(GameBoard, Cell.PLAYER1, TL, TR, BL, BR);
//                for (int x = 0; x < list.Count; x++)
//                {
//                    int i = list[x].Row;
//                    int j = list[x].Col;
//                    if (GameBoard[i, j].Status == Cell.EMPTY)
//                    {
//                        GameBoard[i, j].Status = Cell.PLAYER1;
//                        long v = Albe(ref GameBoard, depth - 1, !IsMax, TL, TR, BL, BR);
//                        GameBoard[i, j].Status = Cell.EMPTY;
//                        if (v >= BestMax)
//                        {
//                            return BestMin;
//                        }
//                        if (v < BestMin)
//                        {
//                            BestMin = v;
//                        }
//                    }
//                }
//                return BestMin;
//            }
//        }
//        public override void FindBestMove(ref Cell[,] GameBoard, Position TL, Position TR, Position BL, Position BR, ref Position result)
//        {
//            Cell cell = new Cell();
//            long BestVal = -1000000000000;
//            if (TL.Row - 2 >= 0)
//                TL.Row -= 2;
//            if (TL.Col - 2 >= 0)
//                TL.Col -= 2;
//            if (TR.Col + 2 <= n - 1)
//                TR.Col += 2;
//            if (TR.Row - 2 >= 0)
//                TR.Row -= 2;
//            if (BL.Row + 2 <= n - 1)
//                BL.Row += 2;
//            if (BL.Col - 2 >= 0)
//                BL.Col -= 2;
//            if (BR.Row + 2 <= n - 1)
//                BR.Row += 2;
//            if (BR.Col + 2 <= n - 1)
//                BR.Col += 2;
//            List<Position> list = GenMoves(GameBoard, Cell.PLAYER2, TL, TR, BL, BR);
//            for (int x = 0; x < list.Count; x++)
//            {
//                int i = list[x].Row;
//                int j = list[x].Col;
//                if (GameBoard[i, j].Status == Cell.EMPTY)
//                {
//                    GameBoard[i, j].Status = Cell.PLAYER2;
//                    long val = Albe(ref GameBoard, DEPTH - 1, false, TL, TR, BL, BR);
//                    GameBoard[i, j].Status = Cell.EMPTY;
//                    if (val > BestVal)
//                    {
//                        BestVal = val;
//                        result = new Position(i, j);
//                    }
//                }
//            }
//        }
//    }
//}
