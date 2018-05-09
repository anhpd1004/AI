using AIBigExercise.Controller;
using AIBigExercise.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIBigExercise
{
    public partial class Form1 : Form
    {
        private Board board;
        private CaroGame CaroGame;
        private Graphics g;
        public Form1()
        {
            InitializeComponent();
            CaroGame = new CaroGame();
            g = panelBoard.CreateGraphics();
            groupBox1.MouseLeave += groupBox1_MouseLeave;
            btnPlayerVsPlayer.MouseClick += PvsP;
            btnPlayerVsComputer.MouseClick += PvsC;
            btnThoatGame.MouseClick += exitToolStripMenuItem_Click;
        }

        void groupBox1_MouseLeave(object sender, EventArgs e)
        {
            timerChuChay.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelChuChay.Text = "Xin chào tất cả các bạn, chúng\nmình là nhóm 6.\n" +
                                "Xin chào tất cả các bạn, chúng\nmình là nhóm 6.\n" +
                                "Xin chào tất cả các bạn, chúng\nmình là nhóm 6.\n";
            timerChuChay.Enabled = true;
            picUndo.Enabled = false;
            picRedo.Enabled = false;
            btnNewGame.Enabled = true;
            btnPlayerVsComputer.Enabled = false;
            btnPlayerVsPlayer.Enabled = false;
        }

        private void timerChuChay_Tick(object sender, EventArgs e)
        {
            int x = labelChuChay.Location.X;
            if (labelChuChay.Location.Y + labelChuChay.Height <= 16)
            {
                labelChuChay.Location = new Point(x, 155);
            }
            else
            {
                labelChuChay.Location = new Point(x, labelChuChay.Location.Y - 1);
            }
        }

        private void panelBoard_Paint(object sender, PaintEventArgs e)
        {
            board = CaroGame.GameBoard;
            board.PaintBoard(g);
            CaroGame.RePaintBoard(g);
        }

        private void panelBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if (!CaroGame.IsReady)
                return;
            int x = e.X;
            int y = e.Y;
            bool move = CaroGame.Move(x, y, CaroGame.CellArray[y/Cell.SIZE,x/Cell.SIZE].Status, g);
            if (!move)
                return;
            picUndo.Enabled = true;
            if (CaroGame.TerminalCheck())
            {
                CaroGame.TerminalGame();
                CaroGame.IsReady = false;
            }
            else if (CaroGame.Mode == CaroGame.PLAYER_VS_COM)
            {
                CaroGame.ComMoveByAlBe(g);
                if (CaroGame.TerminalCheck())
                {
                    CaroGame.TerminalGame();
                    CaroGame.IsReady = false;
                }
            }
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            timerChuChay.Enabled = false;
        }

        private void PvsP(object sender, EventArgs e)
        {
            if (CaroGame.StackMoved.Count > 0)
            {

                DialogResult selection = MessageBox.Show("Do you want to play new game?", "New game", MessageBoxButtons.YesNo);
                if (selection == DialogResult.No)
                    return;
            }
            g.Clear(panelBoard.BackColor);
            CaroGame.StartPlayerVsPlayer(g);
            picUndo.Enabled = false;
            picRedo.Enabled = false;
            btnPlayerVsComputer.Enabled = false;
            btnPlayerVsPlayer.Enabled = false;
            btnNewGame.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult selection = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (selection == DialogResult.No)
                e.Cancel = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picUndo_MouseClick(object sender, MouseEventArgs e)
        {
            CaroGame.Undo(g);
            if (CaroGame.StackMoved.Count == 0)
                picUndo.Enabled = false;
            picRedo.Enabled = true;
        }

        private void picRedo_MouseClick(object sender, MouseEventArgs e)
        {
            CaroGame.Redo(g);
            if (CaroGame.StackUndo.Count == 0)
                picRedo.Enabled = false;
            picUndo.Enabled = true;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Z))
            {
                CaroGame.Undo(g);
                if (CaroGame.StackMoved.Count == 0)
                    picUndo.Enabled = false;
                picRedo.Enabled = true;
            }
            else if (keyData == (Keys.Control | Keys.Y))
            {
                CaroGame.Redo(g);
                if (CaroGame.StackUndo.Count == 0)
                    picRedo.Enabled = false;
                picUndo.Enabled = true;
            }
            else if (keyData == (Keys.Control | Keys.N | Keys.P))
            {
                if (CaroGame.StackMoved.Count > 0)
                {

                    DialogResult selection = MessageBox.Show("Do you want to play new game?", "New game", MessageBoxButtons.YesNo);
                    if (selection == DialogResult.No)
                        return false;
                }
                g.Clear(panelBoard.BackColor);
                CaroGame.StartPlayerVsPlayer(g);
                picUndo.Enabled = false;
                picRedo.Enabled = false;
            }
            else if (keyData == (Keys.Control | Keys.N | Keys.C))
            {
                if (CaroGame.StackMoved.Count > 0)
                {

                    DialogResult selection = MessageBox.Show("Do you want to play new game?", "New game", MessageBoxButtons.YesNo);
                    if (selection == DialogResult.No)
                        return false;
                }
                g.Clear(panelBoard.BackColor);
                CaroGame.StartPlayerVsCom(g);
                picUndo.Enabled = true;
                picRedo.Enabled = false;
            }
            else if (keyData == (Keys.Control | Keys.Q))
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void PvsC(object sender, EventArgs e)
        {
            if (CaroGame.StackMoved.Count > 0)
            {

                DialogResult selection = MessageBox.Show("Do you want to play new game?", "New game", MessageBoxButtons.YesNo);
                if (selection == DialogResult.No)
                    return;
            }
            g.Clear(panelBoard.BackColor);
            CaroGame.StartPlayerVsCom(g);
            picUndo.Enabled = true;
            picRedo.Enabled = false;
            btnPlayerVsComputer.Enabled = false;
            btnPlayerVsPlayer.Enabled = false;
            btnNewGame.Enabled = true;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            btnPlayerVsComputer.Enabled = true;
            btnPlayerVsPlayer.Enabled = true;
            btnNewGame.Enabled = false;
        }
    }
}
