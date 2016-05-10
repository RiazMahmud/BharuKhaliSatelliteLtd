using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CalendarClock;
using System.Diagnostics;
namespace BankAccountSystemUI
{
    public partial class Home_Admin : Form
    {
        public Home_Admin()
        {
            InitializeComponent();
            right_option_timer.Start();
        }
        private void setFullScreen()
        {
            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            Location = new Point(0, 0);
            Size = new Size(x, y);
        }
        private void setMainPanelPosition()
        {
            int mX = (Width - home_admin_main_panel.Width) / 2;
            int mY = (Height - home_admin_main_panel.Height) / 2;
            home_admin_main_panel.Location = new Point(mX, mY);
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
        private void Home_Admin_Load(object sender, EventArgs e)
        {
            setFullScreen();
            setMainPanelPosition();
            setRightOptionPanel();
            right_option_timer.Start();
        }

        private void CreateNewAccount_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void AccountStatement_Click(object sender, EventArgs e)
        {
        }

        private void UpdateAccount_Click(object sender, EventArgs e)
        {
        }

        private void RemoveAccount_Click(object sender, EventArgs e)
        {
        }

        private void WithdrawBalance_Click(object sender, EventArgs e)
        { 
        }


        private void DepositBalance_Click(object sender, EventArgs e)
        {
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void home_admin_main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pbStudents_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pnlReports_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlStudents_MouseHover(object sender, EventArgs e)
        {
            entry_new_client_pnl.BackColor = Color.Red;
        }

        private void entry_new_client_pnl_MouseLeave(object sender, EventArgs e)
        {
            entry_new_client_pnl.BackColor = Color.Crimson;
        }

        

      

        private void update_user_pnl_MouseHover(object sender, EventArgs e)
        {
            update_user_pnl.BackColor = Color.HotPink;
        }

        private void update_user_pnl_MouseLeave(object sender, EventArgs e)
        {
            update_user_pnl.BackColor = Color.DeepPink;
        }

       
        private void pbAttendance_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void remove_client_pnl_MouseHover_1(object sender, EventArgs e)
        {
            remove_client_pnl.BackColor = Color.PaleGreen;
        }

        private void remove_client_pnl_MouseLeave_1(object sender, EventArgs e)
        {
            remove_client_pnl.BackColor = Color.SpringGreen;
        }

        private void calendarClock1_Load(object sender, EventArgs e)
        {

        }

        private void bill_payment_pnl_MouseHover(object sender, EventArgs e)
        {
            bill_payment_pnl.BackColor = Color.MediumOrchid;
        }

        private void bill_payment_pnl_MouseLeave(object sender, EventArgs e)
        {
            bill_payment_pnl.BackColor = Color.Purple;
        }

        private void search_pnl_MouseHover(object sender, EventArgs e)
        {
            search_pnl.BackColor = Color.Orange;
        }

        private void search_pnl_MouseLeave(object sender, EventArgs e)
        {
            search_pnl.BackColor = Color.Gold;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pbTransport_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void entry_new_client_pnl_Click(object sender, EventArgs e)
        {
            Home_Admin_CreateAccount hmca = new Home_Admin_CreateAccount();
           
            hmca.Show();
            this.Dispose();
        }
        
        string rightDirection = "right";

        //For animated panels timeout
     
        int RightTimeOut = 0;

        //For animated panels position
       
       
        private void Home_Admin_MouseMove(object sender, MouseEventArgs e)
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

        private void exit_pnl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lock_pnl_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void home_pnl_Click(object sender, EventArgs e)
        {
            rightDirection = "right";
        }

        private void exit_pnl_MouseHover(object sender, EventArgs e)
        {
            exit_pnl.BackColor = Color.Red;
        }

        private void exit_pnl_MouseLeave(object sender, EventArgs e)
        {
            exit_pnl.BackColor = Color.Black;
        }

        private void lock_pnl_MouseHover(object sender, EventArgs e)
        {
            lock_pnl.BackColor = Color.Red;
        }

        private void lock_pnl_MouseLeave(object sender, EventArgs e)
        {
            lock_pnl.BackColor = Color.Black;
        }

        private void home_pnl_MouseHover(object sender, EventArgs e)
        {
            home_pnl.BackColor = Color.Red;
        }

        private void home_pnl_MouseLeave(object sender, EventArgs e)
        {
            home_pnl.BackColor = Color.Black;
        }

        private void entry_new_client_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTransport_Click(object sender, EventArgs e)
        {
            Home_Admin_AccountStatement hs = new Home_Admin_AccountStatement();
            this.Hide();
            hs.Show();
        }

        private void remove_client_pnl_Click(object sender, EventArgs e)
        {
            Home_Admin_AccountRemove hr = new Home_Admin_AccountRemove();
            this.Hide();
            hr.Show();

        }

        private void update_user_pnl_Click(object sender, EventArgs e)
        {
            Home_Admin_AccountUpdate hu = new Home_Admin_AccountUpdate();
            this.Hide();
            hu.Show();
        }

        private void bill_payment_pnl_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void bill_payment_pnl_Click(object sender, EventArgs e)
        {     
            Home_Admin_AccountWithdraw hw = new Home_Admin_AccountWithdraw();
            this.Hide();
            hw.Show();
        }

        private void pnlSearch_MouseHover(object sender, EventArgs e)
        {
            total_User_pnl.BackColor = Color.Aquamarine;
        }

        private void total_User_pnl_MouseLeave(object sender, EventArgs e)
        {
            total_User_pnl.BackColor = Color.Aqua;
        }

        private void total_User_pnl_Click(object sender, EventArgs e)
        {
            Home_Admin_Total_User ht = new Home_Admin_Total_User();
            this.Hide();
            ht.Show();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            owner_Expenditure_pnl.BackColor = Color.RoyalBlue;
        }

        private void owner_Expenditure_pnl_MouseLeave(object sender, EventArgs e)
        {
            owner_Expenditure_pnl.BackColor = Color.MediumBlue;
        }

        private void owner_Expenditure_pnl_Click(object sender, EventArgs e)
        {
            Home_Admin_Owner_Expenditure hx = new Home_Admin_Owner_Expenditure();
            this.Hide();
            hx.Show();

        }

        private void search_pnl_Click(object sender, EventArgs e)
        {
            Home_Admin_Note ht = new Home_Admin_Note();
            this.Hide();
            ht.Show();
        }

        private void userStatement_pnl_MouseHover(object sender, EventArgs e)
        {
            userStatement_pnl.BackColor = Color.GreenYellow;
        }

        private void userStatement_pnl_MouseLeave(object sender, EventArgs e)
        {
            userStatement_pnl.BackColor = Color.LawnGreen;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            ownerIncome_pnl.BackColor = Color.Red;
        }

        private void ownerIncome_pnl_MouseLeave(object sender, EventArgs e)
        {
            ownerIncome_pnl.BackColor = Color.OrangeRed;
        }

        private void ownerIncome_pnl_Click(object sender, EventArgs e)
        {
            Home_Admin_Owner_Income hi = new Home_Admin_Owner_Income();
            this.Hide();
            hi.Show();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Process.Start("www.facebook.com");
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Process.Start("www.google.com");
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Process.Start("www.youtube.com");
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Process.Start("https://en.wikipedia.org/wiki/Main_Page");
        }
    }
}
