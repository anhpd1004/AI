using AIBigExercise.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIBigExercise.Controller
{
    class State
    {
        public Position p;
        public long val;
        public State()
        {
            
        }
        public State(Position p, long val)
        {
            this.p = new Position();
            this.p.Row = p.Row;
            this.p.Col = p.Col;
            this.val = val;
        }
        public void Set(Position p, long val)
        {
            this.p = new Position();
            this.p.Row = p.Row;
            this.p.Col = p.Col;
            this.val = val;
        }
    }
}
