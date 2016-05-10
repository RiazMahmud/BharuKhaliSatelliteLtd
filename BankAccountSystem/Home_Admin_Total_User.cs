using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using System.Collections;
namespace BankAccountSystemUI
{
    public partial class Home_Admin_Total_User : Form
    {
        public Home_Admin_Total_User()
        {
            InitializeComponent();
        }

        string rightDirection = "right";

        int RightTimeOut = 0;
        private void setFullScreen()
        {
            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            Location = new Point(0, 0);
            Size = new Size(x, y);
        }
        private void setMainPanelPosition()
        {
            int mX = (Width - home_admin_createAccount_pnl.Width) / 2;
            int mY = (Height - home_admin_createAccount_pnl.Height) / 2;
            home_admin_createAccount_pnl.Location = new Point(mX, mY);
        }
        int rightX;
        int rightY;
        private void setRightOptionPanel()
        {
            int y = Height;
            rightY = 0;
            rightX = Width + right_pnl.Width;
            right_pnl.Size = new Size(right_pnl.Width, y);
            right_pnl.Location = new Point(rightX, rightY);
            int rX = pnlRightMain.Location.X;
            int rY = (right_pnl.Height - pnlRightMain.Height) / 2;
            pnlRightMain.Location = new Point(rX, rY);
        }

        public void giveDocData(string year, string month)
        {
         
        }
        
        private void Document_Load(object sender, EventArgs e)
        {
            setFullScreen();
            setMainPanelPosition();
            setRightOptionPanel();
            rightOptionPnlTimer.Start();
            Account_BO ab = new Account_BO();
            ArrayList list = new ArrayList(ab.readAccount());
            for (int i = 0; i < list.Count; i=i+13)
            {
                totalUserGridView.Rows.Add(list[i].ToString(), list[i + 1].ToString(), list[i + 2].ToString(), list[i + 3].ToString(), list[i + 4].ToString(), list[i + 5].ToString(), list[i + 6].ToString(), list[i + 7].ToString(), list[i + 8].ToString(), list[i + 9].ToString(), list[i+10].ToString());
            }
            totalUser_lbl.Text = ab.getTotalUser().ToString();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void homeCrossPanel_MouseHover(object sender, EventArgs e)
        {

        }

        private void homeCrossPanel_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void homeCrossPanel_Click(object sender, EventArgs e)
        {
           
        }

        private void Home_Admin_Total_User_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y >= Height - 15 && e.X < (Width - right_pnl.Width))
            {

                rightDirection = "right";

            }
            if (e.X >= Width - 15)
            {
                rightDirection = "left";
                RightTimeOut = 0;

            }
            if (e.X < (Width - right_pnl.Width))
            {
                rightDirection = "Left";
            }
        }

        private void rightOptionPnlTimer_Tick(object sender, EventArgs e)
        {
            if (RightTimeOut < 1000)
            {
                RightTimeOut++;
            }
            if (RightTimeOut == 1000)
            {
                if (rightDirection == "left")
                {
                    rightDirection = "right";
                }
            }
            if (rightDirection == "left")
            {
                if (rightX > Width - right_pnl.Width)
                {
                    rightX -= 3;
                    right_pnl.Location = new Point(rightX, rightY);
                }
            }
            else
            {
                if (rightX < Width)
                {
                    rightX += 3;
                }
                right_pnl.Location = new Point(rightX, rightY);
            }
        }

        private void home_pnl_MouseHover(object sender, EventArgs e)
        {
            home_pnl.BackColor = Color.Red;
        }

        private void home_pnl_MouseLeave(object sender, EventArgs e)
        {
            home_pnl.BackColor = Color.Black;
        }

        private void lock_pnl_MouseHover(object sender, EventArgs e)
        {
            lock_pnl.BackColor = Color.Red;
        }

        private void lock_pnl_MouseLeave(object sender, EventArgs e)
        {
            lock_pnl.BackColor = Color.Black;
        }

        private void exit_pnl_MouseHover(object sender, EventArgs e)
        {
            exit_pnl.BackColor = Color.Red;
        }

        private void exit_pnl_MouseLeave(object sender, EventArgs e)
        {
            exit_pnl.BackColor = Color.Black;
        }

        private void home_pnl_Click(object sender, EventArgs e)
        {
            Home_Admin hm = new Home_Admin();
            this.Hide();
            hm.Show();
        }

        private void lock_pnl_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void exit_pnl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}