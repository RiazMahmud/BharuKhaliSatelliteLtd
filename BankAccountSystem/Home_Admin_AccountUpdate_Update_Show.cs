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
    public partial class Home_Admin_AccountUpdate_Update_Show : Form
    {
        public Home_Admin_AccountUpdate_Update_Show()
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

        public int index;
        public void giveIndex(int i)
        {
            index = i;
        }
        private void Home_Admin_AccountUpdate_Update_Show_Load(object sender, EventArgs e)
        {
            Account_BO account_BO = new Account_BO();
            ArrayList list = new ArrayList(account_BO.readAccount());

            setFullScreen();
            setMainPanelPosition();
            setRightOptionPanel();
            rightOptionPnlTimer.Start();

            try
            {
                int j;
                for (j = index; list[j].ToString() != "*****"; j++)
                {

                }
                string k = list[j - 1].ToString();

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
            catch (Exception)
            {
                MessageBox.Show("Error !!");
            }
        }
        private void closeUpdateShow_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountUpdate h = new Home_Admin_AccountUpdate();
            h.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin home_Admin = new Home_Admin();
            home_Admin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_CreateAccount home_Admin_Create = new Home_Admin_CreateAccount();
            home_Admin_Create.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountStatement home_Admin_Accountstatement = new Home_Admin_AccountStatement();
            home_Admin_Accountstatement.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountUpdate home_Admin_AccountUpdate = new Home_Admin_AccountUpdate();
            home_Admin_AccountUpdate.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountRemove home_Admin_AccountRemove = new Home_Admin_AccountRemove();
            home_Admin_AccountRemove.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountWithdraw home_Admin_AccountWithdraw = new Home_Admin_AccountWithdraw();
            home_Admin_AccountWithdraw.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            time_lbl.Text = dt.ToString();
        }

        private void Home_Admin_AccountUpdate_Update_Show_MouseMove(object sender, MouseEventArgs e)
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
