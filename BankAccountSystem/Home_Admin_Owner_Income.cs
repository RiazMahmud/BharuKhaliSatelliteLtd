using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using BO;
namespace BankAccountSystemUI

{
    public partial class Home_Admin_Owner_Income : Form
    {
        public Home_Admin_Owner_Income()
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
        private void DocumentChecker_Load(object sender, EventArgs e)
        {
            setFullScreen();
            setMainPanelPosition();
            setRightOptionPanel();
            rightOptionPnlTimer.Start();
        }

        private void ShowAccountStatement_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Home_Admin_Owner_Income_MouseMove(object sender, MouseEventArgs e)
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

        private void exit_pnl_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void exit_pnl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void view1_btn_Click(object sender, EventArgs e)
        {
            Account_BO account_BO = new Account_BO();
            ArrayList cost = new ArrayList();
            cost = account_BO.getOwnerincome();
            int f = 0;
            Home_Admin_Owner_Income_Details he = new Home_Admin_Owner_Income_Details();
            for (int i = 0; i < cost.Count; i++)
            {

                if (search_dtp.Text == cost[i].ToString())
                {

                    he.giveIndex(i);
                    this.Hide();
                    he.Show();
                    f = 1;
                    break;

                }
            }
            if (f == 0)
                MessageBox.Show("This date is not exist");
        }

        private void view2_btn_Click(object sender, EventArgs e)
        {
            Account_BO account_BO = new Account_BO();
             if (year1 != null && month != null)
            {
                ArrayList cost = new ArrayList();
                cost = account_BO.getOwnerincome();

                int[] index = new int[200];
                int[] index2 = new int[200];
                int j = 0;
                int i1;
                for (i1 = 0; i1 < cost.Count; i1++)
                {

                    if (cost[i1].ToString() == "*")
                    {
                        index[j] = i1 + 1;
                        j++;
                    }
                }
                index[j - 1] = 0;
                int month_value = 0;
                int year_value = 0;
                try
                {
                    year_value = Convert.ToInt32(year1.Text);
                }
                catch
                {
                   
                }
                if (month.Text == "January")
                {
                    month_value = 1;
                }

                else if (month.Text == "February")
                {
                    month_value = 2;
                }
                else if (month.Text == "March")
                {
                    month_value = 3;
                }
                else if (month.Text == "April")
                {
                    month_value = 4;
                }
                else if (month.Text == "May")
                {
                    month_value = 5;
                }
                else if (month.Text == "June")
                {
                    month_value = 6;
                }
                else if (month.Text == "July")
                {
                    month_value = 7;
                }
                else if (month.Text == "August")
                {
                    month_value = 8;
                }
                else if (month.Text == "September")
                {
                    month_value = 9;
                }
                else if (month.Text == "October")
                {
                    month_value = 10;
                }
                else if (month.Text == "November")
                {
                    month_value = 11;
                }
                else if (month.Text == "December")
                {
                    month_value = 12;
                }
                int d1 = 0, d2 = 0;
                DateTime dt = DateTime.Parse(cost[0].ToString());
                int m = dt.Month;
                int y = dt.Year;
                int k = 0;
                if (month_value == m && year_value == y)
                {
                    index2[0] = 1;
                    k = 1;
                    d1 = 1;
                }

                for (int i = 0; index[i] != 0; i++)
                {
                    DateTime dt1 = DateTime.Parse(cost[index[i]].ToString());
                    int m1 = dt1.Month;
                    int y1 = dt1.Year;
                    if (month_value == m1 && year_value == y1)
                    {
                        index2[k] = index[i];
                        k++;
                        d2 = 1;
                    }
                }
                if (d1 != 1 && d2 != 1)
                {
                    MessageBox.Show("This month or year is not exist");
                }
                else
                {
                    Home_Admin_Owner_Income_Details he = new Home_Admin_Owner_Income_Details();
                    he.giveIndex1(index2);
                    this.Hide();
                    he.Show();
                }

            }
            else
            {
                MessageBox.Show("Enter the information fully");
                month.ResetText();
                year1.ResetText();
            }
        }

        private void veiwdetils_btn2_Click(object sender, EventArgs e)
        {
            Account_BO account_BO = new Account_BO();
            if (year2 != null)
            {
                ArrayList cost = new ArrayList();
                cost = account_BO.getOwnerincome();

                int[] index = new int[200];
                int[] index2 = new int[200];
                int j = 0;
                int i1;
                for (i1 = 0; i1 < cost.Count; i1++)
                {

                    if (cost[i1].ToString() == "*")
                    {
                        index[j] = i1 + 1;
                        j++;
                    }
                }
                index[j - 1] = 0;
                int year_value = 0;

                try
                {
                    year_value = Convert.ToInt32(year2.Text);
                }
                catch
                {

                }
                int d1 = 0, d2 = 0;
                DateTime dt = DateTime.Parse(cost[0].ToString());
                int y = dt.Year;
                int k = 0;
                if (year_value == y)
                {
                    index2[0] = 1;
                    k = 1;
                    d1 = 1;
                }

                for (int i = 0; index[i] != 0; i++)
                {
                    DateTime dt1 = DateTime.Parse(cost[index[i]].ToString());
                    int y1 = dt1.Year;
                    if (year_value == y1)
                    {
                        index2[k] = index[i];
                        k++;
                        d2 = 1;
                    }
                }
                if (d1 != 1 && d2 != 1)
                {
                    MessageBox.Show("This month or year is not exist");
                }
                else
                {

                    Home_Admin_Owner_Income_Details he = new Home_Admin_Owner_Income_Details();
                    he.giveIndex1(index2);
                    this.Hide();
                    he.Show();
                }

            }
            else
            {
                MessageBox.Show("Enter the information fully");
                year2.ResetText();
            }
        }
        
    }
}
