using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace T138384_OwnProgram_LuongTrungKien
{
    public partial class frmOwnProgram : Form
    {
        public frmOwnProgram()
        {
            InitializeComponent();
            this.picImage.Click +=new EventHandler(picImage_Click);
            this.btnHelp.Click +=new EventHandler(btnHelp_Click);
            this.btnRestart.Click +=new EventHandler(btnRestart_Click);
            this.btnStart.Click +=new EventHandler(btnStart_Click);
            this.btnPause.Click +=new EventHandler(btnPause_Click);
            this.btnContinue.Click +=new EventHandler(btnContinue_Click);
            this.tmStart.Tick += new EventHandler(tmStart_Tick);
            this.tmRun.Tick += new EventHandler(tmRun_Tick);
            pointOne = picImagestone.Location;
            pointTwo = picImagestone2.Location;
            pointPoin = picImage.Location;
            pointiMoves = new Point(pointPoin.Y, pointPoin.X + 170);
            pointMoves = new Point(pointPoin.X, pointPoin.Y - 170);
            iBall = false;
            btnRestart.Visible = false;
            btnPause.Visible = false;
            btnContinue.Visible = false;
            ChangeScorers(0);
            ChangeHightScorers();
            lblTxt.Text = "Bấm \"Bắt đầu\" để chơi.";
        }
        private Point pointOne;
        private Point pointTwo;
        private Point pointMoves;
        private Point pointiMoves;
        private Point pointPoin;
        private bool iBall;
        private int iScores;

        void picImage_Click(object sender, EventArgs e)
        {
            if (iBall )
            {
                picImage.Location = pointiMoves;
                picImage.Location = pointMoves;
                iBall = !iBall;
                tmRun.Enabled = true;
                lblTxt.Text = "Click vào khủng long để vượt qua vật cản.";
            }
        }
        void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trò chơi vượt chướng ngại vật.\n"
               + "Người chơi kick vào chú khủng long để vượt qua những cây xương rồng.\n"
               + "Điểm số sẽ được tính khi người chơi vượt qua 1 cây xương rồng.\n"
               + "Nếu không vượt qua được bạn sẽ thua :).");
        }
        void btnRestart_Click(object sender, EventArgs e)
        {
            btnRestart.Visible = false;
            btnStart.Visible = true;
            btnPause.Visible = false;
            btnContinue.Visible = false;
            lblTxt.Text = "Bấm \"Bắt đầu\" để chơi.";
        }
        void btnStart_Click(object sender, EventArgs e)
        {
            iBall = true;
            tmStart.Enabled = true;
            btnStart.Visible = false;
            btnRestart.Visible = false;
            btnContinue.Visible = false;
            btnPause.Visible = true;
            lblTxt.Text = "Click vào khủng long để vượt qua vật cản.";
        }
        void btnPause_Click(object sender, EventArgs e)
        {
            iBall = false;
            tmStart.Enabled = false;
            btnStart.Visible = false;
            btnRestart.Visible = false;
            btnContinue.Visible = true;
            btnPause.Visible = false;
            lblTxt.Text = "Bấm \"Tiếp tục\" để chơi.";
        }
        void btnContinue_Click(object sender, EventArgs e)
        {
            iBall = true;
            tmStart.Enabled = true;
            btnStart.Visible = false;
            btnRestart.Visible = false;
            btnContinue.Visible = false;
            btnPause.Visible = true;
            lblTxt.Text = "Click vào khủng long để vượt qua vật cản.";
        }
        private void ChangeScorers(int i)
        {
            iScores = i;
            lblSocers.Text = "Điểm: " + iScores.ToString();
        }

        private void ChangeScorers()
        {
            ChangeScorers(iScores + 1);
        }
        private bool iOver()
        {
            int X = picImagestone.Location.X - picImage.Location.X;
            int Y = picImagestone.Location.Y - picImage.Location.Y;
            int X2 = picImagestone2.Location.X - picImage.Location.X;
            int Y2 = picImagestone2.Location.Y - picImage.Location.Y;
            X = Math.Abs(X); Y = Math.Abs(Y);
            X2 = Math.Abs(X2); Y = Math.Abs(Y2);
            if (X < 10 && Y < 10 || X2 < 10 && Y2 < 10)
            {
                return true;
            }
            else 
            {
                return false;
            } 
        }
        private int getHightScorers()
        {
            int iHightScorers = 0;
            try
            {
                using (StreamReader Scorers = new StreamReader("Scorers.txt"))
                {
                    String A = Scorers.ReadToEnd();
                    iHightScorers = int.Parse(A);
                    Scorers.Close();
                }
            }
            catch (Exception) { }
            return iHightScorers;
        }
        private void setHightScorers()
        {
            StreamWriter write = new StreamWriter("Scorers.txt");
            if (iScores > getHightScorers())
            {
                write.Write(iScores);
            }
            write.Close();
        }
        private void ChangeHightScorers()
        {
            lblHightSocers.Text = "Điểm cao nhất: " + getHightScorers().ToString();
        }
        void tmStart_Tick(object sender, EventArgs e)
        {
            if (picImagestone.Location.X < 0)
            {
                picImagestone.Location = pointOne;
                ChangeScorers();
            }
            if (picImagestone2.Location.X < 0)
            {
                picImagestone2.Location = pointOne;
                ChangeScorers();
            }
            picImagestone.Location = new Point(picImagestone.Location.X - 4, picImagestone.Location.Y);
            picImagestone2.Location = new Point(picImagestone2.Location.X - 4, picImagestone2.Location.Y);
            if (iOver())
            {
                iBall = false;
                tmStart.Enabled = false;
                btnRestart.Visible = true;
                btnPause.Visible = false;
                lblTxt.Text = "Bạn đã thua, bấm \"Chơi Lại\" để bắt đầu game mới.";
                DialogResult Dialog = MessageBox.Show("Bạn muốn chơi lại chứ !!!","Game Over !!!",MessageBoxButtons.YesNo);

                if (Dialog == DialogResult.Yes)
                {
                    picImagestone.Location = pointOne;
                    picImagestone2.Location = pointTwo;
                    tmStart.Enabled = false;
                    setHightScorers();
                    ChangeHightScorers();
                    ChangeScorers(0);
                    btnRestart.Visible = true;
                    btnPause.Visible = false;
                }
                else if (Dialog == DialogResult.No)
                {
                    MessageBox.Show("Hẹn gặp lại bạn !!!\n","Exit !!!");
                    Application.Exit();
                }
            }
        }
        void tmRun_Tick(object sender, EventArgs e)
        {
            picImage.Location = new Point(picImage.Location.X, picImage.Location.Y + 5);

            if (picImage.Location.Y >= pointPoin.Y)
            {
                iBall = !iBall;
                tmRun.Enabled = false;
            }
            
        }

        private void frmOwnProgram_Load(object sender, EventArgs e)
        {

        }
    }
}
