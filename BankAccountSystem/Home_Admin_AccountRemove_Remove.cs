using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections;
using BO;
namespace BankAccountSystemUI
{
    public partial class Home_Admin_AccountRemove_Remove : Form
    {
        public Home_Admin_AccountRemove_Remove()
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
        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }
        public int index1;
        public void giveIndex(int i)
        {
            index1 = i;
        }
        private void Remove_Click(object sender, EventArgs e)
        {
           
         }
           
        
        private void Home_Admin_AccountRemove_Remove_Load(object sender, EventArgs e)
        {
            Account_BO account_BO = new Account_BO();
            ArrayList list = new ArrayList(account_BO.readAccount());

            setFullScreen();
            setMainPanelPosition();
            setRightOptionPanel();
            rightOptionPnlTimer.Start();

            int j;
            for (j = index1; list[j].ToString() != "*****"; j++)
            {

            }
            string k = list[j - 1].ToString();
            int index = index1;
            int temp = index1;
            userID.Text = list[index].ToString();
            userName.Text = list[index + 1].ToString();
            address.Text = list[index + 2].ToString();
            gender.Text = list[index + 3].ToString();
            dateOfBirth.Text = list[index + 4].ToString();
            occupation.Text = list[index + 5].ToString();
            mob.Text = list[index + 7].ToString();
            lan.Text = list[index + 8].ToString();
            email.Text = list[index + 9].ToString();
            stDate.Text = list[index + 10].ToString();
           
            pictureBox.Load(k);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
          
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void Home_Admin_AccountRemove_Remove_MouseMove(object sender, MouseEventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void accept_pnl_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void accept_pnl_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void cancel_pnl_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void cancel_pnl_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void accept_pnl_Click(object sender, EventArgs e)
        {
            
        }

        private void cancel_pnl_Click(object sender, EventArgs e)
        {
           
        }

        private void Pay_btn_Click(object sender, EventArgs e)
        {
            Account_BO account_BO = new Account_BO();
            ArrayList list = new ArrayList(account_BO.readAccount());
            ArrayList userBill = new ArrayList(account_BO.getUserBill());

            try
            {
                int temp = index1;

                int i;
                int k = 1; ;
                for (i = index1; list[i].ToString() != "*****"; i++)
                {
                    k++;
                }

                int m = 0;

                while (userBill[m].ToString() != list[index1].ToString())
                {
                    m++;
                }

                int n;
                int o = 1;
                for (n = m; userBill[n].ToString() != "*"; n++)
                {
                    o++;
                }

                
                userBill.RemoveRange(m, o);
                list.RemoveRange(temp, k);
                account_BO.createAccount(list);
                account_BO.decreaseTotalUser();
                account_BO.setUserBill(userBill);

                MessageBox.Show("Account remove successfull...");

                this.Hide();
                Home_Admin home_Admin = new Home_Admin();
                home_Admin.Show();
            }
            catch
            {
                MessageBox.Show("Wrong!!!");
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Home_Admin hm = new Home_Admin();
            this.Hide();
            hm.Show();
        }
    }
}
