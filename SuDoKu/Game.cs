using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDoKu
{
    public partial class Game : Form
    {

        public static Graphics g;
        static Pen blackpen = new Pen(Color.Black, 3);
        static Pen graypen = new Pen(Color.LightGray, 3);
        static public int x, y, a, b, c, i, j;
        static Font f = new Font("Arial", 14);
        static Brush blackbrush = Brushes.Black;
        static Brush whitebrush = Brushes.White;

        int curCOL, curROW, curNUM;

        public Game()
        {
            InitializeComponent();
            g = this.Pnl.CreateGraphics();

        }

        private void Pnl_Paint(object sender, PaintEventArgs e)
        {
            lblStatus.Text = "";
            lblTimeValue.Text = "";
            //g = e.Graphics;

            a = 40; b = 40; c = 40;
            for (x = 0; x < 9; x++)
            {
                for (y = 0; y < 9; y++)
                {
                    g.DrawRectangle(graypen, a, b, c, c);
                    a += 40;
                }
                a = 40;
                b += 40;
            }
            g.DrawLine(blackpen, 160, 40, 160, 400);
            g.DrawLine(blackpen, 280, 40, 280, 400);
            g.DrawLine(blackpen, 40, 160, 400, 160);
            g.DrawLine(blackpen, 40, 280, 400, 280);
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void Clear(int x, int y)
        {
            try { g.FillRectangle(whitebrush, (x + 1) * 40 + 2, (y + 1) * 40 + 2, 35, 36); }
            catch { }
        }

        public static void Fill(int x, int y, int a)
        {
            try
            {
                if (a == 0)
                {
                    return;
                }
                g.DrawString(a.ToString(), f, blackbrush, new Point((x + 1) * 40 + 10, (y + 1) * 40 + 10));
            }
            catch { }
        }


        public static void FirstFill(int[,] grid)
        {
            for (x = 0; x < 9; x++)
            {
                for (y = 0; y < 9; y++)
                {
                    Clear(x, y);
                    int num = grid[y, x];
                    if (num == 0)
                    {
                        continue;
                    }
                    g.DrawString(num.ToString(), f, blackbrush, new Point((x + 1) * 40 + 10, (y + 1) * 40 + 10));
                }
            }
        }


        private void btnSolve_Click(object sender, EventArgs e)
        {
            lblTimeValue.Text = string.Empty;
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(GameConfig.Run));
            t.Start(this);
        }

        private void btnNGame_Click(object sender, EventArgs e)
        {
            GameConfig.CleanBoard();
        }
        public void CheckSolved(bool check, double secs)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new System.Action<bool, double>(this.CheckSolved), new object[] { check, secs });
                return;
            }
            if (check == true) { lblStatus.Text = "Solved"; lblTimeValue.Text = secs.ToString(); }
            else { lblStatus.Text = "Unable to solve"; lblTimeValue.Text = secs.ToString(); }
        }

        private void Pnl_MouseClick(object sender, MouseEventArgs e)
        {

            if (txtEdit.Visible)  {
                setNumBack();
            }
            int x, y, i,j;
            x = e.Location.X;  y = e.Location.Y;
            i = y / 40 - 1;
            if (i < 0 || i > 8) return;
            j = x / 40 - 1;
            if (j < 0 || j > 8) return;

            curCOL = j; curROW = i; curNUM = GameConfig.grid[i, j];            
            txtEdit.Location = new Point(j * 40 + 40 +5, i * 40 + 40 + 5);
            txtEdit.Text = curNUM.ToString();
            txtEdit.Visible = true;
        }

        private void Game_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEdit.Visible)
            {
                setNumBack();
            }
        }

        private void setNumBack()
        {
            int num;
            try  {
                num = Convert.ToInt32(txtEdit.Text);                
            }
            catch { num = curNUM; }
            GameConfig.grid[ curROW,curCOL] = num;
            txtEdit.Visible = false;
            Game.Fill(curCOL, curROW, num);
        }

        private void txtEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter) { setNumBack(); }
        }
    }
}

