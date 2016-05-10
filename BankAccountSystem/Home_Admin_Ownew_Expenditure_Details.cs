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
    public partial class Home_Admin_Ownew_Expenditure_Details : Form
    {
        public Home_Admin_Ownew_Expenditure_Details()
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
        int f1 = 0;
        int i;
        int j, k;
        public void giveIndex(int m)
        {
            i = m;
            f1 = 1;
        }
        int[] index2;
        public void giveIndex1(int[] a)
        {
            index2 = a;
            f1 = 2;
        }
        private void NoADD_Click(object sender, EventArgs e)
        {
           
        }
        
        public void giveData(int i, int j, string k)
        {
           

        }
        private void yesADD_Click(object sender, EventArgs e)
        {

        }

        private void yesADD_Click_1(object sender, EventArgs e)
        {

        }

        private void NoADD_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void Home_Admin_Ownew_Expenditure_Details_Load(object sender, EventArgs e)
        {
            setFullScreen();
            setMainPanelPosition();
            setRightOptionPanel();
            rightOptionPnlTimer.Start();
            try
            {
                Account_BO ab = new Account_BO();
                ArrayList cost = new ArrayList();
                cost = ab.getOwnerCost();
                if (f1 == 1)
                {
                    int f = 0;
                    int b;
                    for (b = i; cost[b].ToString() != "*"; b++)
                    {
                    }
                    for (int a = i; a < b - 1; a = a + 2)
                    {
                        if (f == 0)
                        {
                            ownerDataGridView.Rows.Add(cost[a].ToString(), cost[a + 1].ToString(), cost[a + 2].ToString());
                            f = 1;
                        }
                        else
                        {
                            ownerDataGridView.Rows.Add(cost[i].ToString(), cost[a + 1].ToString(), cost[a + 2].ToString());
                        }

                    }
                    int sum = 0;

                    for (int j = 0; j < ownerDataGridView.Rows.Count; j++)
                    {
                        sum += Convert.ToInt32(ownerDataGridView.Rows[j].Cells[2].Value);
                    }
                    ownerDataGridView.Rows.Add("", "", "");
                    ownerDataGridView.Rows.Add("Total", "", sum.ToString());
                }
                if (f1 == 2)
                {
                    for (int i = 0; index2[i] != 0; i++)
                    {
                        if (index2[i] == 1)
                        {
                            int f = 0;
                            int b;
                            for (b = 0; cost[b].ToString() != "*"; b++)
                            {
                            }
                            for (int a = 0; a < b - 1; a = a + 2)
                            {
                                if (f == 0)
                                {
                                    ownerDataGridView.Rows.Add(cost[a].ToString(), cost[a + 1].ToString(), cost[a + 2].ToString());
                                    f = 1;
                                }
                                else
                                {
                                    ownerDataGridView.Rows.Add(cost[0].ToString(), cost[a + 1].ToString(), cost[a + 2].ToString());
                                }

                            }
                        }
                        else
                        {
                            int f = 0;
                            int b;
                            for (b = index2[i]; cost[b].ToString() != "*"; b++)
                            {
                            }
                            for (int a = index2[i]; a < b - 1; a = a + 2)
                            {
                                if (f == 0)
                                {
                                    ownerDataGridView.Rows.Add(cost[a].ToString(), cost[a + 1].ToString(), cost[a + 2].ToString());
                                    f = 1;
                                }
                                else
                                {
                                    ownerDataGridView.Rows.Add(cost[index2[i]].ToString(), cost[a + 1].ToString(), cost[a + 2].ToString());
                                }

                            }
                        }
                    }
                    int sum = 0;

                    for (int j = 0; j < ownerDataGridView.Rows.Count; j++)
                    {
                        sum += Convert.ToInt32(ownerDataGridView.Rows[j].Cells[2].Value);
                    }
                    ownerDataGridView.Rows.Add("", "", "");
                    ownerDataGridView.Rows.Add("Total", "", sum.ToString());
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Home_Admin_Ownew_Expenditure_Details_MouseMove(object sender, MouseEventArgs e)
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
